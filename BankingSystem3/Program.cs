using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Developer Bank", 5);
            mainmenu();
            void mainmenu()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" + ourBank.Name);
                Console.WriteLine("\n\t\tCommand Overview: \n\t\tOpen: open\n\t\tTransaction For Account : account\n\t\tExit Application: quit");
                Console.WriteLine("\n\n\n\t\t\t\tOperations:");
                Console.WriteLine("\n\n\t\tOpen New Account\n\t\tTransaction For Account\n\t\tExit Application");
                Console.Write("\n\t\tEnter Operation Command: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "open":
                        openmenu();
                        break;
                    case "account":
                        accountmenu();
                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tInvalid Input");
                        Task.Delay(1000).Wait();
                        mainmenu();
                        break;
                }
            }

            void openmenu()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" + ourBank.Name);
                Console.WriteLine("\n\t\tCommand Overview: \n\t\tOpen Savings Account : saving\n\t\tOpen Checking Account : checking\n\t\tBack To Main Menu: exit");
                Console.WriteLine("\n\n\n\t\tOperations:");
                Console.WriteLine("\n\n\tOpen Savings Account\n\tOpen Checking Account\n\tBack To Main Menu");
                Console.Write("\n\t\tEnter Operation Command: ");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "saving":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\t\tOpen Saving Account Mode: ");
                        string savingtype = "Savings";
                        Console.Write("\n\n\n\tEnter Account Name: ");
                        string sname = (Console.ReadLine());
                        Console.Write("\tEnter Date-Month-Year: ");
                        string sdob = Console.ReadLine();
                        Console.Write("\tEnter Intial Balance: ");
                        int sbalance = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Road Number : ");
                        int sroad = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter House Number : ");
                        int shouseno = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter City Name : ");
                        string scity = Console.ReadLine();
                        Console.Write("\tEnter Country Name: ");
                        string scountry = Console.ReadLine();

                        ourBank.AddAccount(new Account(savingtype, Account.lastnumber++, sname, sdob, sbalance, new Address(sroad, shouseno, scity, scountry)));
                        Console.WriteLine("\n\n\tSaving Account Create Successfuly!\n\tAccount Number:" + (Account.lastnumber - 1));
                        Task.Delay(1500).Wait();
                        openmenu();
                        break;
                    case "checking":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\t\tOpen Checking Account Mode: ");
                        string checkingtype = "Checking";
                        Console.Write("\n\n\n\tEnter Account Name: ");
                        string name = (Console.ReadLine());
                        Console.Write("\tEnter Date-Month-Year: ");
                        string dob = Console.ReadLine();
                        Console.Write("\tEnter Intial Balance: ");
                        int balance = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Road Number : ");
                        int road = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter House Number : ");
                        int houseno = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter City Name : ");
                        string city = Console.ReadLine();
                        Console.Write("\tEnter Country Name: ");
                        string country = Console.ReadLine();

                        ourBank.AddAccount(new Account(checkingtype, Account.lastnumber++, name, dob, balance, new Address(road, houseno, city, country)));
                        Console.WriteLine("\n\n\tAccount Create Successfuly for account number:" + (Account.lastnumber - 1));
                        Task.Delay(1500).Wait();
                        openmenu();
                        break;
                    case "exit":
                        mainmenu();
                        break;
                    default:
                        Console.WriteLine("\n\n\tInvalid Command!");
                        Task.Delay(1000).Wait();
                        openmenu();
                        break;
                }
            }

            void accountmenu()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" + ourBank.Name);
                Console.WriteLine("\n\t\tCommand Overview: \n\t\tShow Account information: info\n\t\tTransaction Number And Balance : show\n\t\tEdit Account Information : edit\n\t\tDeposit: deposit\n\t\tWithdraw: withdraw\n\t\tTransfer: transfer\n\t\tBack To Main Menu : exit");
                Console.WriteLine("\n\n\n\t\tOperations:");
                Console.WriteLine("\n\n\tShow Account information\n\tTransaction Number And Balance\n\tEdit Account Information\n\tDelete Account\n\tDeposit");
                Console.WriteLine("\tWithdraw\n\tTransfer\n\tDisplay Transaction And Balance\n\tBack To Main Menu ");
                Console.Write("\n\t\tEnter Operation Command: ");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "show":
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\n\t\t\tView Mode:");
                        Console.Write("\n\tEnter Account Number :  ");
                        int acn = int.Parse(Console.ReadLine());
                        ourBank.TransctionAndBal(acn);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "info":
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\n\t\t\tView Information Mode:");
                        Console.Write("\n\tEnter Account Number :  ");
                        int iacn = int.Parse(Console.ReadLine());
                        ourBank.AccountInformation(iacn);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "edit":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\t\tChange User Name Mode: ");
                        Console.Write("\n\n\tEnter Account Number: ");
                        int cacn = int.Parse(Console.ReadLine());
                        Console.Write("\n\tEnter New Name: ");
                        string name = Console.ReadLine();
                        ourBank.EditName(cacn, name);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "delete":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\n\t\tDelete Mode: ");
                        Console.Write("\n\tEnter Account Number :  ");
                        int del = int.Parse(Console.ReadLine());
                        ourBank.DeleteAccount(del);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "deposit":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\t\t\tDeposit Mode:");
                        Console.Write("\n\n\n\tEnter Account Number To Deposit: ");
                        int acnd = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Deposit Ammount : ");
                        double amount = double.Parse(Console.ReadLine());
                        ourBank.Deposit(acnd, amount);
                        Task.Delay(1000).Wait();
                        accountmenu();
                        break;
                    case "withdraw":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\t\t\tWithdraw Mode:");
                        Console.Write("\n\n\n\tEnter Account Number To Withdraw: ");
                        int withdrwaccount = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Withdraw Ammount : ");
                        double withdrawamount = double.Parse(Console.ReadLine());
                        ourBank.Withdraw(withdrwaccount, withdrawamount);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "transfer":
                        Console.WriteLine("\n\t\t\tTransfer Mode:");
                        Console.Write("\n\n\n\tEnter Account Number To Transfer : ");
                        int facn = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Account Number From Transfer: ");
                        int sacn = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Transfer Ammount : ");
                        double transferamount = double.Parse(Console.ReadLine());
                        ourBank.Transfer(facn, sacn, transferamount);
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;
                    case "exit":
                        mainmenu();
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tInvalid Command!");
                        Task.Delay(8000).Wait();
                        accountmenu();
                        break;

                }
            }

            
            
            

        }

        

        
    }
}
