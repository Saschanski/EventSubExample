using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.cheer subscription type sends a notification when a user cheers on the specified channel.
    /// Must have bits:read scope.
    /// </summary>
    public class ChannelCheerNotification
    {
        [JsonProperty("event")]
        public ChannelCheerEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelCheerSubscription Subscription { get; set; }
    }

    public class ChannelCheerSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelCheerCondition Condition { get; set; }
    }

    public class ChannelCheerCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelCheerEvent
    {
        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// Null if IsAnonymouss == true
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Null if IsAnonymouss == true
        /// </summary>
        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        /// <summary>
        /// Null if IsAnonymouss == true
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("bits")]
        public int Bits { get; set; }
    }
}
