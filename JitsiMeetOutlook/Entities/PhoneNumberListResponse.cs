using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JitsiMeetOutlook.Entities
{
    internal class PhoneNumberListResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("numbersEnabled")]
        public bool NumbersEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("numbers")]
        public Dictionary<string, List<string>> Numbers { get; set; }
        // TODO Format in Getter function
    }
}
