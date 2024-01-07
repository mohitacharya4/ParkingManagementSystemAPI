using Microsoft.EntityFrameworkCore;
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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Coupon>().HasData(new Coupon
        //    {
        //        CouponId = 1,
        //        CouponCode = "10OFF",
        //        DiscountAmount = 10,
        //        MinAmount = 20,
        //    });

        //    modelBuilder.Entity<Coupon>().HasData(new Coupon
        //    {
        //        CouponId = 2,
        //        CouponCode = "20OFF",
        //        DiscountAmount = 20,
        //        MinAmount = 40,
        //    });


        //}
    }
}
