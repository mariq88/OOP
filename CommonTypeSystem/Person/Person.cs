
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private string name;
        private int? age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name field can't be empty ot less than 3 characters");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Person(string name)
            : this(name, null)
        {

        }
    
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return string.Format("Name of the person:{0,15} Age:{1,3}", this.Name,
                ((this.Age.ToString() != "") ? this.Age.ToString() : "Not Specified"));
        }
    }
}
