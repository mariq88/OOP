using System;
using System.Linq;

public class Call ////problem 8
{
    private DateTime dateTime; ////problem 8
    private string phoneNumber; ////problem 8
    private int duration; ////problem 8

    public Call(DateTime dateTime, string phoneNumber, int duration)
    {
        this.dateTime = dateTime;
        this.phoneNumber = phoneNumber;
        this.duration = duration;
    }

    public DateTime DateTime
    {
        get
        {
            return this.dateTime;
        }

        set
        {
            this.dateTime = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }

        set
        {
            this.phoneNumber = value;
        }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }

        set
        {
            this.duration = value;
        }
    }
}