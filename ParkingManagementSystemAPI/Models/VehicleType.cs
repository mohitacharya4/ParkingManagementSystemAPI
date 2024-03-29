﻿using System.ComponentModel.DataAnnotations;
using ParkingManagementSystemAPI.Enums;

namespace ParkingManagementSystemAPI.Models
{
    public class VehicleType
    {
        [Key]
        public string VehicleTypeName { get; set; }

        public List<SlotType> CompatibleSlotTypes { get; set; }

        public virtual ICollection<ParkingAssignment> ParkingAssignments { get; set; }
    }
}
