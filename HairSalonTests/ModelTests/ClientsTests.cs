using System;
using System.Collections.Generic;
using System.Text;
using HairSalon.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HairSalon.Tests
{
    [TestClass]
    public class ClientsTests : IDisposable
    {
        public void Dispose()
        {
            Client.ClearAll();
        }

        public ClientsTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=charley_mcgowan_test;";
        }

        [TestMethod]
        public void ClientConstructor_CreatesInstanceOfClient_ClientObject()
        {
            //Arrange, Act
            Client testClient = new Client("Cheryl", 1);

            //Assert
            Assert.AreEqual(typeof(Client), testClient.GetType());

        }

        [TestMethod]
        public void Equals_ReturnsTrueIfNamesAreTheSame_True()
        {
            //Arrange, Act
            Client firstClient = new Client("Alex", 1);
            Client secondClient = new Client("Alex", 1);

            //Assert
            Assert.AreEqual(firstClient, secondClient);

        }

        [TestMethod]
        public void Save_SavesToDatabase_ClientList()
        {
            //Arrange
            Client testClient = new Client("Sean", 1);

            //Act
            testClient.Save();
            List<Client> result = Client.GetAll();
            List<Client> testList = new List<Client>{testClient};

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
            Client testClient = new Client("Becky", 1);

            //Act
            testClient.Save();
            Client savedClient = Client.GetAll()[0];

            int result = savedClient.id;
            int testId = testClient.id;

            //Assert
            Assert.AreEqual(testId, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyListFromDatabase_ClientList()
        {
            //Arrange
            List<Client> newList = new List<Client> { };

            //Act
            List<Client> resultList = Client.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, resultList);
        }

        [TestMethod]
        public void GetAll_ReturnsAListOfClients_ClientList()
        {
            //Arrange
            string name1 = "Marsha";
            string name2 = "Joshua";
            Client newClient1 = new Client(name1, 1);
            newClient1.Save();
            Client newClient2 = new Client(name2, 1);
            newClient2.Save();
            List<Client> testList = new List<Client> { newClient1, newClient2 };

            //Act
            List<Client> resultList = Client.GetAll();

            //Assert            
            CollectionAssert.AreEqual(testList, resultList);
        }

        [TestMethod]
        public void Find_ReturnsCorrectItemFromDatabase_Item()
        {
            //Arrange
            Client testClient = new Client("Timothy", 1);
            testClient.Save();

            //Act
            Client result = Client.Find(testClient.id);

            //Assert
            Assert.AreEqual(testClient, result);
        }

        //Arrange

        //Act

        //Assert
    }
}

