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
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tInvalid Input");
                        break;
                }
            }

            void openmenu()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" + ourBank.Name);
                Console.WriteLine("\n\t\tCommand Overview: \n\t\tOpen New Saving Account : saving\n\t\tOpen New Checking Account : checking\n\t\tExit: quit");
                Console.WriteLine("\n\n\n\t\tOperations:");
                Console.WriteLine("\n\n\tOpen New Account\n\tOpen New Checking Account\n\tExit To Main Menu");
                Console.Write("\n\t\tEnter Operation Command: ");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "saving":
                        Console.Write("\n\tEnter Account Name: ");
                        string name = (Console.ReadLine());
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

                        ourBank.AddAccount(new Account(Account.lastnumber++, name, balance, new Address(road, houseno, city, country)));
                        Console.WriteLine("\n\t\tAccount Create Successfuly for account number:" + (Account.lastnumber - 1));
                        openmenu();
                        break;
                    case "exit":
                        mainmenu();
                        break;
                    default:
                        Console.WriteLine("\n\n\tInvalid Command!");
                        break;
                }
            }

            void accountmenu()
            {
                Console.Clear();
                Console.WriteLine("\t\t\t" + ourBank.Name);
                Console.WriteLine("\n\t\tCommand Overview: \n\t\tView Account Information : show\n\t\tEdit Account Information : edit\n\t\tDeposit: deposit\n\t\tWithdraw: withdraw\n\t\tTransfer: transfer\n\t\tDisplay Transction And Balance: display\n\t\tExit To Main Menu : exit");
                Console.WriteLine("\n\n\n\t\tOperations:");
                Console.WriteLine("\n\n\tShow Account Information\n\tEdit Account Information\n\tDelete Account\n\tDeposit");
                Console.WriteLine("\tWithdraw\n\tTransfer\n\tDisplay Transaction And Balance\n\tExit ");
                Console.Write("\n\t\tEnter Operation Command: ");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "show":
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\n\n\t\t\tView Mode:");
                        Console.Write("\n\tEnter Account Number To Show Information :  ");
                        int acn = int.Parse(Console.ReadLine());
                        ourBank.SearchAccount(acn);
                        break;
                    case "edit":
                        Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\t\tEdit Information");
                        break;
                    case "delete":
                        Console.Write("\n\tEnter Account Number To Delete :  ");
                        int del = int.Parse(Console.ReadLine());
                        ourBank.DeleteAccount(del);
                        break;
                    case "deposit":
                        Console.WriteLine("\n\t\t\tDeposit Mode:");
                        Console.Write("\n\n\n\tEnter Account Number To Deposit: ");
                        int acnd = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Deposit Ammount : ");
                        double amount = double.Parse(Console.ReadLine());
                        ourBank.Deposit(acnd, amount);
                        accountmenu();
                        break;
                    case "withdraw":
                        Console.WriteLine("\n\t\t\tWithdraw Mode:");
                        Console.Write("\n\n\n\tEnter Account Number To Withdraw: ");
                        int withdrwaccount = int.Parse(Console.ReadLine());
                        Console.Write("\tEnter Withdraw Ammount : ");
                        double withdrawamount = double.Parse(Console.ReadLine());
                        ourBank.Withdraw(withdrwaccount, withdrawamount);
                        mainmenu();
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
                        accountmenu();
                        break;
                    case "display":
                        Console.WriteLine("\n\n\t\tShow Display And Balance!");
                        break;
                    case "exit":
                        mainmenu();
                        break;
                    default:
                        Console.WriteLine("\n\n\t\tInvalid Command!");
                        break;

                }
            }

            
            
            

        }

        

        
    }
}


/*string ch = Console.ReadLine();
               if (ch == "open")
               {
                   Console.Write("\nEnter Account Name: ");
                   string name = (Console.ReadLine());
                   Console.Write("Enter Intial Balance: ");
                   int  balance = int.Parse(Console.ReadLine());
                   Console.Write("Enter Road Number : ");
                   int road =int.Parse(Console.ReadLine());
                   Console.Write("Enter House Number : ");
                   int houseno = int.Parse(Console.ReadLine());
                   Console.Write("Enter City Name : ");
                   string city = Console.ReadLine();
                   Console.Write("Enter Country Name: ");
                   string country = Console.ReadLine();

                   ourBank.AddAccount(new Account(Account.lastnumber++,name, balance,new Address(road, houseno, city, country)));
                   Console.WriteLine("Account Create Successfuly for account number:"+(Account.lastnumber-1));
                   continue;

               }*/












/*
 * case "acount":
                        //Console.Clear();
                        Console.WriteLine("\t\t\t" + ourBank.Name);
                        Console.WriteLine("\n\t\tCommand Overview: \n\t\tFor View Account Information : show\n\t\tFor Edit Account Information : edit\n\t\tFor Deposit: deposit\n\t\tFor Withdraw: withdraw\n\t\tFor Transfer: transfer\n\t\tFor Display Transction And Balance: display\n\t\tFor Exit Application: quit");
                        Console.WriteLine("\n\n\n\t\tOperations:");
                        Console.WriteLine("\n\n\tShow Account Information\n\tEdit Account Information\n\tDelete Account\n\tDeposit");
                        Console.WriteLine("\tWithdraw\n\tTransfer\n\tDisplay Transaction And Balance\n\tExit ");
                        Console.Write("\n\tEnter Operation Commands : ");
                        string ch = Console.ReadLine();

                        if (ch == "delete")
                        {
                            Console.Write("Enter Account Number To Delete :  ");
                            int del = int.Parse(Console.ReadLine());
                            ourBank.DeleteAccount(del);
                            continue;
                        }
                        else if (ch == "show")
                        {
                            Console.Write("Enter Account Number To Show Information :  ");
                            int acn = int.Parse(Console.ReadLine());
                            ourBank.SearchAccount(acn);
                            continue;
                        }

                        else if (ch == "deposit")
                        {
                            Console.Write("\nEnter Account Number To Deposit: ");
                            int acnd = int.Parse(Console.ReadLine());
                            Console.Write("Enter Deposit Ammount : ");
                            double amount = double.Parse(Console.ReadLine());
                            ourBank.Deposit(acnd, amount);
                            
                        }
                        else if (ch == "withdraw")
                        {
                            Console.Write("\nEnter Account Number To Withdraw: ");
                            int acnd = int.Parse(Console.ReadLine());
                            Console.Write("Enter Withdraw Ammount : ");
                            double amount = double.Parse(Console.ReadLine());
                            ourBank.Withdraw(acnd, amount);
                        }

                        else if (ch == "transfer")
                        {
                            Console.Write("\nEnter Account Number To Transfer : ");
                            int facn = int.Parse(Console.ReadLine());
                            Console.Write("\nEnter Account Number From Transfer: ");
                            int sacn = int.Parse(Console.ReadLine());
                            Console.Write("Enter Transfer Ammount : ");
                            double amount = double.Parse(Console.ReadLine());
                            ourBank.Transfer(facn, sacn, amount);
                            continue;
                        }
*/