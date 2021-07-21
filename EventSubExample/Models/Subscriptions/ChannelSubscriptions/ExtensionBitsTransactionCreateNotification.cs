using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The extension.bits_transaction.create subscription type sends a notification when a new transaction is created for a Twitch Extension.
    /// The OAuth token client ID must match the Extension client ID.
    /// </summary>
    public class ExtensionBitsTransactionCreateNotification
    {
        [JsonProperty("event")]
        public ExtensionBitsTransactionCreateEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ExtensionBitsTransactionCreateSubscription Subscription { get; set; }
    }

    public class ExtensionBitsTransactionCreateSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ExtensionBitsTransactionCreateCondition Condition { get; set; }
    }

    public class ExtensionBitsTransactionCreateCondition
    {
        [JsonProperty("extension_client_id")]
        public string ExtensionClientId { get; set; }
    }

    public class ExtensionBitsTransactionCreateProduct
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("bits")]
        public int Bits { get; set; }

        [JsonProperty("in_development")]
        public bool InDevelopment { get; set; }
    }

    public class ExtensionBitsTransactionCreateEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("extension_client_id")]
        public string ExtensionClientId { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("product")]
        public ExtensionBitsTransactionCreateProduct Product { get; set; }
    }
}
