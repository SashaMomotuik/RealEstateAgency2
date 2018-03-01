using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
    public interface ICitiesRepository
    {
        City Add(City cities);

        void Remove(City cities);
        IQueryable<City> GetAll();

        int SaveChanges();

    }
}
