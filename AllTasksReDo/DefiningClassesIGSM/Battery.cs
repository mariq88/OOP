using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesIGSM
{
    class Battery
    {
        private BatteryType bType;
        private string model;
        private double hoursTalk;
        private double hoursIdle;
     
        public Battery(string model, double hoursTalk, double hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model) : this(model, 0, 0)
        {
        }

        public string Model ////problem 5
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public enum BatteryType
        {
            NiMh,
            LiIon,
            NiCd,
        }
        public BatteryType BType
        {
            get
            {
                return this.bType;
            }
        }
    }
}