using CRUD_API.Controllers;
using CRUD_API.Interfaces;
using CRUD_API.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace CRUD_API.Tests
{
    public class ResidentsControllerTests
    {
        private readonly ResidentsController _residentController;
        private readonly Mock<IResidentStorage> _mockResidentStorage;
        public ResidentsControllerTests()
        {
            _mockResidentStorage = new Mock<IResidentStorage>();
            _residentController = new ResidentsController(_mockResidentStorage.Object);
        }


        [Fact]
        public void GetByIdResult200()
        {
           
            var result = _residentController.GetById("qyfgqiyhwfoq1") as OkObjectResult;

            Assert.Equal(200, result.StatusCode);
        }
    }
}
