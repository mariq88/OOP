using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Course : ICourse
    {
        private List<string> topics = new List<string>();

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public List<string> Topics
        {
            get
            {
                return this.topics;
            }
            set
            {
                this.topics = value;
            }
        }

        public void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public override string ToString()
        {
            bool isLocalCourse = true;
            StringBuilder courseResult = new StringBuilder();
            
            courseResult.Append(Name.GetType().Name + ": ");
            courseResult.Append("Name=" + this.Name);
            courseResult.Append(";");
            if (Teacher.Name != null)
            {
                courseResult.Append("Teacher=" + Teacher.Name);
                courseResult.Append(";");
            }
            courseResult.Append("Topics=[");
            foreach (var topic in Topics)
            {
                courseResult.Append(topic);
            }
            courseResult.Append("]");
            courseResult.Append(";");
                 
            return courseResult.ToString();
        }
    }
}