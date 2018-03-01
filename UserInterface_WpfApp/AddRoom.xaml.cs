using BLL.Abstract;
using BLL.Model;
using BLL.Provideer;
using Microsoft.Win32;
using RealEstateAgency2;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace UserInterface_Wpf
{
    /// <summary>
    /// Interaction logic for AddRoom.xaml
    /// </summary>






    public partial class AddRoom : Window
    {

        public BLL.Model.PhotoCollection Photos;

        private readonly IAdressProvider adressProvider;

        private readonly IRoomProvider roomProvider;



        public AddRoom()
        {
            InitializeComponent();
            adressProvider = new AdressProvider();
            roomProvider = new RoomProvider();

            Photos = (BLL.Model.PhotoCollection)(this.Resources["Photos"] as ObjectDataProvider).Data;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            IList<City> cities = adressProvider.GetAllCities().ToList();


            ComboCities.DataContext = cities;




        }

        private void ComboCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = int.Parse(ComboCities.SelectedValue.ToString());

            IList<District> districts = adressProvider.GetDistricts(item).ToList();

            ComboDistricts.DataContext = districts;

        }

        private void ComboDistricts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = int.Parse(ComboDistricts.SelectedValue.ToString());



            ComboStreets.DataContext = adressProvider.GetStreets(item);

        }

        private void ButtonAddImage_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames) // мульти добавление изображений
                {
                    this.Photos.AddImage(filename);
                }
            }

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {

            bool reserved = false;
            bool sales = false;

            if (cmbResYes.IsChecked == true) reserved = true;
            else reserved = false;

            if (cmbSalYes.IsChecked == true) sales = true;
            else sales = false;



            RoomAddViewModel roomAddModel = new RoomAddViewModel
            {
                SelectCityId = int.Parse(ComboCities.SelectedValue.ToString()),
                SelectDistrictId = int.Parse(ComboDistricts.SelectedValue.ToString()),
                SelectStreetId = int.Parse(ComboStreets.SelectedValue.ToString()),
                NumberHouse = int.Parse(TxtBoxNumber.Text),
                NumberRoom = int.Parse(TxtBoxNumberRoom.Text),
                CountRoom = int.Parse(TxtBoxNumberRoom.Text),
                Floor = int.Parse(TxtBoxNumberRoom.Text),
                price = double.Parse(TxtBoxNumberRoom.Text),
                Square = double.Parse(TxtBoxNumberRoom.Text),
                Reserved = reserved,
                Sales = sales,
                Images = Photos

            };

            var prod = roomProvider.AddRoom(roomAddModel);
            if (prod != null) this.Close();

        }
    }
}
