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
    public partial class DotaLiveMatch
    {
        [JsonProperty("activate_time")]
        public long ActivateTime { get; set; }

        [JsonProperty("deactivate_time")]
        public long DeactivateTime { get; set; }

        [JsonProperty("server_steam_id")]
        public string ServerSteamId { get; set; }

        [JsonProperty("lobby_id")]
        public string LobbyId { get; set; }

        [JsonProperty("league_id")]
        public long LeagueId { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("game_time")]
        public long GameTime { get; set; }

        [JsonProperty("delay")]
        public long Delay { get; set; }

        [JsonProperty("spectators")]
        public long Spectators { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("average_mmr")]
        public long AverageMmr { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("series_id")]
        public long SeriesId { get; set; }

        [JsonProperty("sort_score")]
        public long SortScore { get; set; }

        [JsonProperty("last_update_time")]
        public long LastUpdateTime { get; set; }

        [JsonProperty("radiant_lead")]
        public long RadiantLead { get; set; }

        [JsonProperty("radiant_score")]
        public long RadiantScore { get; set; }

        [JsonProperty("dire_score")]
        public long DireScore { get; set; }

        [JsonProperty("players")]
        public LivePlayer[] Players { get; set; }

        [JsonProperty("building_state")]
        public long BuildingState { get; set; }

        [JsonProperty("custom_game_difficulty")]
        public long CustomGameDifficulty { get; set; }

        [JsonProperty("team_name_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamNameRadiant { get; set; }

        [JsonProperty("team_name_dire", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamNameDire { get; set; }

        [JsonProperty("team_logo_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamLogoRadiant { get; set; }

        [JsonProperty("team_logo_dire", NullValueHandling = NullValueHandling.Ignore)]
        public string TeamLogoDire { get; set; }

        [JsonProperty("team_id_radiant", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamIdRadiant { get; set; }

        [JsonProperty("team_id_dire", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamIdDire { get; set; }
    }

    public partial class LivePlayer
    {
        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; set; }

        [JsonProperty("fantasy_role", NullValueHandling = NullValueHandling.Ignore)]
        public long? FantasyRole { get; set; }

        [JsonProperty("team_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamId { get; set; }

        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("team_tag")]
        public string TeamTag { get; set; }

        [JsonProperty("is_locked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLocked { get; set; }

        [JsonProperty("is_pro", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPro { get; set; }

        [JsonProperty("locked_until")]
        public object LockedUntil { get; set; }
    }

    public partial class DotaLiveMatch
    {
        public static DotaLiveMatch[] FromJson(string json) => JsonConvert.DeserializeObject<DotaLiveMatch[]>(json, Models.DotaLiveMatchConverter.Settings);
    }

    public static class DotaLiveMatchSerialize
    {
        public static string ToJson(this DotaLiveMatch[] self) => JsonConvert.SerializeObject(self, Models.DotaLiveMatchConverter.Settings);
    }

    internal static class DotaLiveMatchConverter
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
