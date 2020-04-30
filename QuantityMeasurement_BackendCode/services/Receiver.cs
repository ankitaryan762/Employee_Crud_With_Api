using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurement_BackendCode.services
{
 
    /// <summary>
    /// This is the receiver
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>


        public void ReceiveMessage()
        {
            MessageQueue messageQueue = null;
            string path = @".\Private$\quantityMeasurement";
            try
            {
                messageQueue = new MessageQueue(path);
                Message[] message = messageQueue.GetAllMessages();
                if (message.Length > 0)
                {
                    foreach (Message msg in message)
                    {
                        msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string result = msg.Body.ToString();
                        messageQueue.Receive();
                        File.WriteAllText(@"E:\Backup\source\repos\QuantityMeasurementBackendProject\QuantityMeasurement_BackendCode\services\ReceviedMessage.txt", result);
                    }
                    messageQueue.Refresh();
                }
                else
                {
                    Console.WriteLine("Yet,there is not any Message present ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
