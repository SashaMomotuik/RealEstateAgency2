using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    [Table("tblNumbersHouses")]
    public class NumberHouse
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }

        [ForeignKey("Street")]
        public int StreetId { get; set; }
        public virtual  Street Street { get; set; }

        public virtual ICollection<Room> Room { get; set; }




    }
}
