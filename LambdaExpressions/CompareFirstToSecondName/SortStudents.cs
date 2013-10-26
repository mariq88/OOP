using System;
using System.Linq;

public class SortStudents
{
    public static void Main(string[] args)
    {
        var students = new[]
        {
            new { FirstName = "Petar", LastName = "Petrov" },
            new { FirstName = "Georgi", LastName = "Ivanov" },
            new { FirstName = "Marin", LastName = "Todorov" },
            new { FirstName = "Ognyan", LastName = "Alexandrov" },
            new { FirstName = "Qnica", LastName = "Sotirova" },
            new { FirstName = "Magdalena", LastName = "Borisova" },
            new { FirstName = "Ivelina", LastName = "Amdreeva" },
        };
        var sorted =
                    from st in students
                    where st.FirstName.CompareTo(st.LastName) == -1 //We want to find the students which first name is before its last name alphabetically, so firstName.CompareTo(Second name) should return -1.
                    select (st.FirstName + " " + st.LastName);

        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}