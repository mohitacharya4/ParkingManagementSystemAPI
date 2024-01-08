using ParkingManagementSystemAPI.Enums;

namespace ParkingManagementSystemAPI.Models.Dto
{
    public class AllParkingSlotsResponseDto
    {
        public int SlotNumber { get; set; }
        public SlotType SlotType { get; set; }

        public bool IsAvailable { get; set; }
    }
}
