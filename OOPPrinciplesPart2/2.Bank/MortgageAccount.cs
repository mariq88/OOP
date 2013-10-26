using System;
using System.Linq;

namespace _2.Bank
{
    class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {
        }

        public override decimal CalculateTheInterest(int months)
        {
            if ((months <= 6 && this.Customer is Individual))
            {
                return 0;
            }
            else if (months <= 12 && this.Customer is Company)
            {
                return (months * this.InterestRate) / 2;
            }
            else
            {
                return months * this.InterestRate;
            }
        }

        public decimal Deposit(decimal money)
        {
            return this.Balance += money;
        }
    }
}