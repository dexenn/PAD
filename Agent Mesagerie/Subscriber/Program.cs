using Common;
using System;

namespace Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Subscriber");

            string topic;

            Console.Write("Enter the topic: ");
            topic = Console.ReadLine().ToLower();

            var subscriberScoket = new SubscriberSocket(topic);

            subscriberScoket.Connect(Settings.BROKER_IP, Settings.BROKER_PORT);

            Console.WriteLine("Press any key to exit ...");

            Console.ReadLine();
        }
    }
}
