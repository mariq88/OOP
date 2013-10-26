using System;
using System.Linq;

public class GsmTest
{
    public static void Main(string[] args)
    {
        Gsm[] mp = new Gsm[5];
        Display disp = new Display(15, "rgb");
        Battery bat = new Battery(Battery.BatteryType.NiMH,60,4);
        Gsm mobilePhone1 = new Gsm("Xperia Arc", "Sony", 999, "Maria");
        mp[0] = mobilePhone1;    
        Gsm mobilePhone2 = new Gsm("Optimus L5", "LG");
        mp[1] = mobilePhone2;
        Gsm mobilePhone3 = new Gsm("Lumia 820", "Nokia");
        mp[2] = mobilePhone3;
        Gsm mobilePhone4 = new Gsm("Iphone4S", "Apple");
        mp[3] = mobilePhone4;
        Gsm mobilePhone5 = new Gsm("Galaxy 3", "Samsung",200,"Ivan",bat,disp);
        mp[4] = mobilePhone5;

        for (int i = 0; i < mp.Length; i++)
        {
            Console.WriteLine(mp[i]);
        }
        Console.WriteLine(Gsm.Iphone4S.GsmModel);
        Console.WriteLine(Gsm.Iphone4S.GsmManufacturer);
        Console.WriteLine(mobilePhone1.Battery.Model);

        //Calls
        Gsm mobileDevice = new Gsm("Xperia ArcS","Sony Ericsson",500,"ME!",bat,disp);
        mobileDevice.AddCall(DateTime.Now,"0888555236",15);
        mobileDevice.AddCall(DateTime.Now, "0882222222", 100);
        mobileDevice.AddCall(DateTime.Now, "08883333333", 10);
        mobileDevice.AddCall(DateTime.Now, "0888555236", 60);
        mobileDevice.DisplayCalls();
        Console.WriteLine(mobileDevice.PriceCalls(0.60));
        mobileDevice.DeleteCall(10);
        mobileDevice.DisplayCalls();
        mobileDevice.ClearHistory();
        mobileDevice.DisplayCalls();
        Console.WriteLine(Gsm.Iphone4S.GsmModel);
        Console.WriteLine(Gsm.Iphone4S.GsmManufacturer);
    }
}