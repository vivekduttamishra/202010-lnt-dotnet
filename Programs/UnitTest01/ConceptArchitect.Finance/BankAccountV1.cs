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
        private double balance;

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccountV1(int accountNumber, string name, string password, double balance, double interestRate)
        {
            this.name = name;
            this.AccountNumber = AccountNumber;
            this.password = password;
            this.balance = balance;
            this.interestRate = interestRate;
        }


        public void Withdraw(double amount, string password)
        {
            if (amount <= 0)
            {
                Console.WriteLine("can't withdraw negative amount");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("insufficient funds");
            }

            if (this.password != password)
            {
                Console.WriteLine("invalid credentials");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Please collect your cash");
            }
        }


        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }


        private string password;


        


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
