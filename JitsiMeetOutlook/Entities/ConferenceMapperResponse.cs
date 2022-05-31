using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JitsiMeetOutlook.Entities
{
    internal class ConferenceMapperResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("conference")]
        public string conference { get; set; }

        [JsonPropertyName("id")]
        public ulong Id { get; set; }

        [JsonIgnore]
        public string IdString => Id.ToString();
    }
}
