using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class DistrictsRepository : IDistrictsRepository
    {

        private readonly EFContext _context;

        public DistrictsRepository(EFContext context)
        {
            _context = context;
        }




        public District Add(District districts)
        {
            _context.Districts.Add(districts);
            return districts;
        }

        public IQueryable<District> GetAll()
        {
            return _context.Districts.AsQueryable();
        }

        public void Remove(District districts)
        {
            _context.Districts.Remove(districts);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
