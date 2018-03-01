using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{


    [Table("tblDistricts")]
    public  class District
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }

        [ForeignKey("City")]
        public int CitiesId { get; set; }
        public virtual City City { get; set; }
       

      public virtual ICollection<Street> Street { get; set; }



    }
}
