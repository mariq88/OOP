using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store
    {
        //Fields
        private List<Product> productList;

        //Properties

        public List<Product> ProductList
        {
            get
            {
                return this.productList;
            }
            set
            {
                this.productList = value;
            }
        }

        //Methods
        public bool CheckAvailability(Product product)//this method check if a product is in the store, ote there is no such a product.
        {
            Product prod = null;
            if (product.GetType() == typeof(Book))
            {
                prod = ProductList.FirstOrDefault(b => b.Name == product.Name);//kogato podadem ime na kniga wryshta pyrwata namerena ili defaultnata stojnost za tipa.
            }

            if (product.GetType() == typeof(Movie))
            {
                prod = ProductList.FirstOrDefault(b => b.Name == product.Name);//kogato podadem ime na kniga wryshta pyrwata namerena ili defaultnata stojnost za tipa.
            }

            if (product.GetType() == typeof(Music))
            {
                prod = ProductList.FirstOrDefault(b => b.Name == product.Name);//kogato podadem ime na kniga wryshta pyrwata namerena ili defaultnata stojnost za tipa.
            }

            if (product.GetType() == typeof(Toy))
            {
                prod = ProductList.FirstOrDefault(b => b.Name == product.Name);//kogato podadem ime na kniga wryshta pyrwata namerena ili defaultnata stojnost za tipa.
            }
            if (product.GetType() == typeof(StudentAccessory))
            {
                prod = ProductList.FirstOrDefault(b => b.Name == product.Name);//kogato podadem ime na kniga wryshta pyrwata namerena ili defaultnata stojnost za tipa.
            }
            else if(prod == null)
            {
                throw new ProductNotExistsExeption("There is no such a product");

            }
            return prod.Quantity > 0;
        }
    }
}
