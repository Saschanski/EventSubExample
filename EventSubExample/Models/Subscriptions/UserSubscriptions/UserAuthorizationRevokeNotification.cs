using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.UserSubscriptions
{
    /// <summary>
    /// The user.authorization.revoke subscription type sends a notification when a user’s authorization has been revoked for your client id.
    /// Use this webhook to meet government requirements for handling user data, such as GDPR, LGPD, or CCPA.
    /// Provided client_id must match the client id in the application access token.
    /// </summary>
    public class UserAuthorizationRevokeNotification
    {
        [JsonProperty("event")]
        public UserAuthorizationRevokeEvent Event { get; set; }

        [JsonProperty("subscription")]
        public UserAuthorizationRevokeSubscription Subscription { get; set; }
    }

    public class UserAuthorizationRevokeSubscription : Subscription
    {
        [JsonProperty("condition")]
        public UserAuthorizationRevokeCondition Condition { get; set; }
    }

    public class UserAuthorizationRevokeCondition
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }

    public class UserAuthorizationRevokeEvent
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Null if the user no longer exists.
        /// </summary>
        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        /// <summary>
        /// Null if the user no longer exists.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
