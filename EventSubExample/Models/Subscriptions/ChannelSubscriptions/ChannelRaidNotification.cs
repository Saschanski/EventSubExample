using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.raid subscription type sends a notification when a broadcaster raids another broadcaster’s channel.
    /// No authorization required.
    /// </summary>
    public class ChannelRaidNotification
    {
        [JsonProperty("event")]
        public ChannelRaidEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelRaidSubscription Subscription { get; set; }
    }

    public class ChannelRaidSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelRaidCondition Condition { get; set; }
    }

    public class ChannelRaidCondition
    {
        /// <summary>
        /// Could provide from_broadcaster_user_id instead.
        /// (This commment is straight from TwitchDocs. Seems like a TODO slipped through? Also this is the only time from_broadcaster_user_id is used.)
        /// </summary>
        [JsonProperty("to_broadcaster_user_id")]
        public string ToBroadcasterUserId { get; set; }
    }

    public class ChannelRaidEvent
    {
        [JsonProperty("from_broadcaster_user_id")]
        public string FromBroadcasterUserId { get; set; }

        [JsonProperty("from_broadcaster_user_login")]
        public string FromBroadcasterUserLogin { get; set; }

        [JsonProperty("from_broadcaster_user_name")]
        public string FromBroadcasterUserName { get; set; }

        [JsonProperty("to_broadcaster_user_id")]
        public string ToBroadcasterUserId { get; set; }

        [JsonProperty("to_broadcaster_user_login")]
        public string ToBroadcasterUserLogin { get; set; }

        [JsonProperty("to_broadcaster_user_name")]
        public string ToBroadcasterUserName { get; set; }

        [JsonProperty("viewers")]
        public int Viewers { get; set; }
    }
}
