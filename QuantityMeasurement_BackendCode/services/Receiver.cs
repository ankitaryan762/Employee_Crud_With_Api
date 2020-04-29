using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurement_BackendCode.services
{
 
    /// <summary>
    /// This is the receiver
    /// </summary>
    class Receiver
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public void main(string[] args)
        {
            MessageQueue MyQueue = null;
            try
            {
                Console.WriteLine("Your message Here");

                MyQueue = new MessageQueue(@".\Private$\quantityMeasurement");
                Message[] messages = MyQueue.GetAllMessages();
                if (messages.Length > 0)
                {
                    foreach (Message m in messages)
                    {
                        m.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                        string message = m.Body.ToString();

                        Console.WriteLine(message);
                        MyQueue.Receive();
                    }
                }
                else
                {
                    Console.WriteLine("No New Messages in Message Queue");
                }

                MyQueue.Refresh();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MyQueue.Close();
            }

        }
    }
}
