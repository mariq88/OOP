//Using the extension methods OrderBy() and ThenBy() with lambda expressions 
//sort the students by first name and last name in descending order. Rewrite the same with LINQ.(the 5b task!!!)

using System;
using System.Linq;

public class SortingStudents
{
    public static void Main(string[] args)
    {
        var students = new[]
        {
            new { firstName = "Ivan", surname = "Marinov", age = 15 },
            new { firstName = "Mihail", surname = "Delev", age = 28 },
            new { firstName = "Tom", surname = "Jerry", age = 23 },
            new { firstName = "Hitur", surname = "Petur", age = 10 },
            new { firstName = "Piff", surname = "Hercule", age = 19 },
        };
        //Linq expression
        var sortedClass = from student in students orderby student.firstName descending, student.surname descending select student;
        foreach (var student in sortedClass)
        {
            Console.WriteLine("{0} {1}", student.firstName, student.surname);
        }
    }
}