using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shape
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[3];
            shape[0] = new Rectangle(5.5f, 7);
            shape[1] = new Circle(3);
            shape[2] = new Triangle(8.7f, 4);

            //I prefer the implementation with the list, that is commented below, but in the task it's said that it should be in array :(
            
            //List<Shape> shapes = new List<Shape>()
            //{
            //    new Rectangle(5.5f,7),
            //    new Circle(3),
            //    new Triangle(8.7f,4),
            //};
            foreach (var item in shape)
            {
                float surface = item.CalculateSurface();
                Console.WriteLine("The surface of the {0} is: {1}", item.GetType().Name, surface);
            }
        }
    }
}