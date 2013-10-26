//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Student[] firstClass =
        {
            new Student("Ivan", "Marinov", 15),
            new Student("Mihail", "Delev", 28),
            new Student("Tom", "Jerry", 23),
            new Student("Hitur", "Petur", 10),
            new Student("Piff", "Hercule", 19),
        };
        var sortedClass =
                         from student in firstClass
                         where student.Age >= 18 && student.Age <= 24
                         select student;

        foreach (var student in sortedClass)
        {
            Console.WriteLine("{0} {1} {2}", student.FirstName, student.SecondName, student.Age);
        }
    }
}