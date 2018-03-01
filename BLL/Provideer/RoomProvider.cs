using BLL.Abstract;
using BLL.Model;
using RealEstateAgency2;
using RealEstateAgency2.Abstract;
using RealEstateAgency2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Entity;

namespace BLL.Provideer
{
    public class RoomProvider : IRoomProvider
    {

        //private readonly IRoomsRepository _roomsRepository;
        //private readonly IRoomImagesRepository _roomImagesRepository;

        //public RoomProvider()
        //{
        //    RealEstateAgencyEntities context = new RealEstateAgencyEntities();

        //    _roomsRepository = new RoomsRepository(context);
        //    _roomImagesRepository = new RoomImagesRepository(context);

            
        //  // var i = _roomsRepository.GetAll().ToList();
        //    //var list = _roomsRepository.GetAll()
        //    //    .Include(b => b.tblNumbersHomes)
        //    //    .Include(s => s.tblNumbersHomes.tblStreets)
        //    //    .Include(cr => cr.tblNumbersHomes.tblStreets.tblDistricts)
        //    //    .Include(c => c.tblNumbersHomes.tblStreets.tblDistricts.tblCities)
        //    //    .Select(r => new
        //    //    {
        //    //        RommNumber=r.NumberRoom,
        //    //        Street=r.tblNumbersHomes.tblStreets.Name
        //    //    });




        //}



        //public tblRooms AddRoom(RoomAddViewModel roomAddModel)
        //{
        //    tblRooms room;
        //    using (TransactionScope scope = new TransactionScope())
        //    {

        //        room = new tblRooms
        //        {
        //            HouseId = roomAddModel.NumberHouse,
        //            Floor = roomAddModel.Floor,
        //            CountRooms = roomAddModel.CountRoom,
        //            NumberRoom = roomAddModel.NumberRoom,
        //            Price = Convert.ToDecimal(roomAddModel.price),
        //            Square = Convert.ToDecimal(roomAddModel.Square),
        //            Reserved = roomAddModel.Reserved,
        //            Sales = roomAddModel.Sales

        //        };
        //        _roomsRepository.Add(room);
        //        _roomsRepository.SaveChanges();

        //        foreach (var item in roomAddModel.Images)
        //        {
        //            var p = ImageToDataBase.ToBinaryArray(item);

        //            tblRoomImages roomImages = new tblRoomImages
        //            {
        //                Name = Guid.NewGuid().ToString() + ".jpg",
        //                RoomId = room.Id,
        //                Photo = p

        //            };

        //            _roomImagesRepository.Add(roomImages);
        //        }
        //        _roomImagesRepository.SaveChanges();

        //        scope.Complete();
        //    }


        //    return room;
        //}

        //public IList<RoomShowViewModel> GetAllRooms()
        //{

        //    var tmp = _roomImagesRepository.GetAll();


        //    var list = _roomsRepository.GetAll()
        //        .Include(i => i.tblRoomImages)
        //           .Include(b => b.tblNumbersHome)
        //           .Include(s => s.tblNumbersHome.tblStreets)
        //           .Include(cr => cr.tblNumbersHome.tblStreets.tblDistricts)
        //           .Include(c => c.tblNumbersHome.tblStreets.tblDistricts.tblCities)
        //           .Select(x=>x).ToList()
        //           .Select(r => new RoomShowViewModel
        //           {
        //               //RoomCity = r.tblNumbersHome.tblStreets.tblDistricts.tblCities.Name,
        //               //RoomDistrict = r.tblNumbersHome.tblStreets.tblDistricts.Name,
        //               //RoomStreet = r.tblNumbersHome.tblStreets.Name,
        //               RoomNumberHouse = r.tblNumbersHome.Number,
        //               NumberRoom = r.NumberRoom,
        //               CountRoom = r.CountRooms,
        //               Floor = r.Floor,
        //               Square = r.Square,
        //               Price = r.Price,
        //               Reserved = r.Reserved,
        //               Sales = r.Sales,

        //               Photos = r.tblRoomImages.Select( x=>x.Photo).ToList()
                      

                     
        //           }).ToList();

        //    return list;


        //}
    }
}
