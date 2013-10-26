using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesIGSM
{
    class Display
    {
        private double size;
        private int numberOfColours;

        public Display(double size, int numberOfcolours)
        {
            this.Size = size;
            this.NumberofColours = numberOfcolours;
        }

        public Display() : this(0, 0)
        {
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int NumberofColours
        {
            get
            {
                return this.numberOfColours;
            }
            set
            {
                this.numberOfColours = value;
            }
        }
    }
}