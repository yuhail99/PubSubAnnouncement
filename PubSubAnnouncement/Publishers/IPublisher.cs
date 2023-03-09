using PubSubAnnouncement.Subscribers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PubSubAnnouncement.Publishers.Publisher;

namespace PubSubAnnouncement.Publishers
{
    public interface IPublisher
    {
        event Notify NotifySubscriber;
        void Publish(string value);
        void CreateLoserSubscriber(int key, ISubscriber subscriber);
        void CreateWinnerSubscriber(int key, ISubscriber subscriber);

    }
}
