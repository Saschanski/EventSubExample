using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.subscription.message subscription type sends a notification when a user sends a resubscription chat message in a specific channel.
    /// Must have channel:read:subscriptions scope.
    /// </summary>
    public class ChannelSubscriptionMessageNotification
    {
        [JsonProperty("event")]
        public ChannelSubscriptionMessageEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelSubscriptionMessageSubscription Subscription { get; set; }
    }

    public class ChannelSubscriptionMessageSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelSubscriptionMessageCondition Condition { get; set; }
    }

    public class ChannelSubscriptionMessageCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelSubscriptionMessageEvent
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

        [JsonProperty("message")]
        public ChannelSubscriptionMessage Message { get; set; }

        [JsonProperty("cumulative_months")]
        public int CumulativeMonths { get; set; }

        /// <summary>
        /// Null if not shared
        /// </summary>
        [JsonProperty("streak_months")]
        public int StreakMonths { get; set; }

        [JsonProperty("duration_months")]
        public int DurationMonths { get; set; }
    }

    public class ChannelSubscriptionMessage
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("emotes")]
        public List<ChannelSubscriptionMessageEmote> Emotes { get; set; }
    }

    public class ChannelSubscriptionMessageEmote
    {
        [JsonProperty("begin")]
        public int Begin { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
