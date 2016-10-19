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
        }


        public static void CreateAccount()
        {
            Menu1();

            int choice = Console.Read();

            if (ValidMenu1(choice))
            {
                switch(choice)
                { 
                    case 1:
                        CreateAccount();
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

        static bool ValidMenu1(int choice)
        {
            if (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 5 || choice != 6)
            {
                return true;
            }
            else return false;
        }

        static void Menu2()
        {
            Console.WriteLine("Choose account type:");
            Console.WriteLine("\n 1- Savings account");
            Console.WriteLine("\n 2- Checking account");
        }

        static void CreateAccount()
        {

        }

        static void RemoveAccount()
        {

        }

        static void AccountDetails(int acc_number)
        {

        }

        static void Deposit(int acc_number, double amount)
        {

        }

        static void Withdraw(int acc_number, double amount)
        {

        }

        static double TOTAL()
        {

        }

        class Account
        {
            string Type { get; set; }
            string Customer { get; set; }
            float Funds { get; set; }

        }

        class Savings: Account
        {
            double interest = 0.015;
        }
    }
}
