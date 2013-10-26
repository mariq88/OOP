using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student("Ivan","Ivanov","Ivanov",1520,"Sofia,Bulgaria","0888888888","ivan@ivan.bg",5,University.NBU,Faculty.Unknown,Specialty.WebDesign);

            Console.WriteLine("Original:" + first);

            Student cloned = first.Clone();

            Console.WriteLine("Cloned:{0}", cloned);

            Console.WriteLine("First and Cloned are the same students: {0}", first.Equals(cloned));

            Console.WriteLine(new string('-', 50));

            cloned.SSN = 2323;
            Console.WriteLine("Cloned :{0} with changed SSN", cloned);
            Console.WriteLine("Original of the cloned {0}", first);

            Console.WriteLine("First and Cloned are the same students after the change of SSN of cloned: {0}", first.Equals(cloned));
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Other three students:");
            Student second = new Student("Peter", "petrov", "Petrov", 1010, "Varna,Bulgaria", "08654987", "pesho@abv.bg",1, University.SU, Faculty.BilogyFac, Specialty.Biology);
            Console.WriteLine(second);
            Student third = new Student("Marin", "Marinov", "Marinov", 6051, "Pleven,Bulgaria", "0898456872", "mmm@gmail.com", 3, University.TUSofia, Faculty.KST, Specialty.ComputerScience);
            Console.WriteLine(third);
            Student fourth = new Student("Ivanka", "Ivanova", "Ivanova", 2598, "Plovdiv,Bulgaria", "09658749", "ivanka@abv.bg",4, University.UNSS, Faculty.Unknown, Specialty.Finances);
            Console.WriteLine(fourth);

            List<Student> sortedStudents = new List<Student>();
            sortedStudents.Add(first);
            sortedStudents.Add(second);
            sortedStudents.Add(cloned);
            sortedStudents.Add(third);
            sortedStudents.Add(fourth);

            sortedStudents.Sort();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("The sorted students are:");

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
