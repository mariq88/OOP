using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class StudentAccessory : Product
    {
        //fields
        private AccessoryType typeOfAccessory;

        //constructor
        public StudentAccessory(decimal price, int quantity, string name, AccessoryType type, decimal discount, bool isForRent = false)
            : base(price, quantity, name, discount, isForRent) // Here the name is the brand name! 
        {
            this.typeOfAccessory = type;
        }

        //property
        public AccessoryType TypeOfAccessory
        {
            get { return this.typeOfAccessory; }

            set { this.typeOfAccessory = value; }
        }
    }
}
