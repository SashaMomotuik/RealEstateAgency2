using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    class EFContext :DbContext
    {
        public EFContext() : base("ConnectionAgency")
        {

        }

        //так називатиметься таблиця UserProfiles
        public DbSet<City> Citises { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<NumberHouse> NumberHouses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomImage> RoomsImages { get; set; }


    }
}
