using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Models.Subscriptions.ChannelSubscriptions
{
    /// <summary>
    /// The channel.poll.progress subscription type sends a notification when users respond to a poll on the specified channel.
    /// Must have channel:read:polls or channel:manage:polls scope.
    /// </summary>
    public class ChannelPollProgressNotification
    {
        [JsonProperty("event")]
        public ChannelPollProgressEvent Event { get; set; }

        [JsonProperty("subscription")]
        public ChannelPollProgressSubscription Subscription { get; set; }
    }

    public class ChannelPollProgressSubscription : Subscription
    {
        [JsonProperty("condition")]
        public ChannelPollProgressCondition Condition { get; set; }
    }

    public class ChannelPollProgressCondition
    {
        [JsonProperty("broadcaster_user_id")]
        public string BroadcasterUserId { get; set; }
    }

    public class ChannelPollProgressChoice
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

        /// <summary>
        /// Number of votes received via Bits.
        /// </summary>
        [JsonProperty("bits_votes")]
        public int BitsVotes { get; set; }

        /// <summary>
        /// Number of votes received via Channel Points.
        /// </summary>
        [JsonProperty("channel_points_votes")]
        public int ChannelPointsVotes { get; set; }

        /// <summary>
        /// Total number of votes received for the choice across all methods of voting.
        /// </summary>
        [JsonProperty("votes")]
        public int Votes { get; set; }
    }

    public class ChannelPollProgressBitsVoting
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

    public class ChannelPollProgressChannelPointsVoting
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

    public class ChannelPollProgressEvent
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
        public List<ChannelPollProgressChoice> Choices { get; set; }

        [JsonProperty("bits_voting")]
        public ChannelPollProgressBitsVoting BitsVoting { get; set; }

        [JsonProperty("channel_points_voting")]
        public ChannelPollProgressChannelPointsVoting ChannelPointsVoting { get; set; }

        [JsonProperty("started_at")]
        public string StartedAt { get; set; }

        [JsonProperty("ends_at")]
        public string EndsAt { get; set; }
    }
}
