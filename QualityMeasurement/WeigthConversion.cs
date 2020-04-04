using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class WeigthConversion
    {
        public double weigth;
        public string type;
        public WeigthConversion() { 
        }
        public WeigthConversion(string type,double weigth)
        {
            this.weigth = weigth;
            this.type = type;
        }

        public WeigthConversion(string type)
        {
            this.type = type;
        }

        public double CheckForEqualValue()
        {
            return this.weigth;
        }

        public double ConvertKiloGramTo_Gram()
        {
            return 1000 * weigth;
        }

        public double ConvertGramToKilogram()
        {
            return weigth / 1000;
        }
    }
}
