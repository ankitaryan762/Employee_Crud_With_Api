using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
   public class Feet
    {
        private readonly double feet;

        public Feet()
        {
        }

        public Feet(double feet)
        {
            this.feet = feet;
        }

        public double CheckForEqualValue()
        {
            return this.feet;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
