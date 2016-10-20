using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu1();                   
                                   
            //counter for global number of accounts
            int acc_counter = 0;
            int choice = Console.Read();

            if (ValidMenu1(choice))
            {
                // menu selector
                switch (choice)
                {
                    case 1:
                        CreateAccount(acc_counter);
                        break;
                    case 2:
                        RemoveAccount();
                        break;
                    case 3:
                        Deposit();
                        break;
                    case 4:
                        Withdraw();
                        break;
                    case 5:
                        AccountDetails();
                        break;
                    case 6:
                        TOTAL();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Option selected unavailable");
            }
        }

        // method to display first menu 
        static void Menu1()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("\n 1- Create Account");
            Console.WriteLine("\n 2- Remove Account");
            Console.WriteLine("\n 3- Deposit");
            Console.WriteLine("\n 4- Withdraw");
            Console.WriteLine("\n 5- Account details");
            Console.WriteLine("\n 6- BANK TOTAL");
        }

        // validate option selected is valid for menu1
        static bool ValidMenu1(int choice)
        {
            if (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 5 || choice != 6)
            {
                return false;
            }
            else return true;
        }

        // method to display second menu if option 1 of menu1 is selected
        static void Menu2()
        {
            Console.WriteLine("Choose account type:");
            Console.WriteLine("\n 1- Savings account");
            Console.WriteLine("\n 2- Checking account");
        }

        // validate option selected is valid for menu2
        static bool ValidMenu2(int choice)
        {
            if (choice != 1 || choice != 2)
            {
                return false;
            }
            else return true;
        }

        //method to create a new account
        static void CreateAccount()
        {
            Menu2();
            int choice = 0;
            Console.Read(choice);
            if (ValidMenu2(choice))
            {
                if(choice == 1)
                {
                    // create savings account and initialize all values of the class Savings
                    Savings account = new Savings();
                    account.acc_number = acc_counter + 1;
                    acc_counter++; 
                    account.Type = "Savings";                    
                    Console.WriteLine("Enter customer full name");
                    account.Customer = Console.ReadLine();
                    Console.WriteLine("Enter opening funds");
                    account.Funds = double.Parse(Console.ReadLine());

                    NewAccs.Add(account);
                }
                else if (choice == 2)
                {
                    // create checking account and initialize all values of the class Account
                    Account account = new Account();
                    account.acc_number = acc_counter + 1;
                    acc_counter++;
                    account.Type = "Checking";
                    account.Funds = 0.00;
                    Console.WriteLine("Enter customer full name");
                    account.Customer = Console.ReadLine();
                    Console.WriteLine("Enter opening funds");
                    account.Funds = double.Parse(Console.ReadLine());

                    NewAccs.Add(account);
                }
            }
        }

        static void RemoveAccount()
        {
            Console.WriteLine("Enter account number of account to be removed: ");
            int account = int.Parse(Console.ReadLine());
            
        }

        static void AccountDetails()
        {
            Console.WriteLine($"acc_number{acc_number}");
            Console.WriteLine($"\n Type: {Type}" );
            Console.WriteLine($"\n Customer name: {Customer}");
            Console.WriteLine($"\n Balance: {Funds}");
            if(accounttype == "Savings")
            {
                Console.WriteLine($"\n Interest: {interest}");
            }

        }

        static void Deposit()
        {
            Console.WriteLine("Enter account number to deposit: ");
            int acc_number = int.Parse(Console.ReadLine());         
            Console.WriteLine($"Account in which will be deposited{acc_number}");
            Console.WriteLine("\nEnter amount to deposit:");
            double amount = double.Parse(Console.ReadLine());

         }

        static void Withdraw()
        {
            Console.WriteLine($"Account of withdrawal{acc_number}");
            Console.WriteLine("\nEnter amount to withdraw:");
            double.Parse(Console.ReadLine());
        }

        public static double TOTAL(NewAccs)
        {
            double sum = 0;
            foreach (var account in NewAccs)
            {
                sum += account.Funds;
            }

            Console.WriteLine($"TOTAL FUNDS AVAILABLE IN BANK: {sum}");            
        }

        public class Account
        {
            public int acc_number { get; set; }
            public string Type { get; set; }
            public string Customer { get; set; }
            public double Funds { get; set; }
        }

        public class Savings : Account
        {
            public double interest = 0.015;
        }

        // create a list of Account classes and create a list type of class which can be accessed from outside this class
        public class Accounts
        {
            List<Account> NewAccs = new List<Account>();

            public List<Account> TheLyst
            {
                get { return NewAccs; }
            }
        }
         
    }
}
