using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The drop.entitlement.grant subscription type sends a notification when an entitlement for a Drop is granted to a user.
    /// 
    /// App access token required. The client ID associated with the access token must be owned by a user who is part of the specified organization.
    /// 
    /// Note that the payload structure is different from other subscription types.
    /// Events bound for drop.entitlement.grant subscriptions are batched.
    /// Developers can expect to receive roughly 0-5 HTTP requests per second. HTTP request bodies will not exceed 250KB.
    /// </summary>
    public class DropEntitlementGrantNotification
    {
        [JsonProperty("event")]
        public DropEntitlementGrantEvent Event { get; set; }

        [JsonProperty("subscription")]
        public DropEntitlementGrantSubscription Subscription { get; set; }

        [JsonProperty("events")]
        public List<DropEntitlementGrantEvent> Events { get; set; }
    }

    public class DropEntitlementGrantSubscription : Subscription
    {
        [JsonProperty("condition")]
        public DropEntitlementGrantCondition Condition { get; set; }
    }

    public class DropEntitlementGrantCondition
    {
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Included if specified in subscription.
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// Included if specified in subscription.
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }
    }

    public class DropEntitlementGrant
    {
        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// Display name.
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("entitlement_id")]
        public string EntitlementId { get; set; }

        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }

    public class DropEntitlementGrantEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("data")]
        public DropEntitlementGrant Data { get; set; }
    }
}
