using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.channel_points_custom_reward.remove subscription type sends a notification when a custom channel points reward has been removed from the specified channel.
    /// Must have channel:read:redemptions or channel:manage:redemptions scope.
    /// </summary>
    public class ChannelPointsCustomRewardRemoveNotification
    {
        [JsonProperty("event")]
        public ChannelPointsCustomRewardRemoveEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPointsCustomRewardRemoveSubscription Subscription { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPointsCustomRewardRemoveCondition Condition { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveMaxPerStream
    {
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveMaxPerUserPerStream
    {
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveGlobalCooldown
    {
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("seconds")]
        public int Seconds { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveImage
    {
        [JsonProperty("url_1x")]
        public string Url1x { get; set; }

        [JsonProperty("url_2x")]
        public string Url2x { get; set; }

        [JsonProperty("url_4x")]
        public string Url4x { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveDefaultImage
    {
        [JsonProperty("url_1x")]
        public string Url1x { get; set; }

        [JsonProperty("url_2x")]
        public string Url2x { get; set; }

        [JsonProperty("url_4x")]
        public string Url4x { get; set; }
    }

    public class ChannelPointsCustomRewardRemoveEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("is_paused")]
        public bool IsPaused { get; set; }

        [JsonProperty("is_in_stock")]
        public bool IsInStock { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("prompt")]
        public string Prompt { get; set; }

        [JsonProperty("is_user_input_required")]
        public bool IsUserInputRequired { get; set; }

        [JsonProperty("should_redemptions_skip_request_queue")]
        public bool ShouldRedemptionsSkipRequestQueue { get; set; }

        [JsonProperty("cooldown_expires_at")]
        public DateTime CooldownExpiresAt { get; set; }

        [JsonProperty("redemptions_redeemed_current_stream")]
        public int RedemptionsRedeemedCurrentStream { get; set; }

        [JsonProperty("max_per_stream")]
        public ChannelPointsCustomRewardRemoveMaxPerStream MaxPerStream { get; set; }

        [JsonProperty("max_per_user_per_stream")]
        public ChannelPointsCustomRewardRemoveMaxPerUserPerStream MaxPerUserPerStream { get; set; }

        [JsonProperty("global_cooldown")]
        public ChannelPointsCustomRewardRemoveGlobalCooldown GlobalCooldown { get; set; }

        [JsonProperty("background_color")]
        public string BackgroundColor { get; set; }

        [JsonProperty("image")]
        public ChannelPointsCustomRewardRemoveImage Image { get; set; }

        [JsonProperty("default_image")]
        public ChannelPointsCustomRewardRemoveDefaultImage DefaultImage { get; set; }
    }
}
