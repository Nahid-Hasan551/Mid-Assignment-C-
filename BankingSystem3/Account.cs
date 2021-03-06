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
        private string dob;
        private double balance;
        private string accountType;
        private Address address;
        public int transctionNo = 0 ;
        public static int lastnumber = 100 ;

        public Account(string type, int accountNumber, string accountName, string date, double balance, Address address)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
            this.dob = date;
            this.accountType = type;
        }
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        

        public string AccountType
        {
            set { this.accountType = value; }
            get { return this.accountType; }
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
            Console.WriteLine("\n\nAccount No : "+this.accountNumber+"\nAccount Type : "+ accountType + "\nAccount Name : "+this.accountName+"\nDate Of Birth : "+this.dob+"\nBalance : "+this.balance);
            Console.WriteLine();
            this.address.PrintAddress();
        }
    }
}
