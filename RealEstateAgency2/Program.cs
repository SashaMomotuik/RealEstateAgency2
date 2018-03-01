using RealEstateAgency2.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2
{
    class Program
    {
        static void Main(string[] args)
        {

            //RealEstateAgencyEntities context = new RealEstateAgencyEntities();

            //string filename = @"C:\Users\user1\Desktop\Images\1.jpg";
            //int roomId = 1;
            //byte[] imageData;
            //using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
            //{
            //    imageData = new byte[fs.Length];
            //    fs.Read(imageData, 0, imageData.Length);
            //}

            //RoomImagesRepository roomImagesRepository = new RoomImagesRepository(context);


            //tblRoomImages roomImages = new tblRoomImages
            //{
            //    Name = filename,
            //    Photo = imageData,
            //    RoomId = roomId

            //};


            ////context.tblRoomImages.Add(roomImages);
            ////context.SaveChanges();

            //roomImagesRepository.Add(roomImages);
            //roomImagesRepository.SaveChanges();

            //List<Image> list = new List<Image>();
          
            //List<tblRoomImages> arr = roomImagesRepository.GetAll()
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
            //            Image tmp = Image.FromStream(ms);
            //            list.Add(tmp);




            //        }



            //    }



            //}



        }
    }
}
