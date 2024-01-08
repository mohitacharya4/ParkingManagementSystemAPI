using System.ComponentModel.DataAnnotations;

namespace ParkingManagementSystemAPI.Models.Dto
{
    public class AssignParkingSlotRequestDto
    {
        [Required]
        public string VehicleType { get; set; }

        [Required]
        public string VehicleRegistrationNumber { get; set; }
    }
}
