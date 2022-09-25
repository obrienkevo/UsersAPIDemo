using System;
using Xunit;
using UsersAPIDemo.Controllers;
using UsersAPIDemo.Models;
using UsersAPIDemo.Repository;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UsersAPIDemo.Tests
{
    public class UsersControllerTests
    {
        [Fact]
        public void Should_Return_User()
        {
            // Arrange
            // test with different implementations of Interface - Constructor Dependency Injection**
            var userAPIRepo = new MockUserAPIRepo2();

            UsersController users = new UsersController(userAPIRepo);

            // Act
            var result = users.GetSingleUser(5);
            //var result = users.GetAllUsers();

            // Assert
            Assert.IsType<ActionResult<IEnumerable<User>>>(result.Result);

            //var result = users.GetSingleUser();
            //Assert.Equal("KOB1zz23", result.Value.ToString());
           // Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
