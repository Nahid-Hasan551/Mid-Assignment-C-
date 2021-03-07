using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem3
{
    class Account

    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        public static int lastnumber = 100 ;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public Address Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Transfer(Account account, double amount)
        {
            account.Balance += amount; 
        }

        public void PrintAccount()
        {
            Console.WriteLine("Account No:"+this.accountNumber+"\nAccount Name:"+this.accountName+"\nBalance:"+this.balance);
            this.address.PrintAddress();
        }
    }
}
