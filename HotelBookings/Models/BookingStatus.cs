using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookings.Models
{
    public class BookingStatus
    {
        [Key]
        public int BookingStatusId { get; set; }
        [Required]
        [StringLength(200)]
        public string? BookingStatusName { get; set; }
    }
}
