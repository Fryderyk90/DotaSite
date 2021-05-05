using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Dota.Core.Models
{
    public partial class DotaLeague
    {
        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }

        [JsonProperty("banner")]
        public string Banner { get; set; }

        [JsonProperty("tier")]
        public Tier? Tier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public enum Tier { Amateur, Excluded, Premium, Professional };

    public partial class DotaLeague
    {
        public static DotaLeague[] FromJson(string json) => JsonConvert.DeserializeObject<DotaLeague[]>(json, Models.LeagueConverter.Settings);
    }

    public static class LeagueSerialize
    {
        public static string ToJson(this DotaLeague[] self) => JsonConvert.SerializeObject(self, Models.LeagueConverter.Settings);
    }

    internal static class LeagueConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                TierConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TierConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Tier) || t == typeof(Tier?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "amateur":
                    return Tier.Amateur;
                case "excluded":
                    return Tier.Excluded;
                case "premium":
                    return Tier.Premium;
                case "professional":
                    return Tier.Professional;
            }
            throw new Exception("Cannot unmarshal type Tier");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Tier)untypedValue;
            switch (value)
            {
                case Tier.Amateur:
                    serializer.Serialize(writer, "amateur");
                    return;
                case Tier.Excluded:
                    serializer.Serialize(writer, "excluded");
                    return;
                case Tier.Premium:
                    serializer.Serialize(writer, "premium");
                    return;
                case Tier.Professional:
                    serializer.Serialize(writer, "professional");
                    return;
            }
            throw new Exception("Cannot marshal type Tier");
        }

        public static readonly TierConverter Singleton = new TierConverter();
    }
}



