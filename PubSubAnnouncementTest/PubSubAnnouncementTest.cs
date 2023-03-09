using NUnit.Framework;
using PubSubAnnouncement.Publishers;
using PubSubAnnouncement.Subscribers;

namespace PubSubAnnouncementTest
{
    [TestFixture]
    public class Tests
    {
        private IPublisher Publisher { get; set; }

        [SetUp]
        public void Setup()
        {
            Publisher = new Publisher();
        }

        [Test]
        public void TestCreateWinnerSubscriber()
        {
            try
            {
                Publisher.CreateWinnerSubscriber(1, new Subscriber("Subscriber"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestCreateLoserSubscriber()
        {
            try
            {
                Publisher.CreateLoserSubscriber(1, new Subscriber("Subscriber"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestDisplayDataWinner_OneSubscriber()
        {
            try
            {
                var subscriber = new Subscriber("Subscriber");
                var publisher = new Publisher();
                var subscribersWinner = new Dictionary<int, ISubscriber> {{ 0, subscriber }};
                publisher.SubscribersWinner = subscribersWinner;

                subscriber.DisplayDataWinner(publisher, new EventArguments("Announcement"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestDisplayDataWinner_ManySubscriber()
        {
            try
            {
                var subscriber = new Subscriber("Subscriber");
                var publisher = new Publisher();
                var subscribersWinner = new Dictionary<int, ISubscriber> { { 0, subscriber }, {1, subscriber } };
                publisher.SubscribersWinner = subscribersWinner;

                subscriber.DisplayDataWinner(publisher, new EventArguments("Announcement"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestDisplayDataLoser_OneSubscriber()
        {
            try
            {
                var subscriber = new Subscriber("Subscriber");
                var publisher = new Publisher();
                var subscribersLoser = new Dictionary<int, ISubscriber> { { 0, subscriber } };
                publisher.SubscribersLoser = subscribersLoser;

                subscriber.DisplayDataLoser(publisher, new EventArguments("Announcement"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [Test]
        public void TestDisplayDataLoser_ManySubscriber()
        {
            try
            {
                var subscriber = new Subscriber("Subscriber");
                var publisher = new Publisher();
                var subscribersLoser = new Dictionary<int, ISubscriber> { { 0, subscriber }, { 1, subscriber } };
                publisher.SubscribersLoser = subscribersLoser;

                subscriber.DisplayDataWinner(publisher, new EventArguments("Announcement"));
                return;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}