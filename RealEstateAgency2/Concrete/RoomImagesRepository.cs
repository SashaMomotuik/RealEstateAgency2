using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class RoomImagesRepository : IRoomImagesRepository
    {

        private readonly EFContext _context;

        public RoomImagesRepository(EFContext context)
        {
            _context = context;
        }
        public RoomImage Add(RoomImage roomImages)
        {
            _context.RoomsImages.Add(roomImages);
            return roomImages;
        }

        public IQueryable<RoomImage> GetAll()
        {
            return _context.RoomsImages.AsQueryable();
        }

        public void Remove(RoomImage roomImages)
        {
            _context.RoomsImages.Remove(roomImages);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
