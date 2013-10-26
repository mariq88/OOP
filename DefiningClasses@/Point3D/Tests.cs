using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Tests
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point(10, 10, 10);
            Point secondPoint = new Point(5, 5, 5);
            Console.WriteLine("The start Point of the coordinate system has coordinates: {0}", Point.startCoordinates);
            Console.WriteLine("The distance between first point {0}\n and second point {1}\nis: {2}", firstPoint, secondPoint, CalculateDistance.Distance(firstPoint, secondPoint));
            Path testPath = new Path();
            testPath.AddPoints(firstPoint);
            testPath.AddPoints(secondPoint);
            PathStorage.SavePath(testPath);
            testPath.AddPoints(new Point(20, 30, 50));
            testPath.AddPoints(new Point(-50,20,10));
            PathStorage.SavePath(testPath);
            PathStorage.LoadPath();

        }
    }
}
