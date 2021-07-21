using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.unban subscription type sends a notification when a viewer is unbanned from the specified channel.
    /// Must have channel:moderate scope.
    /// </summary>
    public class ChannelUnbanNotification
    {
        [JsonProperty("event")]
        public ChannelUnbanEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelUnbanSubscription Subscription { get; set; }
    }

    public class ChannelUnbanSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelUnbanCondition Condition { get; set; }
    }

    public class ChannelUnbanCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelUnbanEvent
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

        [JsonProperty("moderator_user_id")]
        public string ModeratorUserId { get; set; }

        [JsonProperty("moderator_user_login")]
        public string ModeratorUserLogin { get; set; }

        [JsonProperty("moderator_user_name")]
        public string ModeratorUserName { get; set; }
    }
}
