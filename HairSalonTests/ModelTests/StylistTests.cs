using System;
using System.Collections.Generic;
using System.Text;
using HairSalon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests
    {

        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=charley_mcgowan_test;";
        }

        [TestMethod]
        public void StylistConstructor_CreatesInstanceOfStylist_StylistObject()
        {
            //Arrange, Act
            Stylist testStylist = new Stylist("Cheryl");

            //Assert
            Assert.AreEqual(typeof(Stylist), testStylist.GetType());
        }

        //Arrange

        //Act

        //Assert
    }
}

