using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public abstract class Product : IRentable, IDiscountable,ISearchable
    {
        private decimal price;
        private int quantity;
        private string name;
        private readonly bool isForRent;
        private readonly decimal discount;
        private List<Product> productsForSearch;
        

        public string Name         
        {
            get { return this.name; }
            set {this.name=value; }
        }

        public Product(decimal price, int quantity, string name, decimal discount = 0, bool isForRent = false)
        {
            this.Price = price;
            this.Quantity = quantity;
            this.Name = name;
            this.discount = discount;
            this.isForRent = isForRent;
            this.ProductsForSearch = productsForSearch;
        }

        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value >= 0)//value of Quantity can be zero, when we have no stock available
                {
                    this.quantity = value;
                }
                else
                {
                   throw new IndexOutOfRangeException("Quantity must be greater than 0");
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Price must be greater than 0");
                }
            }
        }
        public List<Product> ProductsForSearch
        {
            get
            {
                return this.productsForSearch;
            }
            set
            {
                this.productsForSearch = value;
            }
        }

        public decimal Discount()
        {
            return discount;
        }

        public bool IsRentable()
        {
            return isForRent;
        }
        public bool SearchByName(Product product)
        {                 //this.bookAuthor = name;
            if (product.GetType() == typeof(Product))
            {
                Product find = productsForSearch.First(b => b.Name == product.Name);
                return true;
            }
            else
            { return false; }
            //bool findInList = ProductsForSearch.Contains(this.Name);
            //if (findInList==true)
            //{
            //    return findInList;       
            //}
            //else
            //{
            //    return false;
            //}
                          
                  
        }

        //events
        public event DelegateAlmostEmptyInventory AlmostEmptyInventory;
        public event DelegateEmptyInventory EmptyInventory;
        public EventArgs e = null;

        public void FireAlmostEmptyInventory()//fires on AlmostEmptyInventory
        {
            if (AlmostEmptyInventory != null)
            {
                AlmostEmptyInventory();
            }
        }

        public void FireEmptyInventory()//fires on EmptyInventory
        {
            if (EmptyInventory != null)
            {
                EmptyInventory();
            }
        }

        //methods
        public void SellOneQuantity()
        {
            if (this.Quantity > 5)
            {
                this.Quantity--;
            }

            else if (this.Quantity <= 5 && this.Quantity > 0)
            {
                AlmostEmptyInventory += new DelegateAlmostEmptyInventory(InventoryManagement.AlmostEmptyInventoryAction);
                FireAlmostEmptyInventory();
                this.Quantity--;

            }

            else if (this.Quantity == 0)
            {
                Console.WriteLine(this.Name + " is out of stock!");
                EmptyInventory += new DelegateEmptyInventory(InventoryManagement.EmptyInventoryAction);
                FireEmptyInventory();
            }
        }

        public void BuyOneQuantity()
        {
            this.Quantity++;
        }
    }
}