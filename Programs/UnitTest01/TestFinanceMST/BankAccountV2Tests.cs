using ConceptArchitect.Finance.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shouldly;
using System.Threading.Tasks;

namespace TestFinanceMST
{
    [TestClass]
    public class BankAccountV2Tests
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
        public void CanWithdrawInHappyCase()
        {
            //Arrange           

            //Act Logic here
            var result = account.Withdraw(1, password);

            //Assert Logic here
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance - 1, account.Balance);
        }



      


        //[Ignore]  //don't run this yet
        [TestMethod]
        public void WithdrawFailsForInvalidPassword()
        {
            var result = account.Withdraw(1, "wrong-password");

            //Assert Logic here
            Assert.IsFalse(result);
           // Assert.AreEqual(100, account.Balance);


            account.Balance.ShouldBe(100);

            
        }

        [
      //   Ignore,
         TestMethod
        ]
        public void WithdrawFailsForOverDraw()
        {
            var result = account.Withdraw(initialBalance + 1, password);

            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }

       // [Ignore]
        [TestMethod]
        public void WithdrawalFailsForInvalidAmount()
        {

            //Arrange
            //Act Logic here
            var result = account.Withdraw(-1, password);


            //Assert Logic here
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }


        //[Ignore]
        [TestMethod]
        public void DepositHappyCase()
        {
            //Arrange
            //Act Logic here
           var result= account.Deposit(1);

            //Assert Logic here
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance + 1, account.Balance);

        }

        //[Ignore]
        [TestMethod]
        public void DepositFailsForInvalidAmount()
        {
            //Arrange
            //Act Logic here
            var result=account.Deposit(-1);

            //Assert Logic here
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance , account.Balance);

        }




        //[TestMethod]   //Tests all paths of Withdraw which is not a good Test design
        public void WithdrawFailureTests()
        {
            Assert.IsFalse(account.Withdraw(1, "WrongPassword"));

            Assert.IsFalse(account.Withdraw(-1, password));

            Assert.IsFalse(account.Withdraw(initialBalance + 1, password));
        }



    
    }
}
