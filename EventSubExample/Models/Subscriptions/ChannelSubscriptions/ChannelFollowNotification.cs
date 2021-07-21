using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.follow subscription type sends a notification when a specified channel receives a follow.
    /// No authorization required.
    /// </summary>
    public class ChannelFollowNotification
    {
        [JsonProperty("event")]
        public ChannelFollowEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelFollowSubscription Subscription { get; set; }
    }

    public class ChannelFollowSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelFollowCondition Condition { get; set; }
    }

    public class ChannelFollowCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelFollowEvent
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("followed_at")]
        public string FollowedAt { get; set; }
    }
}
