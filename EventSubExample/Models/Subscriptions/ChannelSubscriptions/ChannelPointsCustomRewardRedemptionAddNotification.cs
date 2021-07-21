using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.channel_points_custom_reward_redemption.add subscription type sends a notification when a viewer has redeemed a custom channel points reward on the specified channel.
    /// Must have channel:read:redemptions or channel:manage:redemptions scope.
    /// </summary>
    public class ChannelPointsCustomRewardRedemptionAddNotification
    {
        [JsonProperty("event")]
        public ChannelPointsCustomRewardRedemptionAddEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPointsCustomRewardRedemptionAddSubscription Subscription { get; set; }
    }

    public class ChannelPointsCustomRewardRedemptionAddSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPointsCustomRewardRedemptionAddCondition Condition { get; set; }
    }

    public class ChannelPointsCustomRewardRedemptionAddCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPointsCustomRewardRedemptionAddReward
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }
    }

    public class ChannelPointsCustomRewardRedemptionAddEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("user_login")]
        public string UserLogin { get; set; }

        [JsonProperty("user_name")]
        public string UserName { get; set; }

        [JsonProperty("user_input")]
        public string UserInput { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reward")]
        public ChannelPointsCustomRewardRedemptionAddReward Reward { get; set; }

        [JsonProperty("redeemed_at")]
        public string RedeemedAt { get; set; }
    }
}
