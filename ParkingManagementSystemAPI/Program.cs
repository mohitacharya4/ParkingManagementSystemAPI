
using Microsoft.EntityFrameworkCore;
using ParkingManagementSystemAPI.Data;
using ParkingManagementSystemAPI.Repositories;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.Services;
using ParkingManagementSystemAPI.Services.Interfaces;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;
using UnitOfWork = ParkingManagementSystemAPI.UnitOfWork;


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
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
            builder.Services.AddScoped<ISlotAssignmentService,SlotAssignmentService>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200");
                });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
