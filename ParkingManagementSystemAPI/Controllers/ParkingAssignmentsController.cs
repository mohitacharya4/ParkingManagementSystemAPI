using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingManagementSystemAPI.Services.Repositories;
using ParkingManagementSystemAPI.Services;

namespace ParkingManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingAssignmentsController : ControllerBase
    {
        private readonly IParkingAssignmentRepository _parkingAssignmentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ParkingAssignmentsController(IParkingAssignmentRepository parkingAssignmentRepository, IUnitOfWork unitOfWork)
        {
            _parkingAssignmentRepository = parkingAssignmentRepository;
            _unitOfWork = unitOfWork;
        }

        // GET: Get all parking assignments
        [HttpGet]
        public async Task<IActionResult> GetParkingAssignments()
        {
            var assignments = await _parkingAssignmentRepository.GetAllAsync();  // Assuming a GetAllAsync method in the repository
            return Ok(assignments);
        }
    }
}
