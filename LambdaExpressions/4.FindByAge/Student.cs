//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

using System;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string SecondName { get; set; }

    public uint Age { get; set; }

    public Student(string firstName, string secondName, uint age)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.Age = age;
    }
}