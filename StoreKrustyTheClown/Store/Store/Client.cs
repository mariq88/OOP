using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Client : IDiscountable
    {
        /* fields*/
        private string name;
        private string clientID;
        private History clientHistory;
        private decimal shoppingCard;

        /* properties */
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string ClientID
        {
            get { return this.clientID; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Client ID cannot be empty!");
                }
                this.clientID = value;
            }
        }
        public decimal ShoppingCard
        {
            get { return this.shoppingCard; }
            set { this.shoppingCard = value; }
        }

        /* constructor */
        public Client(string name, string clientID, History clientHistory, decimal shoppingCard)
        {
            this.name = name;
            this.clientID = clientID;
            this.clientHistory = clientHistory;
            this.shoppingCard = shoppingCard;

        }

        public Client()
        {
            // TODO: Complete member initialization
        }
        
        /* interface implementation */
        public decimal Discount()//Client client)
        {
            if (  (shoppingCard > 200) && (clientHistory.purchase.Quantity != 0) && DateTime.Today.Subtract(clientHistory.purchaseDate).Days < 90)
            {
                /* if the amount of money of the current order > 200 and the client has previously 
                * bought something and there was a purchase within the last 3 months */
                return this.shoppingCard * 20 / 100;
            }
            else if ((shoppingCard > 500) && (clientHistory.purchase.Price > 500))
            {
                /* if previous orders priice > 500, give 10% discount*/
                return this.shoppingCard * 10 / 100;
            }
            else
            {
                /* no discount */
                return 0;
            }
        }
    }
}
