using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shape
{
    abstract class Shape
    {
        private float width;
        private float height;

        public float Width { get; set; }

        public float Height { get; set; }

        //public Shape(int width, int height)
        //{
        //    this.height = height;
        //    this.width = width;
        //}

        public abstract float CalculateSurface();
    }
}