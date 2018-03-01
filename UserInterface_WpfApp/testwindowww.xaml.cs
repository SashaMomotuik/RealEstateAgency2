using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UserInterface_WpfApp
{
    /// <summary>
    /// Interaction logic for testwindowww.xaml
    /// </summary>
    public partial class testwindowww : Window
    {
        public testwindowww()
        {
            InitializeComponent();

            //RealEstateAgency2.RealEstateAgencyEntities context = new RealEstateAgency2.MyContext();
            //RealEstateAgency2.Concrete.RoomImagesRepository roomImagesRepository = new RealEstateAgency2.Concrete.RoomImagesRepository(context);


            //List<BitmapFrame> list = new List<BitmapFrame>();

            //List<RealEstateAgency2.tblRoomImages> arr = roomImagesRepository.GetAll()
            //    .Where(p => p.Id == 6)
            //    .ToList();

            //if (arr.Count > 0)
            //{

            //    //local save

            //    //using (System.IO.FileStream fs = new System.IO.FileStream(arr[0].Name, FileMode.OpenOrCreate))
            //    //{
            //    //    fs.Write(arr[0].Photo, 0, arr[0].Photo.Length);
            //    //    Console.WriteLine("Изображение '{0}' сохранено", arr[0].Name);
            //    //}

            //    //memory stream save

            //    foreach (var item in arr)
            //    {
            //        byte[] b = item.Photo.ToArray();

            //        using (MemoryStream ms = new MemoryStream(b))
            //        {
            //            //Image tmp = Image.FromStream(ms);
            //            //list.Add(tmp);
            //            BitmapFrame tmp = BitmapFrame.Create(ms, BitmapCreateOptions.PreservePixelFormat,
            //                    BitmapCacheOption.OnLoad);

            //            list.Add(tmp);


            //        }

            //    }

            //}


            //imgtest.Source = list[0];


        }
    }
}
