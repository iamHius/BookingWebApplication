using System.ComponentModel.DataAnnotations;

namespace HotelBookings.Models
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomTypeName { get; set; }
        [Required]
        public int RoomTypeOrder { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomTypePhoto { get; set; }
    }
}
