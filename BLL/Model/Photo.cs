using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BLL.Model
{
    public class Photo
    {

        private string _path;
        private string _pathOriginal; // путь к оригинальной фотке
        //private Uri _source;
        private BitmapFrame _image;
        private BitmapFrame _imageOrigin;

        public Photo() { }
        public Photo(string path)
        {
            //if(!(Directory.Exists(Environment.CurrentDirectory + ConfigurationManager.AppSettings["ImagePath"].ToString())))
            //        Directory.CreateDirectory(Environment.CurrentDirectory + ConfigurationManager.AppSettings["ImagePath"].ToString());
            // 
            _pathOriginal = path;
            //_path = "L:\\Temp\\" + Guid.NewGuid().ToString() + ".jpg";
            //_path = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ImagePath"].ToString() + Guid.NewGuid().ToString() + ".jpg";
            using (var image = System.Drawing.Image.FromFile(_pathOriginal))
            {
                using (var newImageSmall = ImageWorker.ConverImageToBitmap(image, 130, 130))
                {
                    #region oldcode
                    //if (newImageSmall != null)
                    //{
                    //    //newImageSmall.Save(_path, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //    //newImageSmall.Dispose();
                    //    using (MemoryStream ms = new MemoryStream())
                    //    {
                    //        //newImageSmall.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    //        //JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    //        TiffBitmapEncoder encoder = new TiffBitmapEncoder();
                    //        //encoder.Frames.Add(BitmapFrame.Create(new Uri(path)));
                    //        encoder.Frames.Add(BitmapFrame.Create(this.Convert(newImageSmall)));
                    //        encoder.Save(ms);
                    //        _image = BitmapFrame.Create(ms, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                    //        //_image = System.Drawing.Image.FromStream(ms);
                    //    }
                    //   
                    //_image =  BitmapFrame.Create(new Uri(_path));
                    //}
                    #endregion
                    if (newImageSmall != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            newImageSmall.Save(ms, ImageFormat.Bmp);
                            _image = BitmapFrame.Create(ms, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
                        }
                    }
                }


                using (var newImageOrigin = ImageWorker.ConverImageToBitmap(image, image.Width, image.Height))
                {
                    if (newImageOrigin != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            newImageOrigin.Save(ms, ImageFormat.Bmp);
                            _imageOrigin = BitmapFrame.Create(ms,
                                BitmapCreateOptions.PreservePixelFormat,
                                BitmapCacheOption.OnLoad);
                        }
                    }
                }
                //_source = new Uri(path);
            }
        }


        public Photo(byte[] arr)
        {

                    using (MemoryStream ms = new MemoryStream(arr))
                    {

                _imageOrigin = BitmapFrame.Create(ms, BitmapCreateOptions.PreservePixelFormat,
                                BitmapCacheOption.OnLoad);

                    }

       
        }


        //public Photo(string path) // конструктор получения изображений из базы
        //{
        //    _path = "s_" +path;
        //    _pathOriginal = "o_" + path;
        //}

        //public Photo(ProductImageViewModel photos) // конструктор получения изображений из базы
        //{
        //    _path = photos.GetImageSmall;
        //    _pathOriginal = photos.GetImageOriginal;


        //    using (var image = System.Drawing.Image.FromFile(_pathOriginal))
        //    {
        //        using (var newImageSmall = ImageWorker.ConverImageToBitmap(image, 130, 130))
        //        {
        //            if (newImageSmall != null)
        //            {
        //                using (MemoryStream ms = new MemoryStream())
        //                {
        //                    newImageSmall.Save(ms, ImageFormat.Bmp);
        //                    _image = BitmapFrame.Create(ms,
        //                        BitmapCreateOptions.PreservePixelFormat,
        //                        BitmapCacheOption.OnLoad);
        //                }
        //            }
        //        }


        //        using (var newImageOrigin = ImageWorker.ConverImageToBitmap(image, image.Width, image.Height))
        //        {
        //            if (newImageOrigin != null)
        //            {
        //                using (MemoryStream ms = new MemoryStream())
        //                {
        //                    newImageOrigin.Save(ms, ImageFormat.Bmp);
        //                    _imageOrigin = BitmapFrame.Create(ms,
        //                        BitmapCreateOptions.PreservePixelFormat,
        //                        BitmapCacheOption.OnLoad);
        //                }
        //            }
        //        }
        //    }


        //}

        public string Source { get { return _path; } } // путь на уменьшенную фотку
        public BitmapFrame ImagePhoto { get { return _image; } }

        public BitmapFrame ImageFrameOrigin
        {
            get { return _imageOrigin; }
            set { _imageOrigin = value; }
        }

        public string SourceOriginal { get { return _pathOriginal; } } // путь на оригинальную фотку


        public string NameImg { get { return Path.GetFileName(_pathOriginal); } }
        public string ImageName { get { return Path.GetFileNameWithoutExtension(_pathOriginal); } }


    }
}
