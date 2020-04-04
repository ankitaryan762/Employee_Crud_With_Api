using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class LengthConversion
    {
        public double length;
        public string type;
        public LengthConversion()
        { }
        public LengthConversion(string type,double length)
        {
            this.length = length;
            this.type = type;
        }

        public LengthConversion(string type)
        {
            this.type = type;
        }

        public double CheckForEqualValue()
        {
            return this.length;
        }

        public double ConvertFeetToInch()
        {
            return 12 * length;
        }

        public double ConvertInchToFeet()
        {
            return length/12;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
