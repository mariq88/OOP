using System;
using System.Linq;

namespace _2.Bank
{
    class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) : base(customer,balance,interestRate)
        {
        }

        public override decimal CalculateTheInterest(int months)
        {
            if ((this.Customer is Individual) && (months > 3))
            {
                return (months - 3) * this.InterestRate;
            }
            else if ((this.Customer is Company) && (months > 2))
            {
                return (months - 2) * this.InterestRate;
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
    }
}