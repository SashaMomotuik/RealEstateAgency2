using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public  static class ImageToDataBase
    {
        public static byte[] ToBinaryArray(Photo item)
        {
            string filename = item.SourceOriginal;   // @"C:\Users\user1\Desktop\Images\1.jpg";
            byte[] imageData;
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }


            return imageData;
        }


    }
}
