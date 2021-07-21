using EventSubExample.Enums;
using EventSubExample.Models.Subscriptions.ChannelSubscriptions;
using EventSubExample.Services;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Requests
{
    public class ChannelSubscribe : Notification
    {
        private readonly ILogger logger;

        public ChannelSubscribe(ILogger logger)
        {
            this.logger = logger;
        }

        public override void Process(string requestBody)
        {
            ChannelSubscribeNotification Notification = JsonConvert.DeserializeObject<ChannelSubscribeNotification>(requestBody);

            logger.LogInformation($"New subscription from {Notification.Event.UserName} | Channel {Notification.Event.BroadcasterUserName}");

            // do whatever
        }
    }
}
