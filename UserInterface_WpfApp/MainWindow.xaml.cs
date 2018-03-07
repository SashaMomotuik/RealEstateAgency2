using BLL.Abstract;
using BLL.Model;
using BLL.Provideer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserInterface_Wpf;
using System.ComponentModel; //for BackgroundWorker
using System.Threading;

namespace UserInterface_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BackgroundWorker worker ;
        PageInfo pi = new PageInfo() { PageNumber = 1, PageSize = 2 };
        private bool LoadOrFind = true; // if true --> Load Data with database

        public RoomShowCollection RoomCollection;
        private  IRoomProvider roomProvider;

        void RoomProviderLoad()
        {

            roomProvider = new RoomProvider();
        }

        public MainWindow()
        {
            InitializeComponent();

            worker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };


            worker.DoWork += Worker_DoWork; 
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;



         //   roomProvider = new RoomProvider();
          
           

            //dataGrid.ItemsSource = RoomCollection;
            

         
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RoomCollection = (RoomShowCollection)(this.Resources["RoomCollection"] as ObjectDataProvider).Data;

            worker.RunWorkerAsync();
          //  dataGrid.ItemsSource = roomProvider.GetAllRooms();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int k = 0;

            if (LoadOrFind)  //load with database
            {
                    List<RoomShowViewModel> listtogrid = new List<RoomShowViewModel>();

                Task newTask = Task.Factory.StartNew(() => RoomProviderLoad());
                Task.WaitAny(newTask);


                if ( newTask.IsCompleted)
                {


                  pi.TotalItems = roomProvider.GetCount();

                    int skip = 0;

               

                    progBar.Dispatcher.BeginInvoke(new Action(delegate ()
                    {
                        // что-нибудь делаем
                        progBar.Maximum = pi.TotalItems;
                    }));


                    do
                    {
                        
                        var list = roomProvider.GetAllRoomsSkip(pi.PageSize, skip);

                        skip += list.Count();


                        worker.ReportProgress(skip);
                     //   worker.ReportProgress((int)Math.Ceiling((decimal)skip / pi.TotalItems));


                        listtogrid.AddRange(list);

                    dataGrid.Dispatcher.BeginInvoke(new Action(delegate ()
                    {

                        dataGrid.ItemsSource = null;
                       
                        dataGrid.ItemsSource = listtogrid;

                    }
                    ));


                        Thread.Sleep(1000);

                    } while (listtogrid.Count != pi.TotalItems);





                }


              
            }


        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progBar.Value = e.ProgressPercentage;
          label1.Content = e.ProgressPercentage.ToString() + "/" + pi.TotalItems;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          //  throw new NotImplementedException();
        }


        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddRoom WindowAddRoom = new AddRoom();
            WindowAddRoom.ShowDialog();

            dataGrid.ItemsSource = null; 
            dataGrid.ItemsSource = roomProvider.GetAllRooms();
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGrid.SelectedItem == null) return;
            var selectedRoom = dataGrid.SelectedItem as RoomShowViewModel;

            WindowImagesRoom imagesRoom = new WindowImagesRoom(selectedRoom.Photoses);
            imagesRoom.ShowDialog();

          
        }

        private void stekpanelExcell_MouseDown(object sender, MouseButtonEventArgs e)
        {

            roomProvider.DataBaseToExcell();
        }

      
    }
}
