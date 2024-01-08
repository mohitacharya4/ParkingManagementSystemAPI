using Microsoft.AspNetCore.Mvc;
using Moq;
using ParkingManagementSystemAPI.Controllers;
using ParkingManagementSystemAPI.Models.Dto;
using ParkingManagementSystemAPI.Models;
using ParkingManagementSystemAPI.Repositories.Interfaces;
using ParkingManagementSystemAPI.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystemAPI.Tests.Controllers
{
    [TestFixture]
    public class VehicleTypeControllerTests
    {
        [Test]
        public async Task GetVehicleTypes_Success_ReturnsListOfVehicleTypes()
        {
            // Arrange
            var mockRepository = new Mock<IVehicleTypeRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            var vehicleTypes = new List<VehicleType>
            {
                new VehicleType { VehicleTypeName = "Hatchback" },
                new VehicleType { VehicleTypeName = "Sedan/Compact SUV" }
            };
            mockRepository.Setup(r => r.GetAllAsync()).ReturnsAsync(vehicleTypes);

            var controller = new VehicleTypesController(mockRepository.Object, mockUnitOfWork.Object);

            // Act
            var result = await controller.GetVehicleTypes();

            // Assert
            var response = (OkObjectResult)result;
            var vehicleTypesResponse = (List<VehicleTypeResponseDto>)response.Value;
            Assert.Equals(2, vehicleTypesResponse.Count);
            Assert.Equals("Hatchback", vehicleTypesResponse[0].VehicleTypeName);
            Assert.Equals("Sedan/Compact SUV", vehicleTypesResponse[1].VehicleTypeName);
        }
    }
}
