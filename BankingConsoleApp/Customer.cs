using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Account> Account = new List<Account>();

        public void CreateCustomer()
        {
            Console.WriteLine("Please introduce your first name: ");
            this.FirstName = Console.ReadLine();
            while (FirstName.Length == 0) 
            {
                Console.WriteLine("First name requiered: ");
                this.FirstName = Console.ReadLine();
            }

            Console.WriteLine("Introduce please your last name: ");
            this.LastName = Console.ReadLine();
            while (LastName.Length == 0)
            {
                Console.WriteLine("Last name required: ");
                this.LastName = Console.ReadLine();
            }
        }

        public void CustomerDetails()
        {
            Console.WriteLine($">> Customer: {this.FirstName} {this.LastName} <<");
            foreach (var acc in Account) 
            {
                Console.WriteLine($">> Account id: {acc.Id} << \n\nCreation Date: {acc.Date}");
            }
        }
    }
}
