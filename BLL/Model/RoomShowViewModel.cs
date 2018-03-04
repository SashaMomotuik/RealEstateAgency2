using BLL.Abstract;
using BLL.Provideer;
using RealEstateAgency2;
using RealEstateAgency2.Abstract;
using RealEstateAgency2.Concrete;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BLL.Model
{
    public class RoomShowViewModel
    {
        private readonly IRoomProvider roomProvider;
        ICollection<RoomShowViewModel> _roomModel;

       

        public RoomShowViewModel()
        {

        }
        public RoomShowViewModel(RoomShowViewModel model)
        {
            _roomModel = new List<RoomShowViewModel>();
            roomProvider = new RoomProvider();
        }

        public ICollection<RoomShowViewModel> GetRooms
        {
            get
            {
                return roomProvider.GetAllRooms();

            }

         
        }

       

     


        public string RoomCity { get; set; }
        public string RoomDistrict { get; set; }
        public string RoomStreet { get; set; }
        public int RoomNumberHouse { get; set; }
        public int NumberRoom { get; set; }
        public decimal Price { get; set; }
        public int Floor { get; set; }
        public int CountRoom { get; set; }
        public decimal Square { get; set; }
        public bool Reserved { get; set; }
        public bool Sales { get; set; }

        public List<byte[]> Photoses { get; set; }


        public BitmapFrame listPhoto {
            get
            {

              return ByteToBitMap()[0];
                
                
            }

        }



         List<BitmapFrame> ByteToBitMap()
        {
            List<BitmapFrame> list = null;
          
        
            if (Photoses.Count > 0)
            {
                list = new List<BitmapFrame>();

                foreach (var item in Photoses)
                {
                    byte[] b = item;

                    using (MemoryStream ms = new MemoryStream(b))
                    {
                      
                        BitmapFrame tmp = BitmapFrame.Create(ms, BitmapCreateOptions.PreservePixelFormat,
                                BitmapCacheOption.OnLoad);

                        list.Add(tmp);
                    }

                }

            }
            return list;




        }

    }
}
