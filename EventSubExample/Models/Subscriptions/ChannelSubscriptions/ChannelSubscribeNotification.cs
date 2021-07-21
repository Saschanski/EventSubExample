using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.subscribe subscription type sends a notification when a specified channel receives a subscriber. This does not include resubscribes.
    /// Must have channel:read:subscriptions scope.
    /// </summary>
    public class ChannelSubscribeNotification
    {
        [JsonProperty("event")]
        public ChannelSubscribeEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelSubscribeSubscription Subscription { get; set; }
    }

    public class ChannelSubscribeSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelSubscribeCondition Condition { get; set; }
    }

    public class ChannelSubscribeEvent
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

    public class ChannelSubscribeCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }
}
