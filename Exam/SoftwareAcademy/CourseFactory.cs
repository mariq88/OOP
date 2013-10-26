using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class CourseFactory : ICourseFactory
    {
       
        public ITeacher CreateTeacher(string name)
        {
            ITeacher teacher = new Teacher();
            teacher.Name = name;
            return teacher;
        
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse localCourse = new LocalCourse();
            localCourse.Name = name;
            localCourse.Lab = lab;
            localCourse.Teacher = teacher;
            return localCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse offsiteCourse = new OffsiteCourse();
            offsiteCourse.Name = name;
            offsiteCourse.Teacher = teacher;
            offsiteCourse.Town = town;
            return offsiteCourse;
        }
    }
}
