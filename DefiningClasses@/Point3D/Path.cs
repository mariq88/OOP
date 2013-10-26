using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        public readonly List<Point> PointsHolder = new List<Point>();
        public List<Point> Paths
        {
            get { return this.PointsHolder; }
        }

        public void AddPoints(Point newPoint)
        {
            PointsHolder.Add(newPoint);
        }

    }
}
