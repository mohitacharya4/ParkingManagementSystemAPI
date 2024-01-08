using System.ComponentModel.DataAnnotations;
using ParkingManagementSystemAPI.Enums;

namespace ParkingManagementSystemAPI.Models
{
    public class ParkingSlot
    {
        [Key]
        public int SlotNumber { get; set; }

        [Required]
        public SlotType SlotType { get; set; }

        public bool IsAvailable { get; set; }

        public virtual ICollection<ParkingAssignment> ParkingAssignments { get; set; }
    }
}
