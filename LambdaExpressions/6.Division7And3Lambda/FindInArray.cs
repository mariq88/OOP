//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ. (the 6b!!!)

using System;
using System.Linq;

public class FindInArray
{
    public static void Main(string[] args)
    {
        int[] array = { 7, 1, 2, 3, 4, 5, 21, 50, 105, 120, 315 };
        int[] numsInArray = Array.FindAll(array, numbers => numbers % 21 == 0);  //Using Lambda
        foreach (var numbers in numsInArray)
        {
            Console.WriteLine(numbers);
        }
    }
}