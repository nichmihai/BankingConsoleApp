using System;
using System.Collections.Generic;
using System.Text;

namespace BankingConsoleApp
{
    public interface IAccountActions
    {
        public double Deposist(double amount);
        public double Withdrawal(double amount);
        void AccountDettails();
    }
}
