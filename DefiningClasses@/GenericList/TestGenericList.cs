using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class TestGenericList
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>(5);
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.InsertAtPosition(15,2);
            Console.WriteLine(intList.Count);
            for (int i = 0; i < intList.Count; i++)
            {
                int element = intList[i];
                Console.WriteLine(element);
            }
            //GenericList<string> stringList = new GenericList<string>();
            //stringList.Add("Pesho");
            //stringList.Add("Ivan");
            //stringList.Add("String");
            //Console.WriteLine(stringList.Count);
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    string element = stringList[i];
            //    Console.WriteLine(element);
            //}
        }


    }
}
