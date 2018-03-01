using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class RoomsRepository : IRoomsRepository
    {
        private readonly EFContext _context;

        public RoomsRepository(EFContext context)
        {
            _context = context;
        }


        public Room Add(Room rooms)
        {
            _context.Rooms.Add(rooms);
            return rooms;
        }

        public IQueryable<Room> GetAll()
        {
            return _context.Rooms.AsQueryable();
        }

        public void Remove(Room rooms)
        {
            _context.Rooms.Remove(rooms);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
