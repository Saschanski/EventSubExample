using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.StreamSubscriptions
{
    /// <summary>
    /// The stream.offline subscription type sends a notification when the specified broadcaster stops a stream.
    /// No authorization required.
    /// </summary>
    public class StreamOfflineNotification
    {
        [JsonProperty("event")]
        public StreamOfflineEvent Event { get; set; }

        [JsonProperty("subscription")]
        public StreamOfflineSubscription Subscription { get; set; }
    }

    public class StreamOfflineSubscription : Subscription
    {
        [JsonProperty("condition")]
        public StreamOfflineCondition Condition { get; set; }
    }

    public class StreamOfflineCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class StreamOfflineEvent
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }
    }
}
