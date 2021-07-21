using EventSubExample.Enums;
using EventSubExample.Requests;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Services
{
    public interface IEventSubService
    {
        Dictionary<SubscriptionType, Notification> Requests { get; set; }

        void ProcessRequest(SubscriptionType subscriptionType, string requestBody);
    }

    public class EventSubService : IEventSubService
    {

        public Dictionary<SubscriptionType, Notification> Requests { get; set; }

        private readonly ILogger _logger;

        public EventSubService(ILogger<EventSubService> logger)
        {
            _logger = logger;

            Requests = new Dictionary<SubscriptionType, Notification>();

            Requests.Add(SubscriptionType.ChannelFollow, new ChannelFollow(_logger));
            Requests.Add(SubscriptionType.ChannelCheer, new ChannelCheer(_logger));
            Requests.Add(SubscriptionType.ChannelSubscribe, new ChannelSubscribe(_logger));

            _logger.LogInformation($"EventSub Service loaded {Requests.Count} commands");
        }

        public void ProcessRequest(SubscriptionType subscriptionType, string requestBody)
        {
            try
            {
                Task.Run(() => { Requests[subscriptionType].Process(requestBody); });
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Failed processing request");
            }
        }
    }

    public abstract class Notification
    {
        public abstract void Process(string requestBody);
    }
}
