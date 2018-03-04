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

namespace UserInterface_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RoomShowCollection RoomCollection;
        private readonly IRoomProvider roomProvider;
        public MainWindow()
        {
            InitializeComponent();



            RoomCollection = (RoomShowCollection)(this.Resources["RoomCollection"] as ObjectDataProvider).Data;
            roomProvider = new RoomProvider();

            //dataGrid.ItemsSource = RoomCollection;
            dataGrid.ItemsSource = roomProvider.GetAllRooms();

         
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddRoom WindowAddRoom = new AddRoom();
            WindowAddRoom.ShowDialog();
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
