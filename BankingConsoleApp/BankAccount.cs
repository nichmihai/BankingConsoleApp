using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    public class BankAccount
    {
        Customer customer = new Customer();
        Account account = new Account();
        CheckingAccount ck = new CheckingAccount();
        public void CreateCustomer()
        {
            if (account.Customer.Count == 0)
            {
                customer.CreateCustomer();
            }
            else 
            {
                Console.WriteLine(">> Account already has a Customer <<");
            }
        }

        public void CreateAccount()
        {
            if (customer.Account.Count == 0)
            {
                account.CreateAccount();
                customer.Account.Add(account);
                account.Customer.Add(customer);
            }
            else
            {
                Console.WriteLine("<---------------------------->\n");
                Console.WriteLine(">> Account already exists! << \n");
                Console.WriteLine("<---------------------------->\n");
            }
        }

        public void CreateChecking()
        {
            if (!customer.Account.Contains(ck))
            {
                ck.CreateAccount();
                customer.Account.Add(ck);
                ck.AccountDettails();
            }
            else 
            {
                Console.WriteLine(">> You alreade have a checking account << ");
            }
        }

        public void CheckingDeposit()
        {
            Console.WriteLine("Please introduce the amount you want to deposit");
            double amount = double.Parse(Console.ReadLine());
            ck.Deposist(amount);
            ck.AccountDettails();
        }

        public void ListOfAccounts()
        {
            foreach (var acc in customer.Account)
            {
                int num = 0;
                if (acc is CheckingAccount) 
                {
                    ++num;
                    Console.WriteLine($"{num}. Checking Account");
                    
                }
                
            }
        }
        public void BankAccountDetails()
        {
            if (account.Customer.Count != 0)
            {
                Console.WriteLine("<---------------------------->\n");
                Console.WriteLine(">> Account Details <<\n");
                customer.CustomerDetails();
                Console.WriteLine("\n\n<---------------------------->\n");
            }
           
        }
    }
}
