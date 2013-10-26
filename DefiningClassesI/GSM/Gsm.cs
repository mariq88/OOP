using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Gsm
{ 
    public Battery Battery = new Battery(Battery.BatteryType.LiIon,0,0);
    public Display Display = new Display(0, null);
    ////fields
    static private Gsm iphone = new Gsm("Iphone 4s","Apple"); ////problem 6
    private string gsmModel; ////problem 1
    private string gsmManufacturer; ////problem 1
    private decimal gsmPrice; ////problem 1
    private string owner; ////problem 1
    private Battery battery; ////problem 1
    private Display display; ////problem 1
    private List<Call> callHistory = new List<Call>(); 

    ////constructors 

    public Gsm(string model, string manufacturer) : this(model,manufacturer,0,null,null,null)////problem 2
    {
        //this.gsmModel = model;
        //this.gsmManufacturer = manufacturer;
        //this.gsmPrice = 0.0m;
        //this.owner = null;
        ////this.callHistory = new List<Call>();
    }

    public Gsm(string model, string manufacturer, decimal price) : this(model, manufacturer,price,null,null,null)////problem 2
    {
        //this.gsmPrice = price;
    }

    public Gsm(string model, string manufacturer, decimal price, string owner) : this(model, manufacturer, price, owner,null,null)////problem 2
    {
        //  this.owner = owner;
    }

    public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
    {
        this.GsmModel = model;
        this.GsmManufacturer = manufacturer;
        this.GsmPrice = price;
        this.GsmOwner = owner;
        this.Battery = battery;
        this.Display = display;
    }

    ////properties
    public static Gsm Iphone4S
    {
        get
        {
            return iphone;
        }
    }

    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
    }

    public string GsmModel ////problem 5
    {
        get
        {
            return this.gsmModel;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The model is required.");
            }

            this.gsmModel = value;
        }
    }

    public string GsmManufacturer  ////problem 5
    {
        get
        {
            return this.gsmManufacturer;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The Manufacturer is required.");
            }

            if (value.Length < 2)
            {
                throw new ArgumentException("There is no such model. Model name shoud be at least 2 characters.");
            }

            this.gsmManufacturer = value;
        }
    }

    public decimal GsmPrice ////problem 5
    {
        get
        {
            return this.gsmPrice;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price can be only a positive number.");
            }

            this.gsmPrice = value;
        }
    }

    public string GsmOwner ////problem 5
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

    //public Battery Battery ////problem 5
    //{
    //    get
    //    {
    //        return this.battery;
    //    }

    //    set
    //    {
    //        this.battery = value;
    //    }
    //}

    //public Display Display ////problem 5
    //{
    //    get
    //    {
    //        return this.display;
    //    }

    //    set
    //    {
    //        this.display = value;
    //    }
    //}

    ////methods
    public override string ToString() ////problem 4
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("\nModel" + this.gsmModel);
        sb.Append("\nGSM Manufacturer" + this.gsmManufacturer);
        if (this.gsmPrice > 0)
        {
            sb.Append("Price: " + string.Format("{0:C}", this.gsmPrice));
        }

        sb.Append("\nOwner: " + this.owner);
        sb.Append("\nDisplay Size:" + Display.Size);
        sb.Append("\nDisplay Colors: " + Display.Colors);
        sb.Append("\nBattery Type: " + Battery.BatType);
        sb.Append("\nHours Talk: " + Battery.HoursTalk);
        sb.Append("\nHours Idle: " + Battery.HoursIdle);
        sb.Append("\nBattery model: " + Battery.Model);
        return sb.ToString();
    }

    public void AddCall(DateTime date, string phoneNumber, int duration) //// problem 10
    {
        Call newCall = new Call(date, phoneNumber, duration);
        this.callHistory.Add(newCall);
    }

    public void DeleteCall(int duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public double PriceCalls(double price)
    {
        double timeCalls = 0;
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            timeCalls += this.callHistory[i].Duration; 
        }

        double totalPrice = price + (timeCalls / 60);
        return totalPrice;
    }

    public void DisplayCalls()
    {
        StringBuilder callsb = new StringBuilder();
        foreach (var call in callHistory)
        {
            callsb.AppendFormat("Number: {0},  Date: {1},  Duration: {2} \n", call.PhoneNumber, call.DateTime, call.Duration);
            Console.WriteLine(callsb.ToString());
        }
    }
    ////static void Main(string[] args)
    ////{
    ////}
}