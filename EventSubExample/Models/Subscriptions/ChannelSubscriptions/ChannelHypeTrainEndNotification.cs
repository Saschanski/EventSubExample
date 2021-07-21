using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.hype_train.end subscription type sends a notification when a Hype Train ends on the specified channel.
    /// Must have channel:read:hype_train scope.
    /// </summary>
    public class ChannelHypeTrainEndNotification
    {
        [JsonProperty("event")]
        public ChannelHypeTrainEndEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelHypeTrainEndSubscription Subscription { get; set; }
    }

    public class ChannelHypeTrainEndSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelHypeTrainEndCondition Condition { get; set; }
    }

    public class ChannelHypeTrainEndCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelHypeTrainEndTopContribution
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

    public class ChannelHypeTrainEndEvent
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

        [JsonProperty("top_contributions")]
        public List<ChannelHypeTrainEndTopContribution> TopContributions { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("ended_at")]
        public string EndedAt { get; set; }

        [JsonProperty("cooldown_ends_at")]
        public string CooldownEndsAt { get; set; }
    }
}
