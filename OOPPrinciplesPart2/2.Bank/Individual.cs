using System;
using System.Linq;

namespace _2.Bank
{
    class Individual : Customer
    {
        private string name;
        private int id;

        public Individual(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}