using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.StreamSubscriptions
{
    /// <summary>
    /// The stream.online subscription type sends a notification when the specified broadcaster starts a stream.
    /// No authorization required.
    /// </summary>
    public class StreamOnlineNotification
    {
        [JsonProperty("event")]
        public StreamOnlineEvent Event { get; set; }

        [JsonProperty("subscription")]
        public StreamOnlineSubscription Subscription { get; set; }
    }

    public class StreamOnlineSubscription : Subscription
    {
        [JsonProperty("condition")]
        public StreamOnlineCondition Condition { get; set; }
    }

    public class StreamOnlineCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class StreamOnlineEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; }
    }
}
