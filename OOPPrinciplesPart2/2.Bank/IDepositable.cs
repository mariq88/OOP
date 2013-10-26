using System;
using System.Linq;

namespace _2.Bank
{
    interface IDepositable
    {
        decimal Deposit(decimal money);
    }
}