using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Bank
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Individual("Ivan Ivanov",1918));
            customers.Add(new Individual("Georgi Petkov",1520));
            customers.Add(new Company("NewCompany", "BG1234567890123456"));
            customers.Add(new Company("AnotherNewCompany","BG9876543210123456"));
           
            DepositAccount depositAccount = new DepositAccount(new Individual("Boyko Draganov", 1525), 1500M, 0.005M);
            LoanAccount loanAccount = new LoanAccount(new Company("Boyko Draganov","BG123456"), 1000M, 0.002M);
            List<Account> accounts = new List<Account>() { depositAccount, loanAccount };
            foreach (var account in accounts)
            {
                Console.WriteLine("The account is:{0}. The owner is: {1}.  The balance is: {2} and the interest rate for {3} months is: {4:F2}", account.GetType(),
                    account.Customer.GetType().Name, account.Balance, 3, account.CalculateTheInterest(3));
            }
            depositAccount.Draw(500);
            depositAccount.Deposit(1000);

            Console.WriteLine("The account is:{0}. The owner is: {1}.  The balance is: {2} and the interest rate for {3} months is: {4:F2}", depositAccount.GetType(),
                depositAccount.Customer.GetType().Name, depositAccount.Balance, 3, depositAccount.CalculateTheInterest(3));
        }
    }
}