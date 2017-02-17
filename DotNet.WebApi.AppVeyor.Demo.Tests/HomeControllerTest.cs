using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNet.WebApi.AppVeyor.Demo.Controllers;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Net;

namespace DotNet.WebApi.AppVeyor.Demo.Tests
{
    [TestClass]
    public class HomeControllerTest : BaseTest
    {       
        [TestMethod]
        public void Home_Should_Return_OK()
        {
            // Arrange
            HomeController controller = this.GenerateController<HomeController>();
            
            // Act
            var result = controller.Home();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.StatusCode, HttpStatusCode.BadRequest);
        }
    }
}
