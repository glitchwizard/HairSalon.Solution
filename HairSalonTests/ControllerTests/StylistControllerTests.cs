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

        [TestMethod]
        public void Index_HasCorrectModelType_StylistList()
        {
            //Arrange
            ViewResult indexView = new StylistsController().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Stylist>)); //apparently the test order is important here. If you have result listed 2nd it won't work.

        }

        [TestMethod]
        public void New_ReturnsAView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult newView = controller.New();

            //Assert
            Assert.IsInstanceOfType(newView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_ReturnsAView_True()
        {

            //Arrange
            string stylistName = "Benedict";
            StylistsController controller = new StylistsController();

            //Act
            ActionResult createView = controller.Create(stylistName);

            //Assert
            Assert.IsInstanceOfType(createView, typeof(ViewResult));

        }

        [TestMethod]
        public void Show_ReturnsAView_True()
        {
            //Arrange
            StylistsController controller = new StylistsController();

            //Act
            ActionResult createView = controller.Show(1);

            //Assert
            Assert.IsInstanceOfType(createView, typeof(ViewResult));

        }



        //Arrange

        //Act

        //Assert
    }

}


