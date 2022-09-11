using System;
using Xunit;
using UsersAPIDemo.Controllers;

namespace UsersAPIDemo.Tests
{
    public class UsersControllerTests
    {
        [Fact]
        public void Should_Return_User()
        {
            UsersController users = new UsersController();
            var result = users.GetSingleUser();
            Assert.Equal("KOB1zz23", result.Value.ToString());
           // Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
