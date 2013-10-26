using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryAPI
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        public Circle(Vector3D center, double radius) : base(center)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public Vector3D GetNormal()
        {
            return new Vector3D(0, 0, 1);
        }

        public override double GetPrimaryMeasure()
        {
            return GetArea();
        }

        public double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}