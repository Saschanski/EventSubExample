using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.moderator.add subscription type sends a notification when a user is given moderator privileges on a specified channel.
    /// Must have moderation:read scope.
    /// </summary>
    public class ChannelModeratorAddNotification
    {
        [JsonProperty("event")]
        public ChannelModeratorAddEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelModeratorAddSubscription Subscription { get; set; }
    }

    public class ChannelModeratorAddSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelModeratorAddCondition Condition { get; set; }
    }

    public class ChannelModeratorAddCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelModeratorAddEvent
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
