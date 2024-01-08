using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystemAPI.Models.Dto;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;

namespace ParkingManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly IVehicleTypeRepository _vehicleTypeRepository;
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
            var vehicleTypes = await _vehicleTypeRepository.GetAllAsync();

            var vehicleTypesResponse = vehicleTypes.Select(vehicleType => new VehicleTypeResponseDto
            {
                VehicleTypeName = vehicleType.VehicleTypeName
            }).ToList();

            return Ok(vehicleTypesResponse);
        }
    }
}
