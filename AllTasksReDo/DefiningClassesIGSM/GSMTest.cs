using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesIGSM
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] mp = new GSM[3];
            GSM mobilePhone1 = new GSM("Xperia Arc", "Sony", 999, "Maria");
            mp[0] = mobilePhone1;
            GSM mobilePhone2 = new GSM("Optimus L5", "LG");
            mp[1] = mobilePhone2;
            GSM mobilePhone3 = new GSM("Lumia 820", "Nokia");
            mp[2] = mobilePhone3;
            Display display = new Display();
           // Battery battery = new Battery(Battery.BatteryType.LiIon.ToString(),10,60);

            for (int i = 0; i < mp.Length; i++)
            {
                Console.WriteLine(mp[i]);
            }
        }
    }
}
