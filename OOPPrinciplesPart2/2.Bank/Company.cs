using System;
using System.Linq;

namespace _2.Bank
{
    class Company : Customer
    {
        private string name;
        private string bulstat;

        public Company(string name, string bulstat)
        {
            this.name = name;
            this.bulstat = bulstat;
        }
    }
}