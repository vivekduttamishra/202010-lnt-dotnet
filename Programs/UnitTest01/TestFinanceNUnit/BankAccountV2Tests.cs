using ConceptArchitect.Finance.V2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinanceNUnit
{
    [TestFixture]
    public class BankAccountV2Tests
    {


        string name = "Vivek Dutta Mishra";
        string password = "password";
        double initialBalance = 20000;
        double rate = 12;
        BankAccount account;

        [SetUp]
        public void BeforeEach()
        {
            account = new BankAccount(1, name, password, initialBalance, rate);

        }
        [TearDown]
        public void AfterEach()
        {
            //write your cleanup logic
        }

        [Test]
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
        [Test]
        public void WithdrawFailsForInvalidPassword()
        {
            var result = account.Withdraw(1, "wrong-password");

            //Assert Logic here
            Assert.That(result, Is.False);                               //Assert.IsFalse(result);
            Assert.That(account.Balance, Is.EqualTo(initialBalance));   //Assert.AreEqual(initialBalance, account.Balance);


        }

        [Test]
        public void WithdrawFailsForOverDraw()
        {
            var result = account.Withdraw(initialBalance + 1, password);

            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }

        [Ignore("Not Yet Implemented")]
        [Test]
        public void WithdrawalFailsForInvalidAmount()
        {
            

            //Arrange
            //Act Logic here
            var result = account.Withdraw(-1, password);


            //Assert Logic here
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);
        }

        [Test]
        public void WeCanWithdrawMoneyAfterDepositTopup()
        {
            //Arrange
            int amount = 2000;
            account.Deposit(amount);
            Assume.That(account.Balance, Is.EqualTo(initialBalance + amount));

            //ACT
            account.Withdraw(initialBalance + amount, password);

            //ASSERT
            //Assert.AreEqual(0, account.Balance);

            Assert.That(account.Balance, Is.EqualTo(0));

        }


        [Test]
       public void WeCanWithdrawAllTheMoneyWeHaveWithRightCredentials()
        {
            account.Withdraw(initialBalance, password);

            //Assert.AreEqual(0, account.Balance);
            Assert.That(account.Balance, Is.EqualTo(0));
        }

        [Test(ExpectedResult = 0)]
        public double WeCanWithdrawEntireMoneyWithTheRightCredential()
        {
            account.Withdraw(initialBalance, password);

            return account.Balance; //actual value
        }



        //[Ignore]
        [Test]
        public void DepositHappyCase()
        {
            //Arrange
            //Act Logic here
            var result = account.Deposit(1);

            //Assert Logic here
            Assert.IsTrue(result);
            Assert.AreEqual(initialBalance + 1, account.Balance);

        }

        //[Ignore]
        [Test]
        public void DepositFailsForInvalidAmount()
        {
            //Arrange
            //Act Logic here
            var result = account.Deposit(-1);

            //Assert Logic here
            Assert.IsFalse(result);
            Assert.AreEqual(initialBalance, account.Balance);

        }







    }
}
