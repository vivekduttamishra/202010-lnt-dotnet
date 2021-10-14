using ConceptArchitect.Finance;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinanceMST
{
    class BankAccountAssert
    {
        BankAccount account;
        double initialBalance;
        public BankAccountAssert(BankAccount account)
        {
            this.account = account;
            this.initialBalance = account.Balance;
        }

        public void TransactionFails( bool result)
        {
            Assert.IsFalse(result);
            BalanceUnchanged();
        }

        public void TransactionSucceeds(bool result, double changeInBalance)
        {
            Assert.IsTrue(result);
            Balance(initialBalance + changeInBalance);
        }

        public void BalanceUnchanged()
        {
            Balance(initialBalance);
        }

        public void Balance(double balance)
        {
            Assert.AreEqual(balance, account.Balance);
        }
    }
}
