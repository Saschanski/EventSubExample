using EventSubExample.Enums;
using EventSubExample.Misc;
using EventSubExample.Models.Verification;
using EventSubExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EventSubExample.Controllers
{
    /// <summary>
    /// The webhook controller. Set it to whatever specified by the initial creation request. In this example https://example.com/webhooks/callback.
    /// The URL provided in the callback field MUST use HTTPS and port 443. https://dev.twitch.tv/docs/eventsub#create-a-subscription
    /// </summary>
    [ApiController]
    [Route("webhooks")]
    public class WebhooksController : Controller
    {
        private readonly IEventSubService eventSubService;
        private readonly ILogger<WebhooksController> logger;

        public WebhooksController(IEventSubService eventSubService, ILogger<WebhooksController> logger)
        {
            this.eventSubService = eventSubService;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The main webhook callback endpoint called by Twitch. This got set in the initial webhook creation request.
        /// You can split this up for every SubscriptionType or groups (like cheer related calls) if wanted by providing a different webhook endpoint in the initial creation request.
        /// </summary>
        /// <returns></returns>
        [HttpPost("callback")]
        public async Task<IActionResult> Callback()
        {
            try
            {
                // Validates the request using the secret that got sent in the initial creation request
                // Better move the secret somewhere else!
                if (await Request.IsValid("secret"))
                {
                    if (Request.Headers.TryGetValue("Twitch-Eventsub-Message-Type", out var MessageTypeHeader))
                    {
                        switch (MessageTypeHeader.First().ParseDescriptionToEnum<MessageType>())
                        {
                            case MessageType.WebhookCallbackVerification:
                                string Body = await Request.GetRequestBodyAsync();
                                var VerificationRequest = JsonConvert.DeserializeObject<WebhookCallbackVerification>(await Request.GetRequestBodyAsync());
                                return Ok(VerificationRequest.Challenge);
                            case MessageType.Notification:
                                if (Request.Headers.TryGetValue("Twitch-Eventsub-Subscription-Type", out var SubscriptionTypeHeader))
                                {
                                    eventSubService.ProcessRequest(SubscriptionTypeHeader.First().ParseDescriptionToEnum<SubscriptionType>(), await Request.GetRequestBodyAsync());
                                    return Ok();
                                }
                                else
                                {
                                    return Forbid();
                                }
                            case MessageType.Unknown:
                                return Forbid();
                            default:
                                return Forbid();
                        }
                    }
                    else
                    {
                        return Forbid();
                    }
                }
                else
                {
                    return Forbid();
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, "Failed processing callback");
                return Forbid();
            }
        }

    }
}
