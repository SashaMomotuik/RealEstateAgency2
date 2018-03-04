using BLL.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace UserInterface_WpfApp
{
    /// <summary>
    /// Interaction logic for WindowImagesRoom.xaml
    /// </summary>
    public partial class WindowImagesRoom : Window
    {

        public PhotoCollection Photos;

        public WindowImagesRoom(List<byte[]> arr)
        {
            InitializeComponent();
            Photos = (BLL.Model.PhotoCollection)(this.Resources["Photos"] as ObjectDataProvider).Data;
            if(arr.Count==0)
            {
                string path = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ImageStore"].ToString() + "no_image.png";

                var noimg = ImageToDataBase.ToBinaryArray(path);

                this.Photos.AddImage(noimg);
            }
            //BitmapImage image = new BitmapImage(new Uri(path));
            //ImageBrush brush = new ImageBrush();
            //brush.ImageSource = image;

            //PhotosListBox.Foreground = brush;

            foreach (var item in arr) // мульти добавление изображений
            {
                this.Photos.AddImage(item);
            }


        }
    }
}
