using PubSubAnnouncement.Publishers;
using PubSubAnnouncement.Subscribers;

namespace PubSubAnnouncement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter winner name:");
            string winners = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter loser name:");
            string losers = Console.ReadLine();
            Console.WriteLine();

            var publisher = new Publisher();

            if (!string.IsNullOrWhiteSpace(winners) && !string.IsNullOrWhiteSpace(losers))
            {
                //subscribe
                int i = 0;
                var winnerNames = winners.Split(",");

                foreach (var name in winnerNames)
                {
                    publisher.CreateWinnerSubscriber(i++, new Subscriber(name));
                }

                int j = 0;
                var loserNames = losers.Split(",");

                foreach (var name in loserNames)
                {
                    publisher.CreateLoserSubscriber(j++, new Subscriber(name));
                }

                //publish
                Console.WriteLine("Enter description of announcement to publish data.");
                string line = Console.ReadLine();
                Console.WriteLine();
                publisher.Publish(line);
            }
            else
            {
                Console.WriteLine("Please enter all details");
            }

            Console.ReadLine();
        }
    }
}