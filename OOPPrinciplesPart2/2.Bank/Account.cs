using System;
using System.Linq;

namespace _2.Bank
{
    class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        // private int months;
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.customer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        //public int Months 
        //{
        //    get { return this.months; }
        //    set { this.months = value; }
        //}
      
        public virtual decimal CalculateTheInterest(int months) 
        {
            return months * this.interestRate;
        }
    }
}