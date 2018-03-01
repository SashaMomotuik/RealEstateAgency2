using RealEstateAgency2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class RoomShowViewModel
    {


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

        public List<byte[]> Photos { get; set; }


    }
}
