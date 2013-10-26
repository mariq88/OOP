//Implement a set of extension methods for IEnumerable<T> 
//that implement the following group functions: sum, product, min, max, average.

using System;
using System.Collections.Generic;
using System.Linq;

public static class ExtensionMethods
{
    public static T Sum<T>(this IEnumerable<T> array) //Calculating the Sum of the elements
    {
        dynamic sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> array) //Calculating the product of the elements
    {
        dynamic product = 1;
        foreach (var number in array)
        {
            product *= number;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> array) //Finding the smallest element in the array
    {
        dynamic min = int.MaxValue;
        foreach (var number in array)
        {
            if (number < min)
            {
                min = number;
            }
        }

        return min;
    }

    public static T Max<T>(this IEnumerable<T> array) //Finding the biggest element in the array
    {
        dynamic max = int.MinValue;
        foreach (var number in array)
        {
            if (number > max)
            {
                max = number;
            }
        }

        return max;
    }

    public static T Average<T>(this IEnumerable<T> array) //Finding the average of the array ((sum of elements)/2)
    {
        dynamic sum = 0;
        dynamic counter = 0;
        foreach (var number in array)
        {
            sum += number;
            counter++;
        }

        return sum / counter;
    }
}