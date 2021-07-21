﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.poll.begin subscription type sends a notification when a poll begins on the specified channel.
    /// Must have channel:read:polls or channel:manage:polls scope.
    /// </summary>
    public class ChannelPollBeginNotification
    {
        [JsonProperty("event")]
        public ChannelPollBeginEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPollBeginSubscription Subscription { get; set; }
    }

    public class ChannelPollBeginSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPollBeginCondition Condition { get; set; }
    }

    public class ChannelPollBeginCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPollBeginChoice
    {
        /// <summary>
        /// ID for the choice.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Text displayed for the choice.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class ChannelPollBeginBitsVoting
    {
        /// <summary>
        /// Indicates if Bits can be used for voting.
        /// </summary>
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Number of Bits required to vote once with Bits.
        /// </summary>
        [JsonProperty("amount_per_vote")]
        public int AmountPerVote { get; set; }
    }

    public class ChannelPollBeginChannelPointsVoting
    {
        /// <summary>
        /// Indicates if Channel Points can be used for voting.
        /// </summary>
        [JsonProperty("is_enabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Number of Channel Points required to vote once with Channel Points.
        /// </summary>
        [JsonProperty("amount_per_vote")]
        public int AmountPerVote { get; set; }
    }

    public class ChannelPollBeginEvent
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }

        [JsonProperty("broadcaster_user_login")]
        public string BroadcasterUserLogin { get; set; }

        [JsonProperty("broadcaster_user_name")]
        public string BroadcasterUserName { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("choices")]
        public List<ChannelPollBeginChoice> Choices { get; set; }

        [JsonProperty("bits_voting")]
        public ChannelPollBeginBitsVoting BitsVoting { get; set; }

        [JsonProperty("channel_points_voting")]
        public ChannelPollBeginChannelPointsVoting ChannelPointsVoting { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("ends_at")]
        public string EndsAt { get; set; }
    }
}
