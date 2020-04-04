using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class Fahrenheit
    {
        private readonly double fahrenheit;
        public Fahrenheit()
        {
        }

        public Fahrenheit(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }

        public double CheckForEqualValue()
        {
            return this.fahrenheit;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
