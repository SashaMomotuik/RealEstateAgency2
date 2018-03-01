using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    [Table("tblRoomImages")]
    public   class RoomImage
    {
        [Key]
        public int Id { get; set; }

        public byte[] Photo { get; set; }

        [Required, StringLength(maximumLength: 250)]
        public string Name { get; set; }
     

        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }


    }
}
