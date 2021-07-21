using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.moderator.remove subscription type sends a notification when a user has moderator privileges removed on a specified channel.
    /// Must have moderation:read scope.
    /// </summary>
    public class ChannelModeratorRemoveNotification
    {
        [JsonProperty("event")]
        public ChannelModeratorRemoveEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelModeratorRemoveSubscription Subscription { get; set; }
    }

    public class ChannelModeratorRemoveSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelModeratorRemoveCondition Condition { get; set; }
    }

    public class ChannelModeratorRemoveCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelModeratorRemoveEvent
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
    }
}
