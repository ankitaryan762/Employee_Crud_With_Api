using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
   public class TemparetureConversion
    {
        public double tempareture;
        public string type;
        public TemparetureConversion()
        { 
        }
        public TemparetureConversion(string type, double tempareture)
        {
            this.tempareture = tempareture;
            this.type = type;
        }

        public TemparetureConversion(string type)
        {
            this.type = type;
        }

        public double CheckForEqualValue()
        {
            return this.tempareture;
        }

        public double ConvertCelsiusToFarenheit()
        {
            return 32 * tempareture;
        }

        public double ConvertFarenheitToCelsius() 
        {
            return ((double)9 / 5 * tempareture) + 32;

        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
