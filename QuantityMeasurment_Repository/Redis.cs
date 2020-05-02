using QuantityMeasurement_Model;
using QuantityMeasurment_Repository;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantityMeasurement_BackendCode.services
{
    public class RedisImplementation
    {
        public void RedisConnection(string key,string value)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();

            data.StringSet(key,value);
            data.StringGet(key);
        }

        public void Redis(string key)
        {
            var redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            IDatabase data = redis.GetDatabase();
            data.StringGet(key);
        }

    }
}
