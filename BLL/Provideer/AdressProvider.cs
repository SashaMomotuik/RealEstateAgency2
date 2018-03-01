using BLL.Abstract;
using RealEstateAgency2;
using RealEstateAgency2.Abstract;
using RealEstateAgency2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Provideer
{
    public class AdressProvider : IAdressProvider
    {
        //ICitiesRepository _citiesRepository;
        //IDistrictsRepository _districtsRepository;
        //IStreetsRepository _streetsRepository;
        //INumberHomeRepository _numberHomeRepository;
        //IRoomsRepository _roomsRepository;


        //public AdressProvider()
        //{

        //    RealEstateAgencyEntities context = new RealEstateAgencyEntities();
            

        //    _citiesRepository = new CitiesRepository(context);
        //    _districtsRepository = new DistrictsRepository(context);
        //    _streetsRepository = new StreetsRepository(context);
        //    _numberHomeRepository = new NumberHomeRepository(context);
        //    _roomsRepository = new RoomsRepository(context);
        //}
        //public IQueryable<tblCities> GetAllCities()
        //{
        //    var rez = _citiesRepository.GetAll();

        //    return rez;
        //}

        //public IQueryable<tblDistricts> GetDistricts(int cityId)
        //{
        //    var rez = _districtsRepository.GetAll()
        //          .Where(p => p.CitiesId == cityId)
        //          .OrderBy(c => c.Name);
                 
            
        //    return rez;
        //}
        //public IList<tblDistricts> GetDistricts()
        //{
        //    return _districtsRepository.GetAll().ToList();
        //}


        //public IList<tblStreets> GetStreets(int districtId)
        //{
        //    var rez = _streetsRepository.GetAll()
        //          .Where(p => p.DistrictsId == districtId)
        //          .OrderBy(c => c.Name)
        //          .ToList();
        //    return rez;
        //}

        //public IList<tblStreets> GetStreets()
        //{
        //   return _streetsRepository.GetAll().ToList();
        //}



        //public IList<tblNumbersHome> GetHouses(int streetId)
        //{
        //    var rez = _numberHomeRepository.GetAll()
        //        .Where(p => p.StreetId == streetId)
        //        .OrderBy(c => c.Number)
        //        .ToList();
        //    return rez;


        //}

        //public IList<tblNumbersHome> GetHouses()
        //{
        //    return _numberHomeRepository.GetAll().ToList();
        //}

        //public IList<tblRooms> GetRooms(int houseId)
        //{
        //    var rez = _roomsRepository.GetAll()
        //         .Where(p => p.HouseId == houseId)
        //         .OrderBy(c => c.NumberRoom)
        //         .ToList();
        //    return rez;
        //}

      

        //public IList<tblRooms> GetRooms()
        //{
        //    return _roomsRepository.GetAll().ToList();
        //}
    }
}
