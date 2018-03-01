using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    [Table("tblCities")]
    public  class City
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }


        public virtual ICollection<District> Districti { get; set; }

    }
}
