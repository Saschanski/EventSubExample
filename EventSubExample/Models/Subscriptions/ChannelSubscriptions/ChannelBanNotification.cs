using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.ban subscription type sends a notification when a viewer is timed out or banned from the specified channel.
    /// Must have channel:moderate scope.
    /// </summary>
    public class ChannelBanNotification
    {
        [JsonProperty("event")]
        public ChannelBanEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelBanSubscription Subscription { get; set; }
    }

    public class ChannelBanSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelBanCondition Condition { get; set; }
    }

    public class ChannelBanCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelBanEvent
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

        [JsonProperty("moderator_user_id")]
        public string ModeratorUserId { get; set; }

        [JsonProperty("moderator_user_login")]
        public string ModeratorUserLogin { get; set; }

        [JsonProperty("moderator_user_name")]
        public string ModeratorUserName { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("ends_at")]
        public string EndsAt { get; set; }

        [JsonProperty("is_permanent")]
        public bool IsPermanent { get; set; }
    }
}
