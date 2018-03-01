using RealEstateAgency2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Abstract
{
   public  interface IDistrictsRepository
    {

        District Add(District districts);

        void Remove(District districts);
        IQueryable<District> GetAll(); // отримати райони по ід міста?


        int SaveChanges();

    }
}
