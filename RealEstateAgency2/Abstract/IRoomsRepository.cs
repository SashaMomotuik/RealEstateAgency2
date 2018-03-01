using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
  public  interface IRoomsRepository
    {

        Room Add(Room rooms);

        void Remove(Room rooms);
        IQueryable<Room> GetAll();

        int SaveChanges();

    }
}
