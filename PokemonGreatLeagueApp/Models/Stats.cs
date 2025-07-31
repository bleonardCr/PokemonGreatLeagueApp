using Newtonsoft.Json;

namespace NebsojiPVPTrainer.Models
{
    public class Stats
    {
        [JsonProperty("hp")] public double Hp { get; set; }
        [JsonProperty("atk")] public double Atk { get; set; }
        [JsonProperty("def")] public double Def { get; set; }
        [JsonProperty("spA")] public double SpA { get; set; }
        [JsonProperty("spD")] public double SpD { get; set; }
        [JsonProperty("spe")] public double Spe { get; set; }
    }
}
