using HotelBookings.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookings.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        [Required]
        public DateTime? CheckInDate { get; set; }
        [Required]
        public DateTime? CheckOutDate { get;set; }
        [Required]
        public DateTime? BookingDate { get; set; }
        [ForeignKey("BookingStatus")]
        public int StatusId { get; set; }

        public ApplicationUser? User { get; set; }
        public Room? Room { get; set; }
        public BookingStatus? Status { get; set; }

    }
}
