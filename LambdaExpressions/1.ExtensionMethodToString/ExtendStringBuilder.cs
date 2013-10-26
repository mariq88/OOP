//Implement an extension method Substring(int index, int length) 
//for the class StringBuilder that returns new StringBuilder and has 
//the same functionality as Substring in the class String.

using System;
using System.Linq;
using System.Text;

public static class ExtendStringBuilder
{
    //Because there are 2 ways to implement the Substring Method 
    public static StringBuilder Substring(this StringBuilder str, int index, int length) //this is the first with the parameters given in the task
    {
        StringBuilder sb = new StringBuilder(); //I always name the stringbuilder sb.It's clear that is a StringBuilder, and it's a short way to write it down.
        if (index < 0 || index >= str.Length || index + length > str.Length)
        {
            throw new IndexOutOfRangeException("The index is larger than the number of characters in the substring");
        }

        for (int i = index; i < index + length; i++)
        {
            sb.Append(str[i]);
        }
           
        return sb;
    }

    public static StringBuilder Substring(this StringBuilder str, int index) //And this is the second implementation
    {
        if (index < 0 || index > str.Length - 1)
        {
            throw new IndexOutOfRangeException("The index must not be negative and smaller than the number of chars in the substring!");
        }

        StringBuilder sb = new StringBuilder();
        sb.Append(sb.ToString().Substring(index));
        return sb;
    }
}