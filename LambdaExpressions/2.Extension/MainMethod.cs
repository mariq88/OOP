//Implement a set of extension methods for IEnumerable<T> 
//that implement the following group functions: sum, product, min, max, average.

using System;
using System.Linq;

public class MainMethod
{
    public static void Main(string[] args)
    {
        int[] array = { 5, 7, 4 };
        Console.WriteLine("The Array is:");
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nThe sum of the elements in the array is: {0}", array.Sum());
        Console.WriteLine("The product of the elements in the array is: {0}", array.Product());
        Console.WriteLine("The smallest element in the array is: {0}", array.Min());
        Console.WriteLine("The biggest element in the array is: {0}", array.Max());
        Console.WriteLine("The average of the array is: {0}", array.Average());
    }
}