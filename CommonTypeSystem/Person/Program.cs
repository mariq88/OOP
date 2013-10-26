using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Ivan Ivanoc", 20);
            Person secondPerson = new Person("Pesho Petrov");
            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
