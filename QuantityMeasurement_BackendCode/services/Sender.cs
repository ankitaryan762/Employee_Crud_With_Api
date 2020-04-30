using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurement_BackendCode.services
{
  
    /// <summary>
    /// Sender in MSMQ
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void SendMessage(string message, decimal number)
        {
            MessageQueue messageQueue = null;
        
            string path = @".\Private$\quantityMeasurement";

            try
            {
                if (MessageQueue.Exists(path))
                {
                    messageQueue = new MessageQueue(path);
                }
                else
                {
                    MessageQueue.Create(path);
                    messageQueue = new MessageQueue(path);
                }
                string result = message + " : "+ number;
                messageQueue.Send(result);
               
            }
            catch
            {
                throw;
            }

        }
    }
}
