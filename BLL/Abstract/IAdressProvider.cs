using RealEstateAgency2;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IAdressProvider
    {

        IQueryable<City> GetAllCities();

        IQueryable<District> GetDistricts(int cityId);
        IList<District> GetDistricts();

        IList<Street> GetStreets(int districtId);
        IList<Street> GetStreets();

        IList<NumberHouse> GetHouses(int streetId);
        IList<NumberHouse> GetHouses();

        IList<Room> GetRooms(int houseId);
        IList<Room> GetRooms();


    }
}
