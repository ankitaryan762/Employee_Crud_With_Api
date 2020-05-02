using QuantityMeasurement_BackendCode.services;
using QuantityMeasurement_Model;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurment_Repository
{
   public class Repository:IRepository
    {

        Redis redis = new Redis();
        public decimal FeettoInch(Model value)
        {
            decimal result = value.Feet * 12;
            redis.RedisConnection($"inch", result.ToString());
            return result;
        }

        public decimal InchToFeet(Model value)
        {
            decimal result = value.Inch / 12;
            redis.RedisConnection($"feet", result.ToString());
            return result;
        }

        public decimal GmtoKg(Model value)
        {
            decimal result = value.Gram / 1000;
            redis.RedisConnection($"kg", result.ToString());
            return result;
        }

        public decimal MetertoCentimeter(Model value)
        {
            decimal result = value.Meter * 100;
            redis.RedisConnection($"centimeter", result.ToString());
            return result;
        }

        public decimal CentimetertoMeter(Model value)
        {
            decimal result = value.Centimeter / 100;
            redis.RedisConnection($"meter", result.ToString());
            return result;
           
        }

        public decimal KgtoGm(Model value)
        {
            decimal result = value.KiloGram * 1000;
            redis.RedisConnection($"gram", result.ToString());
            return result;
        }
    }
}
