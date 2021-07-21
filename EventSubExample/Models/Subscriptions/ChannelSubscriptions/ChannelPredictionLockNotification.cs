using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.prediction.lock subscription type sends a notification when a Prediction is locked on the specified channel.
    /// Must have channel:read:predictions or channel:manage:predictions scope.
    /// </summary>
    public class ChannelPredictionLockNotification
    {
        [JsonProperty("event")]
        public ChannelPredictionLockEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPredictionLockSubscription Subscription { get; set; }
    }

    public class ChannelPredictionLockSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPredictionLockCondition Condition { get; set; }
    }

    public class ChannelPredictionLockCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPredictionLockTopPredictor
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

    public class ChannelPredictionLockOutcome
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
        public List<ChannelPredictionLockTopPredictor> TopPredictors { get; set; }
    }

    public class ChannelPredictionLockEvent
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
        public List<ChannelPredictionLockOutcome> Outcomes { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("locked_at")]
        public string LockedAt { get; set; }
    }
}
