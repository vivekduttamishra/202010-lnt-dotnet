using ConceptArchitect.Finance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinanceMST
{
    [TestClass]
    class BankAccountTests
    {

        string name = "Vivek Dutta Mishra";
        string password = "password";
        double initialBalance = 20000;
        double rate = 12;
        BankAccount account;

        [TestInitialize]
        public void BeforeEach()
        {
             account= new BankAccount(1, name, password, initialBalance, rate);
        }

        [TestCleanup]
        public void AfterEach()
        {
            //write your cleanup logic
        }


        [TestMethod]
        public void canWithdrawInHappyCase()
        {
            //Arrange
           

            //Act Logic here


            //Assert Logic here
        }

        [TestMethod]
        public void withdrawalFailsForInvalidAmount()
        {

            //Arrange
            string name = "Vivek Dutta Mishra";
            string password = "password";
            double initialBalance = 20000;
            double rate = 12;
            var account = new BankAccount(1, "Vivek Dutta Mishra", password, initialBalance, rate);


            //Act Logic here


            //Assert Logic here

        }


        [TestMethod]
        public void depositHappyCase()
        {

            //Arrange
            string name = "Vivek Dutta Mishra";
            string password = "password";
            double initialBalance = 20000;
            double rate = 12;
            var account = new BankAccount(1, "Vivek Dutta Mishra", password, initialBalance, rate);


            //Act Logic here


            //Assert Logic here

        }
    }
}
