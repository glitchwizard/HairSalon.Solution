using HairSalon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HairSalon.Tests
{
    [TestClass]
    public class StylistTests : IDisposable
    {
        public void Dispose()
        {
            Stylist.ClearAll();
            Client.ClearAll();
        }

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
            List<Stylist> testList = new List<Stylist> { testStylist };

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

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_StylistList()
        {
            //Arrange
            List<Stylist> newList = new List<Stylist> { };

            //Act
            List<Stylist> resultList = Stylist.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, resultList);
        }

        [TestMethod]
        public void GetAll_ReturnsAListOfStylists_StylistList()
        {
            //Arrange
            string name1 = "Marsha";
            string name2 = "Joshua";
            Stylist newStylist1 = new Stylist(name1);
            newStylist1.Save();
            Stylist newStylist2 = new Stylist(name2);
            newStylist2.Save();
            List<Stylist> testList = new List<Stylist> { newStylist1, newStylist2 };

            //Act
            List<Stylist> resultList = Stylist.GetAll();

            //Assert
            CollectionAssert.AreEqual(testList, resultList);
        }

        [TestMethod]
        public void Find_ReturnsCorrectItemFromDatabase_Item()
        {
            //Arrange
            Stylist testStylist = new Stylist("Timothy");
            testStylist.Save();

            //Act
            Stylist result = Stylist.Find(testStylist.id);

            //Assert
            Assert.AreEqual(testStylist, result);
        }

        [TestMethod]
        public void GetClients_ReturnsAList_True()
        {
            //Arrange
            Stylist testStylist = new Stylist("Martha");
            testStylist.Save();
            List<Client> testClientList = testStylist.GetClients();

            //Act
            List<Client> result = new List<Client> { };

            //Assert
            CollectionAssert.AreEqual(testClientList, result);
        }

        //Arrange

        //Act

        //Assert
    }
}