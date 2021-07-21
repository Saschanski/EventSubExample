using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.hype_train.progress subscription type sends a notification when a Hype Train makes progress on the specified channel.
    /// When a Hype Train starts, one channel.hype_train.progress event will be sent for each contribution that caused the Hype Train to begin (in addition to the channel.hype_train.begin event).
    /// EventSub does not make strong assurances about the order of message delivery, so it is possible to receive channel.hype_train.progress before you receive the corresponding channel.hype_train.begin.
    /// After a Hype Train begins, any additional cheers or subscriptions on the channel will cause channel.hype_train.progress notifications to be sent. When the Hype Train is over, channel.hype_train.end is emitted.
    /// Must have channel:read:hype_train scope.
    /// </summary>
    public class ChannelHypeTrainProgressNotification
    {
        [JsonProperty("event")]
        public ChannelHypeTrainProgressEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelHypeTrainProgressSubscription Subscription { get; set; }
    }

    public class ChannelHypeTrainProgressSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelHypeTrainProgressCondition Condition { get; set; }
    }

    public class ChannelHypeTrainProgressCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelHypeTrainProgressTopContribution
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ChannelHypeTrainProgressLastContribution
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class ChannelHypeTrainProgressEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("top_contributions")]
        public List<ChannelHypeTrainProgressTopContribution> TopContributions { get; set; }

        [JsonProperty("last_contribution")]
        public ChannelHypeTrainProgressLastContribution LastContribution { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
    }
}
