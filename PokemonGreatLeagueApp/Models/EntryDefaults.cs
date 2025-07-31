using System.Collections.Generic;
using Newtonsoft.Json;

namespace NebsojiPVPTrainer.Models
{
    public class EntryDefaults
    {
        [JsonProperty("teraType")]
        public string? TeraType { get; set; }

        [JsonProperty("moveTypes")]
        public List<string>? MoveTypes { get; set; }

        [JsonProperty("traits")]
        public List<string>? Traits { get; set; }
    }
}
