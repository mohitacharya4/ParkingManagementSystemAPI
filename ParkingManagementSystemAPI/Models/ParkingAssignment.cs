using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystemAPI.Models
{
    public class ParkingAssignment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SlotId { get; set; }
        public ParkingSlot Slot { get; set; }

        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string VehicleRegistrationNumber { get; set; }

        [Required]
        public DateTime EntryTime { get; set; }

        public DateTime? ExitTime { get; set; }

    }
}
