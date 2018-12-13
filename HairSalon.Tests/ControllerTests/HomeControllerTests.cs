using HairSalon.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;
using System;

namespace HairSalon.Tests
{
    [TestClass]
    public class HomeControllerTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.ClearAll();
            Client.ClearAll();
        }

        public HomeControllerTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=charley_mcgowan_test;";
        }

        [TestMethod]
        public void Index_ReturnsAView_True()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ActionResult indexView = controller.Index();

            //Assert
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        //Arrange

        //Act

        //Assert
    }
}