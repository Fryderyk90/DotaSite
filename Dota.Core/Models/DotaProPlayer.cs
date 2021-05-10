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
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class DotaProPlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("steamid")]
        public string Steamid { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("avatarmedium")]
        public Uri Avatarmedium { get; set; }

        [JsonProperty("avatarfull")]
        public Uri Avatarfull { get; set; }

        [JsonProperty("profileurl")]
        public Uri Profileurl { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("full_history_time")]
        public DateTimeOffset? FullHistoryTime { get; set; }

        [JsonProperty("cheese")]
        public long Cheese { get; set; }

        [JsonProperty("fh_unavailable")]
        public bool? FhUnavailable { get; set; }

        [JsonProperty("loccountrycode")]
        public string Loccountrycode { get; set; }

        [JsonProperty("last_match_time")]
        public DateTimeOffset LastMatchTime { get; set; }

        [JsonProperty("plus")]
        public bool? Plus { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("fantasy_role")]
        public long FantasyRole { get; set; }

        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        [JsonProperty("is_locked")]
        public bool IsLocked { get; set; }

        [JsonProperty("is_pro")]
        public bool IsPro { get; set; }

        [JsonProperty("locked_until")]
        public object LockedUntil { get; set; }
    }

    public partial class DotaProPlayer
    {
        public static DotaProPlayer[] FromJson(string json) => JsonConvert.DeserializeObject<DotaProPlayer[]>(json, Models.DotaProPlayerConverter.Settings);
    }

    public static class DotaProPlayerSerialize
    {
        public static string ToJson(this DotaProPlayer[] self) => JsonConvert.SerializeObject(self, Models.DotaProPlayerConverter.Settings);
    }

    internal static class DotaProPlayerConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

