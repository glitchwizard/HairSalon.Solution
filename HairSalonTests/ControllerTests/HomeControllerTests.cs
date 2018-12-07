using HairSalon.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HairSalon.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        public void Dispose()
        {
            Stylist.ClearAll();
            Client.ClearAll();
        }

        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=charley_mcgowan_test;";
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