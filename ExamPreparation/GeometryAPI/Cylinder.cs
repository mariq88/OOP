using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryAPI
{
    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        public Cylinder(Vector3D top, Vector3D bottom, double radius) : base(top,bottom)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }

        public double GetArea()
        {
            double baseArea = BaseArea();
            double topAndBaseArea = baseArea * 2;
            double height = GetHeight();
            double basePerimeter = 2 * Math.PI * Radius;
            double sightArea = basePerimeter * height;
            return topAndBaseArea + sightArea;
        }

        private double BaseArea()
        {
            double baseArea = Math.PI * this.Radius * this.Radius;
            return baseArea;
        }

        private double GetHeight()
        {
            double height = (this.vertices[0] - this.vertices[1]).Magnitude;
            return height;
        }

        public double GetVolume()
        {
            return this.BaseArea() * this.GetHeight();
        }
    }
}