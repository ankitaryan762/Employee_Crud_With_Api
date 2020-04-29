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
        public void main(string[] args)
        {
            Console.WriteLine("Enter Message");
            string MessageToSend = Console.ReadLine();
            MessageQueue MyQueue = null;
            try
            {
                if (MessageQueue.Exists(@".\Private$\quantityMeasurement"))
                {
                    MyQueue = new MessageQueue(@".\Private$\quantityMeasurement");
                }
                else
                {
                    MyQueue = MessageQueue.Create(@".\Private$\quantityMeasurement");
                }

                MyQueue.Label = "This is the test Queue";
                MyQueue.Send(MessageToSend, "IDG");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MyQueue.Dispose();
                Console.WriteLine("Press 1 for send again");
                int selection;
                bool success = int.TryParse(Console.ReadLine(), out selection);
                if (success)
                {
                    if (selection == 1)
                    {
                        main(new String[0]);
                    }
                }
            }
        }
    }
}
