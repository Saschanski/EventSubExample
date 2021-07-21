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
    public class ChannelCheer : Notification
    {
        private readonly ILogger logger;

        public ChannelCheer(ILogger logger)
        {
            this.logger = logger;
        }
        public override void Process(string requestBody)
        {
            ChannelCheerNotification Notification = JsonConvert.DeserializeObject<ChannelCheerNotification>(requestBody);

            if (!Notification.Event.IsAnonymous)
            {
                logger.LogInformation($"New cheer notification from {Notification.Event.UserName}");
            }
            else
            {
                logger.LogInformation($"New cheer notification by an anonymous gifter");
            }

            // do whatever
        }
    }
}
