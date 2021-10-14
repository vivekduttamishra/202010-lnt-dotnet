using ConceptArchitect.Finance.V2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinanceMST
{
    [TestClass]
    public class BankAccountV2Tests2
    {

        string name = "Vivek Dutta Mishra";
        string password = "password";
        double initialBalance = 20000;
        double rate = 12;
        BankAccount account;
        BankAccountAssertV2 accountAsssert;

        [TestInitialize]
        public void BeforeEach()
        {
             account= new BankAccount(1, name, password, initialBalance, rate);
             accountAsssert = new BankAccountAssertV2(account);
        }

        


        [TestMethod]
        public void CanWithdrawInHappyCase()
        {
            accountAsssert.TransactionSucceeds(account.Withdraw(1, password), -1); //1 Rs withdrawn
        }



        //[Ignore]  //don't run this yet
        [TestMethod]
        public void WithdrawFailsForInvalidPassword()
        {
            accountAsssert.TransactionFails(account.Withdraw(1, "wrong-password"));
        }

        [
      //   Ignore,
         TestMethod
        ]
        public void WithdrawFailsForOverDraw()
        {
            accountAsssert.TransactionFails(account.Withdraw(initialBalance + 1, password));
        }

       // [Ignore]
        [TestMethod]
        public void WithdrawalFailsForInvalidAmount()
        {
            accountAsssert.TransactionFails(account.Withdraw(-1, password));
        }


        //[Ignore]
        [TestMethod]
        public void DepositHappyCase()
        {
            accountAsssert.TransactionSucceeds(account.Deposit(1), 1);

        }

        //[Ignore]
        [TestMethod]
        public void DepositFailsForInvalidAmount()
        {
            accountAsssert.TransactionFails(account.Deposit(-1));

        }





    
    }
}
