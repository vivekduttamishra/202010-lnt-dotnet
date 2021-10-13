using ConceptArchitect.Finance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp01
{


    class Program
    {

        static void WithdrawTest(string testName,BankAccount account, double amount, string password, bool expectedResult)
        {
            bool actualResult = account.Withdraw(amount, password);
            if (actualResult == expectedResult)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED\t" + testName);
            }
                
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAILED\t" + testName);
                Console.WriteLine("\tExpected {0}\tFound {0}", expectedResult, actualResult);
            }

            Console.ResetColor();
                
        }


        static void WithdrawTest(string testName, BankAccount account, double amount, string password, double expectedBalance)
        {
            account.Withdraw(amount, password);
            
            var actualBalance = account.Balance;

            if (expectedBalance == actualBalance) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PASSED\t" + testName);
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FAILED\t" + testName);
                Console.WriteLine("\tExpected {0}\tFound {1}", expectedBalance, actualBalance);
            }

            Console.ResetColor();

        }

        static void Main(string[] args)
        {
            string password = "p@ss";
            double amount = 50000;
            var account = new BankAccount(1, "Vivek", password, amount, 12);

            WithdrawTest("Can't withdraw Invalid Amount", account, -1, password, false);
            WithdrawTest("Can't withdraw with invalid password", account, 1, "wrong password", false);
            WithdrawTest("Can't withdraw more than balance", account, amount + 1, password, false);
            WithdrawTest("Can withdraw right amount with right password", account, amount - 1, password, true);

            WithdrawTest("Can't withdraw Invalid Amount", account, -1, password, amount);
            WithdrawTest("Can't withdraw with invalid password", account, 1, "wrong password", amount);
            WithdrawTest("Can't withdraw more than balance", account, amount + 1, password, amount);
            WithdrawTest("Can withdraw right amount with right password", account, 100, password, 1);

            account.Show();
        }
    }
}
