using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        public IList<ICourse> Courses = new List<ICourse>();

        public string Name { get; set; }

        

        public void AddCourse(ICourse course)
        {
            Courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Teacher: Name");
            result.Append('=');
            result.Append(this.Name);
            if (this.Courses.Count() > 0)
            {
                foreach (var course in Courses)
                {
                    result.Append(course);
                }
                
            }
           
            return result.ToString();
        }
    }
}