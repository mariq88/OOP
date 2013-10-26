using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shape
{
    class Circle : Shape
    {
        public Circle(float radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Width and height must be positive numbers");
            }
            else
            {
                this.Width = radius;
                this.Height = radius;
            }
        }

        public override float CalculateSurface()
        {
            return (float)Math.PI * this.Height * this.Height ;
        }
    }
}