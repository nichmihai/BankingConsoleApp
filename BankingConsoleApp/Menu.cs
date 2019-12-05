using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    class Menu
    {
        BankAccount ba = new BankAccount();
        public  void Welcome()
        {
            Console.WriteLine("<----------------------------->\n");
            Console.WriteLine("Welcome to our LostMoney bank!\n");
            Console.WriteLine("<----------------------------->\n");
            
            Console.WriteLine("--> Please choose an option:" +
                "                   1. Create Account" +
                "                   2. Exit");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                ba.CreateCustomer();
                ba.CreateAccount();
                ba.BankAccountDetails();
                CreateAccounts();
            }
            else if (option == 2)
            {
                Console.WriteLine("Have a great day!");
            }
            else 
            {
                Console.WriteLine("Wrong option.");
                while (option != 1 && option != 2) 
                {
                    Console.WriteLine("Please choose between 1 and 2 option");
                }
            }
        }

        public void CreateAccounts() 
        {
            Console.WriteLine("<----------------------------->\n");
            Console.WriteLine("Would you like to open any of the accounts from our list!\n");
            Console.WriteLine("<----------------------------->\n");

            Console.WriteLine("--> Please choose an option:" +
                "                   1. Create Checking Account" +
                "                   2. No");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                ba.CreateChecking();
                AccountActions();
            }
            else if (option == 2)
            {
                Console.WriteLine("Have a great day!");
            }
            else
            {
                Console.WriteLine("Wrong option.");
                while (option != 1 && option != 2)
                {
                    Console.WriteLine("Please choose between 1 and 2 option");
                }
            }
        }

        public void AccountActions()
        {
            Console.WriteLine("<----------------------------->\n");
            Console.WriteLine("Would you like to perform any actions on your accounts!\n");
            Console.WriteLine("<----------------------------->\n");

            Console.WriteLine("--> Please choose an option:" +
                "                   1. Deposit" +
                "                   2. Withdrawal" +
                "                   3. No");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Choose account: ");
                ba.ListOfAccounts();
            }
            else if (option == 2)
            {
                Console.WriteLine("Have a great day!");
            }
            else
            {
                Console.WriteLine("Wrong option.");
                while (option != 1 && option != 2)
                {
                    Console.WriteLine("Please choose between 1 and 2 option");
                }
            }
        }
    }
}
