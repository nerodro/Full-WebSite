using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test_Resiter.Controllers;
using Test_Resiter.Models;
using Xunit;

namespace Test_Resiter.Tests
{
    public class AdminControllerTests 
    {

        [Fact]
        public void TestAddUser()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.AddUser()).Returns(AddUsers());
            var controller = new AdminController(mock.Object);

            var result = controller.AddModer();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<User>>(viewResult.Model);
            Assert.Equal(AddUsers().Count, model.Count());
        }
        private List<User> AddUsers()
        {
            var users = new List<User>
            {
                new User{Id = 5, Email="Kirill", Password= "1488"}
            };
            return users;
        }
    }
}
