
using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Data;
using ParkingManagementSystemAPI.Services;
using ParkingManagementSystemAPI.Services.Repositories;

namespace ParkingManagementSystemAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("ParkingManagementConnection");

            builder.Services.AddDbContext<ParkingContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IParkingSlotRepository, ParkingSlotRepository>();
            builder.Services.AddScoped<IVehicleTypeRepository, VehicleTypeRepository>();
            builder.Services.AddScoped<IParkingAssignmentRepository, ParkingAssignmentRepository>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<SlotAssignmentService>();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
