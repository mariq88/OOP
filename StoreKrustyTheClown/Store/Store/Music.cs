using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{

    public class Music : Product
    {
        //fields
        //inherited fields: decimal price, int quantity string name, decimal discount, bool isForRent
        private Nationality nationality;
        //private Genre genre;
                
        //constructor
        public Music(decimal price, int quantity, string name, Nationality nationality, decimal discount, bool isForRent = false)
            : base(price, quantity, name, discount, isForRent)
        {
            this.Nationality = nationality;
            //this.Genre = genre;
        }

        //properties
        public Nationality Nationality
        {
            get
            {
                return this.nationality;
            }
            set
            {
                this.nationality = value;
            }
        }
    }
}