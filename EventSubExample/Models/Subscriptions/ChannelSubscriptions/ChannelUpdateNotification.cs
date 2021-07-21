using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.update subscription type sends notifications when a broadcaster updates the category, title, mature flag, or broadcast language for their channel.
    /// No authorization required.
    /// </summary>
    public class ChannelUpdateNotification
    {
        [JsonProperty("event")]
        public ChannelUpdateEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelUpdateSubscription Subscription { get; set; }
    }

    public class ChannelUpdateSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelUpdateCondition Condition { get; set; }
    }

    public class ChannelUpdateEvent
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("is_mature")]
        public bool IsMature { get; set; }
    }

    public class ChannelUpdateCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }
}
