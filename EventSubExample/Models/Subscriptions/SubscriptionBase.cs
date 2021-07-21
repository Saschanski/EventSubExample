using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions
{
    /// <summary>
    /// Contains subscription metadata.
    /// </summary>
    public class Subscription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("transport")]
        public Transport Transport { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    /// <summary>
    /// Transport-specific parameters.
    /// </summary>
    public class Transport
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("callback")]
        public string Callback { get; set; }
    }
}
