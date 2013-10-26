using System;
using System.Linq;
using System.Text;

public class MainMethod
{
   public static void Main(string[] args)
    {
 //Testing the code. The first number is the start index and the second is how much chars we should extract.
        StringBuilder someTest = new StringBuilder();
        someTest.AppendLine("Just Trying the code");
        Console.WriteLine(someTest.Substring(5, 5).ToString());
        Console.WriteLine(someTest.Substring(0, 5).ToString());
        Console.WriteLine(someTest.Substring(19, 1).ToString());
    }
}
