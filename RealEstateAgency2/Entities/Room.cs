using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgency2.Entities
{
    [Table("tblRooms")]
    public  class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public int CountRooms { get; set; }
        [Required]
        public decimal Square { get; set; }
        [Required]
        public bool Reserved { get; set; }
        [Required]
        public bool Sales { get; set; }
        [Required]
        public int NumberRoom { get; set; }

        [ForeignKey("NumberHouse")]
        public int HouseId { get; set; }
        public virtual NumberHouse NumberHouse { get; set; }

        public virtual ICollection <RoomImage> RoomImage { get; set; }



    }
}
