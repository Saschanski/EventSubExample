using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.prediction.progress subscription type sends a notification when users participate in a Prediction on the specified channel.
    /// Must have channel:read:predictions or channel:manage:predictions scope.
    /// </summary>
    public class ChannelPredictionProgressNotification
    {
        [JsonProperty("event")]
        public ChannelPredictionProgressEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPredictionProgressSubscription Subscription { get; set; }
    }

    public class ChannelPredictionProgressSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPredictionProgressCondition Condition { get; set; }
    }

    public class ChannelPredictionProgressCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPredictionProgressTopPredictor
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_id")]
        public object UserId { get; set; }

        [JsonProperty("channel_points_won")]
        public object ChannelPointsWon { get; set; }

        [JsonProperty("channel_points_used")]
        public int ChannelPointsUsed { get; set; }
    }

    public class ChannelPredictionProgressOutcome
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("users")]
        public int Users { get; set; }

        [JsonProperty("channel_points")]
        public int ChannelPoints { get; set; }

        /// <summary>
        /// Contains up to 10 users.
        /// </summary>
        [JsonProperty("top_predictors")]
        public List<ChannelPredictionProgressTopPredictor> TopPredictors { get; set; }
    }

    public class ChannelPredictionProgressEvent
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
        public List<ChannelPredictionProgressOutcome> Outcomes { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("locks_at")]
        public string LocksAt { get; set; }
    }
}
