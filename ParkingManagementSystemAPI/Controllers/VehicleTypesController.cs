using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystemAPI.Services.Repositories;
using ParkingManagementSystemAPI.Services;

namespace ParkingManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly IVehicleTypeRepository _vehicleTypeRepository;  // Assuming a VehicleTypeRepository is implemented
        private readonly IUnitOfWork _unitOfWork;

        public VehicleTypesController(IVehicleTypeRepository vehicleTypeRepository, IUnitOfWork unitOfWork)
        {
            _vehicleTypeRepository = vehicleTypeRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: Get all vehicle types
        [HttpGet]
        public async Task<IActionResult> GetVehicleTypes()
        {
            var vehicleTypes = await _vehicleTypeRepository.GetAllAsync();  // Assuming a GetAllAsync method in the repository
            return Ok(vehicleTypes);
        }
    }
}
