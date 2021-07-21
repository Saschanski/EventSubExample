using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EventSubExample.Misc
{
    public static class Extensions
    {
        /// <summary>
        /// Validates the request against Twitch-Eventsub-Message-Signature. 
        /// </summary>
        /// <param name="Request">The HttpRequest from Twitch.</param>
        /// <param name="Secret">The secret sent in the initial webhook creation.</param>
        /// <returns>True if valid. False if not valid.</returns>
        public static async Task<bool> IsValid(this HttpRequest Request, string Secret)
        {
            try
            {
                string LocalSignature = CalculateSignature(Request.Headers, await Request.GetRequestBodyAsync(), Secret);

                var RemoteSignature = Request.Headers["Twitch-Eventsub-Message-Signature"].First().Split('=').Last();

                if (LocalSignature == RemoteSignature)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// Signature verification like described by Twitch https://dev.twitch.tv/docs/eventsub#verify-a-signature
        /// </summary>
        /// <param name="Headers">Request Headers containing the needed parameters for the signature calculation.</param>
        /// <param name="RequestBody">The json request from Twitch.</param>
        /// <param name="Secret">The secret sent in the initial webhook creation.</param>
        /// <returns>Returns the calculated signature string.</returns>
        public static string CalculateSignature(IHeaderDictionary Headers, string RequestBody, string Secret)
        {
            try
            {                
                string Message = Headers["Twitch-Eventsub-Message-Id"].First() + Headers["Twitch-Eventsub-Message-Timestamp"].First() + RequestBody;

                var Signature = new HMACSHA256(StringEncode(Secret)).ComputeHash(StringEncode(Message));

                return BitConverter.ToString(Signature).Replace("-", "").ToLower();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        /// <summary>
        /// Encode string to byte array.
        /// </summary>
        /// <param name="text">String content to encode into byte array.</param>
        /// <returns>Encoded byte array.</returns>
        private static byte[] StringEncode(string text)
        {
            var encoding = new ASCIIEncoding();
            return encoding.GetBytes(text);
        }


        // based on https://stackoverflow.com/a/4249787
        public static string GetEnumDescription<T>(this T value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false
            );

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        // based on https://stackoverflow.com/a/4249787
        public static T ParseDescriptionToEnum<T>(this string description)
        {
            Array array = Enum.GetValues(typeof(T));
            var list = new List<T>(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                list.Add((T)array.GetValue(i));
            }

            var dict = list.Select(v => new {
                Value = v,
                Description = GetEnumDescription(v)
            }
                       )
                           .ToDictionary(x => x.Description, x => x.Value);

            try
            {
                return dict[description];
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex);

                return dict["unknown"];
            }
        }

        // based on https://stackoverflow.com/a/60923370
        public static async Task<string> GetRequestBodyAsync(this HttpRequest request)
        {
            string objRequestBody = "";

            // IMPORTANT: Ensure the requestBody can be read multiple times.
            HttpRequestRewindExtensions.EnableBuffering(request);

            // IMPORTANT: Leave the body open so the next middleware can read it.
            using (StreamReader reader = new StreamReader(
                request.Body,
                Encoding.UTF8,
                detectEncodingFromByteOrderMarks: false,
                leaveOpen: true))
            {
                objRequestBody = await reader.ReadToEndAsync();

                // IMPORTANT: Reset the request body stream position so the next middleware can read it
                request.Body.Position = 0;
            }

            return objRequestBody;
        }
    }
}
