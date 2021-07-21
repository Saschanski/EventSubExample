using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Verification
{
    public class WebhookCallbackVerification
    {
        [JsonProperty("challenge")]
        public string Challenge { get; set; }

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

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

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
