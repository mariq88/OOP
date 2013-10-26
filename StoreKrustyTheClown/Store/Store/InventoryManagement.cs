using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class InventoryManagement
    {
        //inventory management- the idea is to define actions based on some Inventory properties
       
        public static void AlmostEmptyInventoryAction()
        {
            Console.WriteLine("Issue order to buy 5 items of this product!");
        }

        public static void EmptyInventoryAction()
        {
            Console.WriteLine("Issue URGENT order to buy 10 items of this product!");

        }
    }
}
