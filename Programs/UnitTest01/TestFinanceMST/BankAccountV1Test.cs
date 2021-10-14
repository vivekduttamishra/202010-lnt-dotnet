using System;
using ConceptArchitect.Finance;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestFinanceMST
{
    [TestClass]
    public class BankAccountV1Test
    {

        [TestMethod]
        public void BalanceIsSetProperly()
        {
            var account = new BankAccountV1(1, "vivek", "pass", 1000, 12);
            Assert.AreEqual(1000, account.Balance);
        }

        [TestMethod]
        public void WithdrawShouldFailForInvalidAmount()
        {
            var account = new BankAccountV1(1, "vivek", "pass", 1000, 12);

            account.Withdraw(0, "pass");

            Assert.AreEqual(1000, account.Balance);
        }


        [TestMethod]
        public void WithdrawShouldBeSuccessfulForRightAmountAndPassword()
        {
            var account = new BankAccountV1(1, "vivek", "pass", 1000, 12);

            account.Withdraw(1, "pass");

            Assert.AreEqual(999, account.Balance);
        }
    }
}
