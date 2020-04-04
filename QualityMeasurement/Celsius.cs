using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
   public class Celsius
    {
        private readonly double celsius;
        public Celsius()
        {
        }

        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }

        public double CheckForEqualValue()
        {
            return this.celsius;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
