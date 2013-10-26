using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shape
{
    class Triangle : Shape
    {
        public Triangle(float width, float height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentOutOfRangeException("Width and height must be positive numbers");
            }
            else
            {
                this.Width = width;
                this.Height = height;
            }
        }

        public override float CalculateSurface()
        {
            return (this.Width / 2) * this.Height;
        }
    }
}