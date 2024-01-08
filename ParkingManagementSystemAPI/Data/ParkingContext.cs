using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Models;
using System;

namespace ParkingManagementSystemAPI.Data
{
    public class ParkingContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<ParkingSlot> ParkingSlots { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<ParkingAssignment> ParkingAssignments { get; set; }

        public ParkingContext(IConfiguration configuration, DbContextOptions<ParkingContext> options) : base(options)
        {
            this._configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed parking slots
            int[] smallSlotNumbers = Enumerable.Range(1, 50).ToArray();
            int[] mediumSlotNumbers = Enumerable.Range(51, 30).ToArray();
            int[] largeSlotNumbers = Enumerable.Range(81, 20).ToArray();

            var slots = new List<ParkingSlot>();
            foreach (var slotNumber in smallSlotNumbers)
            {
                slots.Add(new ParkingSlot { SlotNumber = slotNumber, SlotType = SlotType.Small, IsAvailable = true });
            }
            foreach (var slotNumber in mediumSlotNumbers)
            {
                slots.Add(new ParkingSlot { SlotNumber = slotNumber, SlotType = SlotType.Medium, IsAvailable = true });
            }
            foreach (var slotNumber in largeSlotNumbers)
            {
                slots.Add(new ParkingSlot { SlotNumber = slotNumber, SlotType = SlotType.Large, IsAvailable = true });
            }

            modelBuilder.Entity<ParkingSlot>().HasData(slots);

            // Seed vehicle types
            var vehicleTypes = new List<VehicleType>();
            vehicleTypes.Add(new VehicleType { VehicleTypeName = "Hatchback", CompatibleSlotTypes = new List<SlotType>() { SlotType.Small, SlotType.Medium, SlotType.Large } });
            vehicleTypes.Add(new VehicleType { VehicleTypeName = "Sedan/Compact SUV", CompatibleSlotTypes = new List<SlotType>() { SlotType.Medium, SlotType.Large } });
            vehicleTypes.Add(new VehicleType { VehicleTypeName = "SUV or Large cars", CompatibleSlotTypes = new List<SlotType>() { SlotType.Large } });

            modelBuilder.Entity<VehicleType>().HasData(vehicleTypes);

        }
    }
}
