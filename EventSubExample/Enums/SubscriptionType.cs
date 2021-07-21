using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Enums
{
    /// <summary>
    /// The current subscription types implemented. Present in Twitch-Eventsub-Subscription-Type request header. See https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types.
    /// </summary>
    public enum SubscriptionType
    {
        [Description("channel.update")]
        ChannelUpdate,
        [Description("channel.follow")]
        ChannelFollow,
        [Description("channel.subscribe")]
        ChannelSubscribe,
        [Description("channel.subscription.end")]
        ChannelSubscriptionEnd,
        [Description("channel.subscription.gift")]
        ChannelSubscriptionGift,
        [Description("channel.subscription.message")]
        ChannelSubscriptionMessage,
        [Description("channel.cheer")]
        ChannelCheer,
        [Description("channel.raid")]
        ChannelRaid,
        [Description("channel.ban")]
        ChannelBan,
        [Description("channel.unban")]
        ChannelUnban,
        [Description("channel.moderator.add")]
        ChannelModeratorAdd,
        [Description("channel.moderator.remove")]
        ChannelModeratorRemove,
        [Description("channel.channel_points_custom_reward.add")]
        ChannelPointsCustomRewardAdd,
        [Description("channel.channel_points_custom_reward.update")]
        ChannelPointsCustomRewardUpdate,
        [Description("channel.channel_points_custom_reward.remove")]
        ChannelPointsCustomRewardRemove,
        [Description("channel.channel_points_custom_reward_redemption.add")]
        ChannelPointsCustomRewardRedemptionAdd,
        [Description("channel.channel_points_custom_reward_redemption.update")]
        ChannelPointsCustomRewardRedemptionUpdate,
        [Description("channel.poll.begin")]
        ChannelPollBegin,
        [Description("channel.poll.progress")]
        ChannelPollProgress,
        [Description("channel.poll.end")]
        ChannelPollEnd,
        [Description("channel.prediction.begin")]
        ChannelPredictionBegin,
        [Description("channel.prediction.progress")]
        ChannelPredictionProgress,
        [Description("channel.prediction.lock")]
        ChannelPredictionLock,
        [Description("channel.prediction.end")]
        ChannelPredictionEnd,
        [Description("drop.entitlement.grant")]
        DropEntitlementGrant,
        [Description("extension.bits_transaction.create")]
        ExtensionBitsTransactionCreate,
        [Description("channel.hype_train.begin")]
        HypeTrainBegin,
        [Description("channel.hype_train.progress")]
        HypeTrainProgress,
        [Description("channel.hype_train.end")]
        HypeTrainEnd,
        [Description("stream.online")]
        StreamOnline,
        [Description("stream.offline")]
        StreamOffline,
        [Description("user.authorization.grant")]
        UserAuthorizationGrant,
        [Description("user.authorization.revoke")]
        UserAuthorizationRevoke,
        [Description("user.update")]
        UserUpdate,
        [Description("unknown")]
        Unkown
    }
}
