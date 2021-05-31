using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Test_Resiter.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Test_Resiter.Models;
using System.Linq;

namespace Test_Resiter.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexSendForm()
        {
            var mock = new Mock<ISend>();
            mock.Setup(repo => repo.sends()).Returns(TestSend());
            var controller = new HomeController(mock.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<SendForm>>(viewResult.Model);
            Assert.Equal(TestSend().Count, model.Count());
        }
        private List<SendForm> TestSend()
        {
            var send = new List<SendForm>
            {
                new SendForm {Id = 20, Email = "hZZZ@gmail.com", Name="Yana", Comment = "Не робит", PhoneNumber="88005553535", Text="Я ничего не нажимала, оно само" }
            };
            return send;
        }
    }
}
