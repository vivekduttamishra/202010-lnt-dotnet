using System;

namespace ConceptArchitect.Finance
{
    public class BankAccount
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int AccountNumber { get; private set; }
        public double Balance { get; private set; }


        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }


        private string password;


        public BankAccount(int accountNumber,string name, string password, double balance, double interestRate)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
            this.password = password;
            this.Balance = balance;
            this.interestRate = interestRate;
        }


        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                //Balance += amount;
                //Console.WriteLine("amount deposited");
                return true;
            }
            else
            {
                //Console.WriteLine("amount deposit failed");
                return false;
            }

        }

        public bool Withdraw(double amount, string password)
        {
            if (amount<=0)
            {
                //Console.WriteLine("can't withdraw negative amount");
                return false;
            } else if(amount>Balance)
            {
                //Console.WriteLine("insufficient funds");    
                return false;
            }

            if (this.password != password)
            {
                //Console.WriteLine("invalid credentials");
                return false;

            }
            else
            {
                //Console.WriteLine("Please collect your cash");
                Balance -= amount;
                return true;
            }
        }
        
        public void CreditInterest()
        {
            Balance += (Balance * interestRate / 1200);
        }

        public void Show()
        {
            Console.WriteLine("AccountNumber:\t" + AccountNumber);
            Console.WriteLine("Name:         \t" +name);
            Console.WriteLine("Balance:      \t" + Balance);
            Console.WriteLine("Interest Rate:\t" + AccountNumber);

        }

    }
}
