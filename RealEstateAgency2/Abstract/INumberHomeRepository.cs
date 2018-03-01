using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
    public interface INumberHomeRepository
    {
        NumberHouse Add(NumberHouse house);

        void Remove(NumberHouse house);
        IQueryable<NumberHouse> GetAll();

        int SaveChanges();
    }
}
