using QuantityMeasurement_Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Manager
{
    public interface IManager
    {
        decimal FeettoInch(Model value);

        decimal InchToFeet(Model value);

        decimal MetertoCentimeter(Model value);

        decimal CentimetertoMeter(Model value);

        decimal KgtoGm(Model value);

        decimal GmtoKg(Model value);
    }
}
