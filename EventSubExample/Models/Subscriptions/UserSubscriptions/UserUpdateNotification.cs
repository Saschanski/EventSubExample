using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.UserSubscriptions
{
    /// <summary>
    /// The user.update subscription type sends a notification when user updates their account.
    /// No authorization required. If you have the user:read:email scope, the notification will include email field.
    /// </summary>
    public class UserUpdateNotification
    {
        [JsonProperty("event")]
        public UserUpdateEvent Event { get; set; }

        [JsonProperty("subscription")]
        public UserUpdateSubscription Subscription { get; set; }
    }

    public class UserUpdateSubscription : Subscription
    {
        [JsonProperty("condition")]
        public UserUpdateCondition Condition { get; set; }
    }

    public class UserUpdateCondition
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }

    public class UserUpdateEvent
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// Requires user:read:email scope.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
