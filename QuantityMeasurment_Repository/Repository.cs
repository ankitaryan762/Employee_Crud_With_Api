using QuantityMeasurement_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment_Repository
{
   public class Repository:IRepository
    {
        public decimal FeettoInch(Model value)
        {
            return value.Feet * 12;
        }

        public decimal InchToFeet(Model value)
        {
            return value.Inch / 12;
        }

        public decimal GmtoKg(Model value)
        {
            return value.Gram / 1000;
        }

        public decimal MetertoCentimeter(Model value)
        {
            return value.Meter * 100;
        }

        public decimal CentimetertoMeter(Model value)
        {
            return value.Centimeter / 100;
        }

        public decimal KgtoGm(Model value)
        {
            return value.KiloGram * 1000;
        }
    }
}
