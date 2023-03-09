using PubSubAnnouncement.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubAnnouncement.Subscribers
{
    public interface ISubscriber
    {
        void DisplayDataWinner(object sender, EventArguments args);
        void DisplayDataLoser(object sender, EventArguments args);
    }
}
