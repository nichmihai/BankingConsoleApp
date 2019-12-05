using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    class CheckingAccount : Account, IAccountActions, IAccount
    {
        Random r = new Random();

        public virtual void CreateAccount()
        {
            new CheckingAccount();
            this.Id = r.Next();
            this.Balance = 0;
            this.Date = DateTime.Now;
        }

        public double Deposist(double amount)
        {
            this.Balance += amount;
            Console.WriteLine($"Available resources on the Checking account: {this.Balance}");
            return amount;
        }

        public double Withdrawal(double amount)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
                Console.WriteLine($"Available resources on the Checking account: {this.Balance}");
            }
            else 
            {
                Console.WriteLine("Insuficient balance on Checking account");
            }
            return amount;
        }

        public void AccountDettails() 
        {
            Console.WriteLine("<---------------------------->\n");
            Console.WriteLine($">> Checking Account Id: {this.Id} << \n  >> Checking Balance: {this.Balance} <<\n");
            Console.WriteLine($"Creation date: {this.Date}");
            Console.WriteLine("<---------------------------->\n");
        }
    }
}
