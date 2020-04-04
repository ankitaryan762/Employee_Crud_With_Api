using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
   public class Gram
    {
        private readonly double gram;

        public Gram()
        {
        }

        public Gram(double gram)
        {
            this.gram = gram;
        }

        public double CheckForEqualValue()
        {
            return this.gram;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
