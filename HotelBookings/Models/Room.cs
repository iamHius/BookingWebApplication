using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookings.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomNo { get; set; }
        [ForeignKey("RoomType")]
        public int RoomTypeId { get; set; }
        [ForeignKey("Capacity")]
        public int CapacityId { get; set; }
        [Required]
        [StringLength(200)]
        public string? RoomPhoto { get; set; }
        [Required]
        [Column(TypeName = "decimal(8,3)")]
        public decimal FeePerNight { get ; set; }   
        [Required]
        [StringLength(200)]
        public string? RoomDescription { get; set; }
        [Required]
        public bool? IsAvailable { get; set; } = true;

        public RoomType? RoomType { get; set; }
        public Capacity? Capacity { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

    }
}