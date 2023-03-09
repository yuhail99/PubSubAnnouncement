using PubSubAnnouncement.Publishers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PubSubAnnouncement.Subscribers
{
   public class Subscriber :ISubscriber
    {
        public string SubsciberName { get; set; }
        public Subscriber(string subscriberName)
        {
            this.SubsciberName = subscriberName; 
        }

        public void DisplayDataWinner(object sender, EventArguments e)
        {
            Publisher publisher = (Publisher)sender;

            Console.WriteLine($"{e.Data}");
            if (publisher.SubscribersWinner.Count() == 1)
            {
                if (this.SubsciberName != null)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Hi {this.SubsciberName}: congratulations your are the winner!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Hi All: congratulations your are the winner!");
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        public void DisplayDataLoser(object sender, EventArguments e)
        {
            Publisher publisher = (Publisher)sender;

            Console.WriteLine($"{e.Data}.");

            if (publisher.SubscribersLoser.Count() == 1)
            {
                if (this.SubsciberName != null)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Hi {this.SubsciberName}: you just lost the game. Please try again.");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Hi All: you just lost the game. Please try again.");
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}
