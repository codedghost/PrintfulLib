using System;
using CoreCodedChatbot.Printful.ExternalClients;

namespace TestHarness
{
    /// <summary>
    /// This is a test harness used to demonstrate Printful Client usage and to test usage
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // It is recommended to wrap the Client creation in a Factory class for DI purposes
            var client = new PrintfulClient("INSERT-API-KEY");

            var keepRunning = true;

            while (keepRunning)
            {
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                }
            }
        }
    }
}
