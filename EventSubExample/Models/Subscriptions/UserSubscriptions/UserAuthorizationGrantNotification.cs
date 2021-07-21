using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.UserSubscriptions
{
    /// <summary>
    /// The user.authorization.grant subscription type sends a notification when a user’s authorization has been granted to your client id.
    /// Provided client_id must match the client id in the application access token.
    /// </summary>
    public class UserAuthorizationGrantNotification
    {
        [JsonProperty("event")]
        public UserAuthorizationGrantEvent Event { get; set; }

        [JsonProperty("subscription")]
        public UserAuthorizationGrantSubscription Subscription { get; set; }
    }

    public class UserAuthorizationGrantSubscription : Subscription
    {
        [JsonProperty("condition")]
        public UserAuthorizationGrantCondition Condition { get; set; }
    }

    public class UserAuthorizationGrantCondition
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }
    }

    public class UserAuthorizationGrantEvent
    {
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
