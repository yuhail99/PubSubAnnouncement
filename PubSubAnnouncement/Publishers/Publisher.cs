using PubSubAnnouncement.Subscribers;

namespace PubSubAnnouncement.Publishers
{
    public class Publisher : IPublisher
    {
        public Dictionary<int, ISubscriber> SubscribersWinner { get; set; } = new Dictionary<int, ISubscriber>();
        public Dictionary<int, ISubscriber> SubscribersLoser { get; set; } = new Dictionary<int, ISubscriber>();

        public delegate void Notify(object sender, EventArguments e);

        public event Notify NotifySubscriber;

        public void Publish(string value)
        {
            NotifySubscriber(this, new EventArguments(value));
        }

        public void CreateLoserSubscriber(int key, ISubscriber iSubscriber)
        {
            SubscribersLoser.Add(key, iSubscriber);
            NotifySubscriber += iSubscriber.DisplayDataLoser;
        }

        public void CreateWinnerSubscriber(int key, ISubscriber iSubscriber)
        {
            SubscribersWinner.Add(key, iSubscriber);
            NotifySubscriber += iSubscriber.DisplayDataWinner;
        }
    }
}
