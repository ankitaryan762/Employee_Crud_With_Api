using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
   public class Inch
    {
        private readonly double inch;

        public Inch()
        {
        }

        public Inch(double inch)
        {
            this.inch = inch;
        }
        public double CheckForEqualValue()
        {
            return this.inch;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
