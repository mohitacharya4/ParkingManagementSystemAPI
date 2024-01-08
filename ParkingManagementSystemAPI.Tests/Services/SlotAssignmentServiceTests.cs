using ParkingManagementSystemAPI.Enums;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.Services.SlotCompatibilityStrategies.Interfaces;
using ParkingManagementSystemAPI.Services;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;
using Moq;

namespace ParkingManagementSystemAPI.Tests.Services
{
    [TestFixture]
    public class SlotAssignmentServiceTests
    {
        private Mock<IParkingSlotRepository> _mockParkingSlotRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private Mock<IVehicleTypeRepository> _mockVehicleTypeRepository;
        private Mock<ISlotCompatibilityStrategy> _mockStrategy;

        private SlotAssignmentService _service;

        [SetUp]
        public void SetUp()
        {
            _mockParkingSlotRepository = new Mock<IParkingSlotRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockVehicleTypeRepository = new Mock<IVehicleTypeRepository>();
            _mockStrategy = new Mock<ISlotCompatibilityStrategy>();

            _service = new SlotAssignmentService(
                _mockParkingSlotRepository.Object,
                _mockUnitOfWork.Object,
                _mockVehicleTypeRepository.Object
            );
        }

        [Test]
        public async Task AssignSlot_ValidVehicleType_ReturnsMatchingSlotNumber()
        {
            const string vehicleType = "Hatchback";
            var availableSlots = new List<ParkingSlot>
            {
                new ParkingSlot { SlotNumber = 1, SlotType = SlotType.Small },
                new ParkingSlot { SlotNumber = 2, SlotType = SlotType.Large },
            };
            _mockStrategy.Setup(s => s.GetCompatibleSlotTypes()).Returns(new List<SlotType> { SlotType.Small });
            _mockParkingSlotRepository.Setup(r => r.UpdateSlot(It.IsAny<ParkingSlot>())).ReturnsAsync((ParkingSlot s) => s);

            var assignedSlotNumber = await _service.AssignSlot(vehicleType, availableSlots);

            Assert.Equals(1, assignedSlotNumber);
            _mockParkingSlotRepository.Verify(r => r.UpdateSlot(It.Is<ParkingSlot>(s => s.SlotNumber == 1)), Times.Once);
            _mockUnitOfWork.Verify(u => u.CompleteAsync(), Times.Once);
        }
    }
}
