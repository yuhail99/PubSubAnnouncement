using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSubAnnouncement.Publishers
{
    public class EventArguments
    {
        public object? Data { get; set; }

        public EventArguments(object? data)
        {
            this.Data = data;
        }
    }
}
