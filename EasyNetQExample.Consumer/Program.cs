using System;
using EasyNetQ;
using EasyNetQExample.Messages;

namespace EasyNetQExample.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            // In a "real" application, the connection string would be in an application config file instead of hard-coded
            IBus bus = RabbitHutch.CreateBus("host=localhost");

            // Subscribe to a message of type TextMessage and provide the action to take when a message is received
            bus.Subscribe<TextMessage>(String.Empty, ProcessMessage);
        }

        static void ProcessMessage(TextMessage textMessage)
        {
            // You can save to a database or do whatever you wish with the message here
            Console.WriteLine(textMessage);
        }
    }
}
