using QuantityMeasurement_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment_Repository
{
   public interface IRepository
    {
        decimal FeettoInch(Model value);

        decimal InchToFeet(Model value);

        decimal MetertoCentimeter(Model value);

        decimal CentimetertoMeter(Model value);

        decimal KgtoGm(Model value);

        decimal GmtoKg(Model value);

    }
}
