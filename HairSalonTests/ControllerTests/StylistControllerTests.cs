using System;
using System.Collections.Generic;
using System.Text;
using HairSalon.Models;
using HairSalon.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistControllerTests
    {
        [TestMethod]
        public void Index_ReturnsAView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

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


