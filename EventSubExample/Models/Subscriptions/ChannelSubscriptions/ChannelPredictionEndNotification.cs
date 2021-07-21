using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.prediction.end subscription type sends a notification when a Prediction ends on the specified channel.
    /// Must have channel:read:predictions or channel:manage:predictions scope.
    /// </summary>
    public class ChannelPredictionEndNotification
    {
        [JsonProperty("event")]
        public ChannelPredictionEndEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPredictionEndSubscription Subscription { get; set; }
    }

    public class ChannelPredictionEndSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPredictionEndCondition Condition { get; set; }
    }

    public class ChannelPredictionEndCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPredictionEndTopPredictor
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_id")]
        public object UserId { get; set; }

        /// <summary>
        /// Null if result is refund or loss.
        /// </summary>
        [JsonProperty("channel_points_won")]
        public int? ChannelPointsWon { get; set; }

        [JsonProperty("channel_points_used")]
        public int ChannelPointsUsed { get; set; }
    }

    public class ChannelPredictionEndOutcome
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Can be blue or pink.
        /// </summary>
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
        public List<ChannelPredictionEndTopPredictor> TopPredictors { get; set; }
    }

    public class ChannelPredictionEndEvent
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

        [JsonProperty("winning_outcome_id")]
        public string WinningOutcomeId { get; set; }

        [JsonProperty("outcomes")]
        public List<ChannelPredictionEndOutcome> Outcomes { get; set; }

        /// <summary>
        /// Valid values: resolved, canceled
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }
    }
}
