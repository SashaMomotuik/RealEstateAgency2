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
using RealEstateAgency2.Entities;

namespace BLL.Provideer
{
    public class RoomProvider : IRoomProvider
    {

        private readonly IRoomsRepository _roomsRepository;
        private readonly IRoomImagesRepository _roomImagesRepository;

        public RoomProvider()
        {
            EFContext context = new EFContext();

            _roomsRepository = new RoomsRepository(context);
            _roomImagesRepository = new RoomImagesRepository(context);


            // var i = _roomsRepository.GetAll().ToList();
            //var list = _roomsRepository.GetAll()
            //    .Include(b => b.tblNumbersHomes)
            //    .Include(s => s.tblNumbersHomes.tblStreets)
            //    .Include(cr => cr.tblNumbersHomes.tblStreets.tblDistricts)
            //    .Include(c => c.tblNumbersHomes.tblStreets.tblDistricts.tblCities)
            //    .Select(r => new
            //    {
            //        RommNumber=r.NumberRoom,
            //        Street=r.tblNumbersHomes.tblStreets.Name
            //    });




        }



        public Room AddRoom(RoomAddViewModel roomAddModel)
        {
            Room room;
            using (TransactionScope scope = new TransactionScope())
            {

                room = new Room
                {
                    HouseId = roomAddModel.NumberHouse,
                    Floor = roomAddModel.Floor,
                    CountRooms = roomAddModel.CountRoom,
                    NumberRoom = roomAddModel.NumberRoom,
                    Price = Convert.ToDecimal(roomAddModel.price),
                    Square = Convert.ToDecimal(roomAddModel.Square),
                    Reserved = roomAddModel.Reserved,
                    Sales = roomAddModel.Sales

                };
                _roomsRepository.Add(room);
                _roomsRepository.SaveChanges();

                foreach (var item in roomAddModel.Images)
                {
                    var p = ImageToDataBase.ToBinaryArray(item);

                    RoomImage roomImages = new RoomImage
                    {
                        Name = Guid.NewGuid().ToString() + ".jpg",
                        RoomId = room.Id,
                        Photo = p

                    };

                    _roomImagesRepository.Add(roomImages);
                }
                _roomImagesRepository.SaveChanges();

                scope.Complete();
            }


            return room;
        }

        public IList<RoomShowViewModel> GetAllRooms()
        {

            var tmp = _roomImagesRepository.GetAll();


            var list = _roomsRepository.GetAll()
                .Include(i => i.RoomImage)
                   .Include(b => b.NumberHouse)
                   .Include(s => s.NumberHouse.Street)
                   .Include(cr => cr.NumberHouse.Street.District)
                   .Include(c => c.NumberHouse.Street.District.City)
                 //  .Select(x => x).ToList()
                   .Select(r => new RoomShowViewModel
                   {
                       RoomCity = r.NumberHouse.Street.District.City.Name,
                       RoomDistrict = r.NumberHouse.Street.District.Name,
                       RoomStreet = r.NumberHouse.Street.Name,
                       RoomNumberHouse = r.NumberHouse.Number,
                       NumberRoom = r.NumberRoom,
                       CountRoom = r.CountRooms,
                       Floor = r.Floor,
                       Square = r.Square,
                       Price = r.Price,
                       Reserved = r.Reserved,
                       Sales = r.Sales,

                       Photos = r.RoomImage.Select(x => x.Photo).ToList()



                   }).ToList();

            return list;


        }
    }
}
