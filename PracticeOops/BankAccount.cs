using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOops
{

    /// <summary>
    /// Example of Encapsulation
    /// </summary>
    public class BankAccount
    {
        private double _amount;

        public BankAccount(double _amount)
        {
            DepositBalance(_amount);
        }

        public double ShowBalance()
        {
            return _amount;
        }
        public void DepositBalance(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount is not less than zero");
            }
            _amount += amount;
        }
        public void WithdrawBalance(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount is not less than zero");
            }
            if (_amount < amount)
            {
                throw new ArgumentException("Insufficient balance");
            }
            _amount -= amount;
        }
      
    }
}
