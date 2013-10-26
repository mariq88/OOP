using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesIGSM
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone;
        

        //static GSM iPhone=new GSM("Iphone 4S","Apple",999,"Pesho");

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            
        }

              public GSM(string model, string manufacturer) : this(model, manufacturer, 0, null)
        {
        }

        static GSM()
        {
            iPhone = new GSM("Iphone 4S","Apple");
        }

        public static GSM IPhone
        {
            get
            {
                return iPhone;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
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
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Model: " + this.model.ToString());
            sb.Append("\nManufacturer: " + this.manufacturer);
            sb.Append("\nPrice: " + this.price);
            sb.Append("\nOwner: " + this.owner);
            
            sb.Append("\nDisplay Size:" + this.display.Size);
            sb.Append("\nDisplay Colors: " + this.display.NumberofColours);
            sb.Append("\nBattery Type: " + this.battery.BType);
            sb.Append("\nHours Talk: " + this.battery.HoursTalk);
            sb.Append("\nHours Idle:" + this.battery.HoursIdle);
            sb.Append("\nBattery model: " + this.battery.Model);
            string stringBuilder = sb.ToString();
            return stringBuilder;
        }
    }
}