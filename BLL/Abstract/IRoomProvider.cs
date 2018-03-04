using BLL.Model;
using RealEstateAgency2;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
     public interface IRoomProvider
    {
        Room AddRoom(RoomAddViewModel roomAddModel);

        IList<RoomShowViewModel> GetAllRooms();

        void DataBaseToExcell();
    }
}
