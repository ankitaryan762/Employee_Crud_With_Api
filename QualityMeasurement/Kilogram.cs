using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class Kilogram
    {
        private readonly double kilogram;
        public Kilogram()
        {
        }

        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }

        public double CheckForEqualValue()
        {
            return this.kilogram;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
