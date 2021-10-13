using System;

namespace ConceptArchitect.Finance
{
    public class BankAccountV1
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


        public BankAccountV1(int accountNumber,string name, string password, double balance, double interestRate)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
            this.password = password;
            this.Balance = balance;
            this.interestRate = interestRate;
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("amount deposited");
            }
            else
            {
                Console.WriteLine("amount deposit failed");
            }

        }

        public void Withdraw(double amount, string password)
        {
            if (amount <= 0)
            {
                Console.WriteLine("can't withdraw negative amount");
            } else if(amount>Balance)
            {
                Console.WriteLine("insufficient funds");    
            }

            if (this.password != password)
            {
                Console.WriteLine("invalid credentials");
            }
            else
            {
                Console.WriteLine("Please collect your cash");
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
