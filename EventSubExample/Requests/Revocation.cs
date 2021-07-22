using EventSubExample.Models.Revocation;
using EventSubExample.Services;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Requests
{
    public class Revocation : Notification
    {
        private readonly ILogger logger;

        public Revocation(ILogger logger)
        {
            this.logger = logger;
        }

        public override void Process(string requestBody)
        {
            RevocationCallback Revocation = JsonConvert.DeserializeObject<RevocationCallback>(requestBody);

            logger.LogInformation($"Subscription Revocation {Revocation.Subscription.Type} | Channel {Revocation.Subscription.Condition.BroadcasterUserId}");

            // do whatever
        }
    }
}
