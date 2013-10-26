using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Movie : Product
    {
        public Movie(decimal price, int quantity, string name, decimal discount, bool isForRent=false) 
            : base(price, quantity, name,discount,isForRent)
        {
        }

        public Movie(decimal price, int quantity, Genre genre, string producer, string mainActor, string name, decimal discount, bool isForRent=false) 
            : base(price, quantity, name, discount, isForRent)
        {
            this.Genre = genre;
            this.Producer = producer;
            this.MainActor = mainActor;
        }

        public Genre Genre { get; set; }

        public string Producer { get; set; }

        public string MainActor { get; set; }

    }
}