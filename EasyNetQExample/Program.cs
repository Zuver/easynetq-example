using EasyNetQ;
using EasyNetQExample.Messages;

namespace EasyNetQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // In a "real" application, the connection string would be in an application config file or something
            IBus bus = RabbitHutch.CreateBus("host=localhost");

            // Construct message that will be queued
            TextMessage textMessage = new TextMessage
            {
                Value = "Hello world!"
            };

            // Queue message
            bus.Publish(textMessage);
        }
    }
}
