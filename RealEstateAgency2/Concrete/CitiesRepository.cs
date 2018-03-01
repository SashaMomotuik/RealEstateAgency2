using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class CitiesRepository : ICitiesRepository
    {

        private readonly EFContext _context;

        public CitiesRepository(EFContext context)
        {
            _context = context;
        }


        public City Add(City cities)
        {
            _context.Citises.Add(cities);
            return cities;
        }

        public IQueryable<City> GetAll()
        {
            return _context.Citises.AsQueryable();
        }

        public void Remove(City cities)
        {
            _context.Citises.Remove(cities);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
