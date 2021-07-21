using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.subscription.gift subscription type sends a notification when a user gives one or more gifted subscriptions in a channel.
    /// Must have channel:read:subscriptions scope.
    /// </summary>
    public class ChannelSubscriptionGiftNotification
    {
        [JsonProperty("event")]
        public ChannelSubscriptionGiftEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelSubscriptionGiftSubscription Subscription { get; set; }
    }

    public class ChannelSubscriptionGiftSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelSubscriptionGiftCondition Condition { get; set; }
    }

    public class ChannelSubscriptionGiftCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelSubscriptionGiftEvent
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

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Null if anonymous or not shared by the user.
        /// </summary>
        [JsonProperty("cumulative_total")]
        public int CumulativeTotal { get; set; }

        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; }
    }
}
