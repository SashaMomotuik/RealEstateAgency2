using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    [Table("tblStreets")]
    public class Street
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }

        [ForeignKey("District")]
        public int DistrictsId { get; set; }
        public virtual District District { get; set; }

        public virtual ICollection<NumberHouse>  NumberHouse { get; set; }    

    }
}
