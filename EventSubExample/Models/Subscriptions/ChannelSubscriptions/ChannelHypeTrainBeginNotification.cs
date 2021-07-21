using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.hype_train.begin subscription type sends a notification when a Hype Train begins on the specified channel.
    /// In addition to a channel.hype_train.begin event, one channel.hype_train.progress event will be sent for each contribution that caused the Hype Train to begin.
    /// EventSub does not make strong assurances about the order of message delivery, so it is possible to receive channel.hype_train.progress notifications before you receive the corresponding channel.hype_train.begin notification.
    /// After the Hype Train begins, any additional cheers or subscriptions on the channel will cause channel.hype_train.progress notifications to be sent. When the Hype Train is over, channel.hype_train.end is emitted.
    /// Must have channel:read:hype_train scope.
    /// </summary>
    public class ChannelHypeTrainBeginNotification
    {
        [JsonProperty("event")]
        public ChannelHypeTrainBeginEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelHypeTrainBeginSubscription Subscription { get; set; }
    }

    public class ChannelHypeTrainBeginSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelHypeTrainBeginCondition Condition { get; set; }
    }

    public class ChannelHypeTrainBeginCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelHypeTrainBeginTopContribution
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

    public class ChannelHypeTrainBeginLastContribution
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

    public class ChannelHypeTrainBeginEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("goal")]
        public int Goal { get; set; }

        [JsonProperty("top_contributions")]
        public List<ChannelHypeTrainBeginTopContribution> TopContributions { get; set; }

        [JsonProperty("last_contribution")]
        public ChannelHypeTrainBeginLastContribution LastContribution { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt { get; set; }
    }
}
