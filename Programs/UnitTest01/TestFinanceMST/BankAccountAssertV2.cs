using ConceptArchitect.Finance.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinanceMST
{
    class BankAccountAssertV2
    {
        BankAccount account;
        double initialBalance;
        public BankAccountAssertV2(BankAccount account)
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
