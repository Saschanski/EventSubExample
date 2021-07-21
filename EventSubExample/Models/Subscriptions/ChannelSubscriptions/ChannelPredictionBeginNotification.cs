using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.prediction.begin subscription type sends a notification when a Prediction begins on the specified channel.
    /// Must have channel:read:predictions or channel:manage:predictions scope
    /// </summary>
    public class ChannelPredictionBeginNotification
    {
        [JsonProperty("event")]
        public ChannelPredictionBeginEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPredictionBeginSubscription Subscription { get; set; }
    }

    public class ChannelPredictionBeginSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPredictionBeginCondition Condition { get; set; }
    }

    public class ChannelPredictionBeginCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPredictionBeginOutcome
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class ChannelPredictionBeginEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("outcomes")]
        public List<ChannelPredictionBeginOutcome> Outcomes { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("locks_at")]
        public string LocksAt { get; set; }
    }
}
