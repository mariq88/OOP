using System;
using System.Linq;
using System.Text;

public class Battery
{
    private BatteryType model; ////problem 1
    private float hoursIdle; ////problem 1
    private float hoursTalk; ////problem 1
    private BatteryType? batteryType; ////problem 3
   
    ////constructors
    public Battery(BatteryType model)
        : this(model, 0, 0) ////problem 2
    {
        //this.model = null;
        //this.hoursIdle = 0.0f;
        //this.hoursTalk = 0.0f;
    }

    public Battery(BatteryType model, float hoursIdle) : this(model,hoursIdle,0) ////problem 2
    {
        //this.model = model;
    }

    public Battery(BatteryType model, float hoursIdle, float hoursTalk)  ////problem 2
    {
        this.Model = model;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;

    }

    public enum BatteryType ////problem 3
    { 
        LiIon,
        NiMH,
        NiCd
    }

    ////properties
    public BatteryType Model ////problem 5
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

    public float HoursIdle ////problem 5
    {
        get
        {
            return this.hoursIdle;
        }

        set
        {
            this.hoursIdle = value;
        }
    }

    public float HoursTalk ////problem 5
    {
        get
        {
            return this.hoursTalk;
        }

        set
        {
            this.hoursTalk = value;
        }
    }

    public BatteryType? BatType ////problem 5
    {
        get
        {
            return this.batteryType;
        }

        set
        {
            this.batteryType = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.model);
        sb.Append(this.hoursIdle);
        sb.Append(this.hoursTalk);
        return sb.ToString();
    }
}