//Using delegates write a class Timer that has can execute certain method at each t seconds.

using System;
using System.Linq;
using System.Threading;

public class Timer
{
    public delegate void RunningTimer();

    public uint Delay { get; set; }

    public RunningTimer MethodProperty { get; set; }

    public Timer(uint delay, RunningTimer invokeMethod) //constructor
    {
        this.Delay = delay;
        this.MethodProperty = invokeMethod;
        Thread newThread = new Thread(() => // So that the methods are executed parallel
        {
            while (true)
            {
                this.MethodProperty();
                Thread.Sleep((int)this.Delay);
            }
        });
        newThread.Start();
    }

    public static void VeryImportantMethod()
    {
        Console.WriteLine("Calling the method! It's {0}", DateTime.Now);
    }

    public static void Main()
    {
        Timer newTimer = new Timer(1000, VeryImportantMethod); //Executes every second
        //Timer secondTimer = new Timer(2000, SampleMethod1);
    }
}