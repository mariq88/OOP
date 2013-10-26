using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public struct History
    {
        public Product purchase { get; set; }
        public DateTime purchaseDate { get; set; }

        public History(Product product, DateTime dateTime) : this()
        {
            this.purchase = product;
            this.purchaseDate = dateTime;
        }
    }
}
