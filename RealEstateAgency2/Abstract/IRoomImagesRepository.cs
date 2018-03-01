using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
   public interface IRoomImagesRepository
    {
        RoomImage Add(RoomImage roomImages);

        void Remove(RoomImage roomImages);
        IQueryable<RoomImage> GetAll();

        int SaveChanges();
    }
}
