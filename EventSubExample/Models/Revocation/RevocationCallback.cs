using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Revocation
{
    /// <summary>
    /// Twitch reserves the right to revoke a subscription at any time. The most common reasons for revocation are:
    /// The subscription depends on events for a user id that no longer exists.
    /// The subscription depends on an authorization token that was revoked by the user.
    /// The subscription callback failed its notifications over an extended period of time.
    /// </summary>
    public class RevocationCallback
    {
        [JsonProperty("subscription")]
        public Subscription Subscription { get; set; }
    }

    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("condition")]
        public Condition Condition { get; set; }

        [JsonProperty("transport")]
        public Transport Transport { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class Condition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class Transport
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }
    }
}
