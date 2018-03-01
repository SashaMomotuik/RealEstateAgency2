using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class NumberHomeRepository : INumberHomeRepository
    {

        private readonly EFContext _context;

        public NumberHomeRepository(EFContext context)
        {
            _context = context;
        }


        public NumberHouse Add(NumberHouse house)
        {
            _context.NumberHouses.Add(house);
            return house;
        }

        public IQueryable<NumberHouse> GetAll()
        {
            return _context.NumberHouses.AsQueryable();
        }

        public void Remove(NumberHouse house)
        {
            _context.NumberHouses.Add(house);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
