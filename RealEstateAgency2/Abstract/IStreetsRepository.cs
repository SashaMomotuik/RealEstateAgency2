using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
   public interface IStreetsRepository
    {
        Street Add(Street streets);

        void Remove(Street streets);
        IQueryable<Street> GetAll();

        int SaveChanges();

    }
}
