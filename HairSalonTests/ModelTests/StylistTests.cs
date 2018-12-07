using System;
using System.Collections.Generic;
using System.Text;
using HairSalon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.ClearAll();
        }

        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=charley_mcgowan_test;";
        }

        [TestMethod]
        public void StylistConstructor_CreatesInstanceOfStylist_StylistObject()
        {
            //Arrange, Act
            Stylist testStylist = new Stylist("Cheryl");

            //Assert
            Assert.AreEqual(typeof(Stylist), testStylist.GetType());

        }

        [TestMethod]
        public void Equals_ReturnsTrueIfNamesAreTheSame_True()
        {
            //Arrange, Act
            Stylist firstStylist = new Stylist("Alex");
            Stylist secondStylist = new Stylist("Alex");

            //Assert
            Assert.AreEqual(firstStylist, secondStylist);

        }

        [TestMethod]
        public void Save_SavesToDatabase_StylistList()
        {
            //Arrange
            Stylist testStylist = new Stylist("Sean");

            //Act
            testStylist.Save();
            List<Stylist> result = Stylist.GetAll();
            List<Stylist> testList = new List<Stylist>{testStylist};

            Console.WriteLine("result[0].Name :" + result[0].Name);
            Console.WriteLine("testList[0].Name :" + testList[0].Name);
            Console.WriteLine("result.Count :" + result.Count);
            Console.WriteLine("testList.Count :" + testList.Count);

            //Assert
            CollectionAssert.AreEqual(testList, result);

        }

        [TestMethod]
        public void Save_AssignsIdToObject_Id()
        {
            //Arrange
            Stylist testStylist = new Stylist("Becky");

            //Act
            testStylist.Save();
            Stylist savedStylist = Stylist.GetAll()[0];

            int result = savedStylist.id;
            int testId = testStylist.id;

            //Assert
            Assert.AreEqual(testId, result);
        }

        //Arrange

        //Act

        //Assert
    }
}

