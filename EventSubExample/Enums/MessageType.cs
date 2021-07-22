using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EventSubExample.Enums
{
    /// <summary>
    /// The current message types implemented. Present in Twitch-Eventsub-Message-Type request header.
    /// </summary>
    public enum MessageType
    {
        [Description("webhook_callback_verification")]
        WebhookCallbackVerification,
        [Description("notification")]
        Notification,
        [Description("revocation")]
        Revocation,
        [Description("unknown")]
        Unknown
    }
}
