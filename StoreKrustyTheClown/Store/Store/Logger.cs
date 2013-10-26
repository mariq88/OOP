using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Logger//This is the Singleton pattern, negowata edinstwena instanciq zapiswa message w  tekstow fail, w zawisimost ot podaden ErrorType
    {
        private static Logger instance; //it should have private static field

        private Logger()//also empty constructor,
        { 
        }
        public static Logger Instance()//it should have a  static method which returns the class instance,
        {
            
                if (instance == null)// // check whether initialised, if no it will create new instance
                {
                    instance = new Logger();
                }
                return instance;
            
        }
        public void Log(ErrorType type, string message)//here is the method that write the message of exception if there is one
        {
            StreamWriter writer;            

                if (!File.Exists("ErrorLog.txt"))
                {
                    writer = new StreamWriter("ErrorLog.txt");
                }
                else
                {
                    writer = File.AppendText("ErrorLog.txt");
                }

                // Write to the file:
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(type.ToString());
                writer.WriteLine(message);
                writer.WriteLine();

                writer.Close();

        }
    }
}
