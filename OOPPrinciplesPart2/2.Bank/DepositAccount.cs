using System;
using System.Linq;

namespace _2.Bank
{
    class DepositAccount : Account, IDrawable, IDepositable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {
        }

        public override decimal CalculateTheInterest(int months)
        {
            if (this.Balance > 1000)
            {
                return months * this.Balance;
            }
            else
            {
                return 0;
            }
        }

        public decimal Deposit(decimal money)
        {
            return this.Balance += money;
        }

        public decimal Draw(decimal money)
        {
            return this.Balance -= money;
        }
    }
}