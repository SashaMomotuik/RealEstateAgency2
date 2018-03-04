using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public  class RoomAddViewModel
    {

        public int SelectCityId { get; set; }
        public int SelectDistrictId { get; set; }
        public int SelectStreetId { get; set; }
        public int NumberHouseID { get; set; }
        public int NumberHouse { get; set; }
        public int NumberRoom { get; set; }
        public double price { get; set; }
        public int Floor { get; set; }
        public int CountRoom { get; set; }
        public double Square { get; set; }
        public bool Reserved { get; set; }
        public bool Sales { get; set; }

       // public List <byte[]> Photos { get; set; }
        public virtual PhotoCollection Images { get; set; }

    }
}
