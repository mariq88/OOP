using System;
using System.Linq;

namespace _3.Exceptions
{
    class MainClass
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            InvalidRangeException<int> exception =
                new InvalidRangeException<int>("The number must be between 1 and 100", 1, 100);
            Console.WriteLine("Enter a number from 0 do 100:");
            
            int number = int.Parse(Console.ReadLine());
            if (number < exception.Start || number > exception.End)
            {
                throw exception;
            }
            string startDate = "1/1/1980";
            string endDate = "1/1/2014";
            InvalidRangeException<DateTime> someDateExpection =
                new InvalidRangeException<DateTime>("The date must be from the period [1/1/1980 … 31/12/2013]",
                    DateTime.Parse(startDate), DateTime.Parse(endDate));
            Console.WriteLine("Enter a date in the specified format: d/m/yyyy!(from 1980 to 2013)");
            string date = Console.ReadLine();
            DateTime someDate = DateTime.Parse(date);
            if (someDate.Year < someDateExpection.Start.Year || someDate.Year > someDateExpection.End.Year)
            {
                throw someDateExpection;
            }
        }
    }
}