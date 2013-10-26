using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Toy : Product
    {
        public int Warranty { get; set; }

        public int? AppropriateAge { get; set; }

        public Nationality Origin { get; set; }

        public Toy(decimal price, int quantity, string name, decimal discount, bool isForRent) : base(price, quantity, name, discount, isForRent)
        {
        }

        public Toy(decimal price, int quantity, string name, decimal discount, bool isForRent, int warranty = 0, int? appropriateAge = null, Nationality origin = Nationality.Bulgarian) : base(price, quantity, name, discount, isForRent)
        {
            this.Warranty = warranty;
            this.AppropriateAge = appropriateAge;
            this.Origin = origin;
        }
    }
}