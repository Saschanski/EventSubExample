using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.subscription.end subscription type sends a notification when a subscription to the specified channel expires.
    /// Must have channel:read:subscriptions scope.
    /// </summary>
    public class ChannelSubscriptionEndNotification
    {
        [JsonProperty("event")]
        public ChannelSubscriptionEndEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelSubscriptionEndSubscription Subscription { get; set; }
    }

    public class ChannelSubscriptionEndSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelSubscriptionEndCondition Condition { get; set; }
    }

    public class ChannelSubscriptionEndCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelSubscriptionEndEvent
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

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("is_gift")]
        public bool IsGift { get; set; }
    }
}
