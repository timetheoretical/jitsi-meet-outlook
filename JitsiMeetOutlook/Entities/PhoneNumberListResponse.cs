using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JitsiMeetOutlook.Entities
{
    /// <summary>
    /// PhoneNumberList Endpoint Response
    /// Derived from https://github.com/jitsi/jitsi-meet/blob/master/resources/cloud-api.swagger
    /// </summary>
    public class PhoneNumberListResponse
    {
        /// <summary>
        /// Message from the server.
        /// </summary>
        /// <value></value>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Switch whether the numbers are enabled.
        /// </summary>
        /// <value></value>
        [JsonPropertyName("numbersEnabled")]
        public bool NumbersEnabled { get; set; }

        /// <summary>
        /// Dictionary of Numbers.
        /// CountryCode - Number
        /// </summary>
        [JsonPropertyName("numbers")]
        public Dictionary<string, List<string>> Numbers { get; set; }
    }
}
