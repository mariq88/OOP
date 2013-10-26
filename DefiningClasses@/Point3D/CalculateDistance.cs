using System;
using System.Linq;

namespace Point3D
{
    public static class CalculateDistance
    {
        public static double Distance(Point delta1, Point delta2)
        {
            double result = Math.Sqrt(Math.Pow(delta1.X - delta2.X, 2) + Math.Pow(delta1.Y - delta2.Y, 2) + Math.Pow(delta1.Z - delta2.Z, 2));
            return result;
        }
    }
}