using RealEstateAgency2.Abstract;
using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Concrete
{
    public class StreetsRepository : IStreetsRepository
    {

        private readonly EFContext _context;

        public StreetsRepository(EFContext context)
        {
            _context = context;
        }



        public Street Add(Street streets)
        {
            _context.Streets.Add(streets);
            return streets;
        }

        public IQueryable<Street> GetAll()
        {
            return _context.Streets.AsQueryable();
        }

        public void Remove(Street streets)
        {
            _context.Streets.Remove(streets);

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
