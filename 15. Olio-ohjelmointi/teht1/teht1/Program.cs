using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht1
{
    public class BankAccount
    {
        private int accountNumber;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount} euros to the account.");

            return Balance;
        }

        public double Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount} euros.");
            }
            else
            {
                Console.WriteLine("Not enough funds.");
                GetBalance();
            }

            return Balance;
        }

        public void GetBalance()
        {
            Console.WriteLine($"The account balance is: {Balance} euros.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            myAccount.AccountNumber = 123345623;
            Console.WriteLine("Account number: " + myAccount.AccountNumber);

            myAccount.Balance += myAccount.Deposit(100000);
            myAccount.GetBalance();

            myAccount.Balance += myAccount.Deposit(499.99);
            myAccount.Balance += myAccount.Withdraw(5231.49);
            myAccount.Balance += myAccount.Deposit(99.99);
            myAccount.Balance += myAccount.Withdraw(821.5);
            myAccount.GetBalance();
        }
    }
}
