using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    public class Account : IAccount
    {
        public int Id { get; set; }

        public double Balance { get; set; }

        public decimal Interest { get; set; }

        public DateTime Date { get; set; }

        public List<Customer> Customer = new List<Customer>();

        public void CreateAccount()
        {
            Random r = new Random();
            this.Id = r.Next();
            this.Date = DateTime.Now;
        }
    }
}
