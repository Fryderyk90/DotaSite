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
    public partial class DotaMatchInfo
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("barracks_status_dire")]
        public long BarracksStatusDire { get; set; }

        [JsonProperty("barracks_status_radiant")]
        public long BarracksStatusRadiant { get; set; }

        [JsonProperty("chat")]
        public Chat[] Chat { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("cosmetics")]
        public Dictionary<string, long> Cosmetics { get; set; }

        [JsonProperty("dire_score")]
        public long DireScore { get; set; }

        [JsonProperty("dire_team_id")]
        public long DireTeamId { get; set; }

        [JsonProperty("draft_timings")]
        public DraftTiming[] DraftTimings { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("engine")]
        public long Engine { get; set; }

        [JsonProperty("first_blood_time")]
        public long FirstBloodTime { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("human_players")]
        public long HumanPlayers { get; set; }

        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("match_seq_num")]
        public long MatchSeqNum { get; set; }

        [JsonProperty("negative_votes")]
        public long NegativeVotes { get; set; }

        [JsonProperty("objectives")]
        public Objective[] Objectives { get; set; }

        [JsonProperty("picks_bans")]
        public PicksBan[] PicksBans { get; set; }

        [JsonProperty("positive_votes")]
        public long PositiveVotes { get; set; }

        [JsonProperty("radiant_gold_adv")]
        public long[] RadiantGoldAdv { get; set; }

        [JsonProperty("radiant_score")]
        public long RadiantScore { get; set; }

        [JsonProperty("radiant_team_id")]
        public long RadiantTeamId { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("radiant_xp_adv")]
        public long[] RadiantXpAdv { get; set; }

        [JsonProperty("skill")]
        public object Skill { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("teamfights")]
        public Teamfight[] Teamfights { get; set; }

        [JsonProperty("tower_status_dire")]
        public long TowerStatusDire { get; set; }

        [JsonProperty("tower_status_radiant")]
        public long TowerStatusRadiant { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("replay_salt")]
        public long ReplaySalt { get; set; }

        [JsonProperty("series_id")]
        public long SeriesId { get; set; }

        [JsonProperty("series_type")]
        public long SeriesType { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }

        [JsonProperty("radiant_team")]
        public Team RadiantTeam { get; set; }

        [JsonProperty("dire_team")]
        public Team DireTeam { get; set; }

        [JsonProperty("players")]
        public TestInfoPlayer[] Players { get; set; }

        [JsonProperty("patch")]
        public long Patch { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("all_word_counts")]
        public Dictionary<string, long> AllWordCounts { get; set; }

        [JsonProperty("my_word_counts")]
        public MyWordCounts MyWordCounts { get; set; }

        [JsonProperty("throw")]
        public long Throw { get; set; }

        [JsonProperty("loss")]
        public long Loss { get; set; }

        [JsonProperty("replay_url")]
        public Uri ReplayUrl { get; set; }
    }

    public partial class Chat
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("type")]
        public ChatType Type { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("team_id")]
        public long TeamId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("logo_url")]
        public Uri LogoUrl { get; set; }
    }

    public partial class DraftTiming
    {
        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("pick")]
        public bool Pick { get; set; }

        [JsonProperty("active_team")]
        public long ActiveTeam { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("player_slot")]
        public long? PlayerSlot { get; set; }

        [JsonProperty("extra_time")]
        public long ExtraTime { get; set; }

        [JsonProperty("total_time_taken")]
        public long TotalTimeTaken { get; set; }
    }

    public partial class League
    {
        [JsonProperty("leagueid")]
        public long Leagueid { get; set; }

        [JsonProperty("ticket")]
        public object Ticket { get; set; }

        [JsonProperty("banner")]
        public object Banner { get; set; }

        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class MyWordCounts
    {
    }

    public partial class Objective
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("team", NullValueHandling = NullValueHandling.Ignore)]
        public long? Team { get; set; }

        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? Slot { get; set; }

        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public Key? Key { get; set; }

        [JsonProperty("player_slot", NullValueHandling = NullValueHandling.Ignore)]
        public long? PlayerSlot { get; set; }

        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }
    }

    public partial class PicksBan
    {
        [JsonProperty("is_pick")]
        public bool IsPick { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("team")]
        public long Team { get; set; }

        [JsonProperty("order")]
        public long Order { get; set; }

        [JsonProperty("ord")]
        public long Ord { get; set; }

        [JsonProperty("match_id")]
        public long MatchId { get; set; }
    }

    public partial class TestInfoPlayer
    {
        [JsonProperty("match_id")]
        public long MatchId { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }

        [JsonProperty("ability_targets")]
        public AbilityTargets AbilityTargets { get; set; }

        [JsonProperty("ability_upgrades_arr")]
        public long[] AbilityUpgradesArr { get; set; }

        [JsonProperty("ability_uses")]
        public Dictionary<string, long> AbilityUses { get; set; }

        [JsonProperty("account_id")]
        public long AccountId { get; set; }

        [JsonProperty("actions")]
        public Dictionary<string, long> Actions { get; set; }

        [JsonProperty("additional_units")]
        public object AdditionalUnits { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("backpack_0")]
        public long Backpack0 { get; set; }

        [JsonProperty("backpack_1")]
        public long Backpack1 { get; set; }

        [JsonProperty("backpack_2")]
        public long Backpack2 { get; set; }

        [JsonProperty("backpack_3")]
        public object Backpack3 { get; set; }

        [JsonProperty("buyback_log")]
        public Chat[] BuybackLog { get; set; }

        [JsonProperty("camps_stacked")]
        public long CampsStacked { get; set; }

        [JsonProperty("connection_log")]
        public object[] ConnectionLog { get; set; }

        [JsonProperty("creeps_stacked")]
        public long CreepsStacked { get; set; }

        [JsonProperty("damage")]
        public Dictionary<string, long> Damage { get; set; }

        [JsonProperty("damage_inflictor")]
        public Dictionary<string, long> DamageInflictor { get; set; }

        [JsonProperty("damage_inflictor_received")]
        public Dictionary<string, long> DamageInflictorReceived { get; set; }

        [JsonProperty("damage_taken")]
        public Dictionary<string, long> DamageTaken { get; set; }

        [JsonProperty("damage_targets")]
        public DamageTargets DamageTargets { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("denies")]
        public long Denies { get; set; }

        [JsonProperty("dn_t")]
        public long[] DnT { get; set; }

        [JsonProperty("firstblood_claimed")]
        public long FirstbloodClaimed { get; set; }

        [JsonProperty("gold")]
        public long Gold { get; set; }

        [JsonProperty("gold_per_min")]
        public long GoldPerMin { get; set; }

        [JsonProperty("gold_reasons")]
        public Dictionary<string, long> GoldReasons { get; set; }

        [JsonProperty("gold_spent")]
        public long GoldSpent { get; set; }

        [JsonProperty("gold_t")]
        public long[] GoldT { get; set; }

        [JsonProperty("hero_damage")]
        public long HeroDamage { get; set; }

        [JsonProperty("hero_healing")]
        public long HeroHealing { get; set; }

        [JsonProperty("hero_hits")]
        public Dictionary<string, long> HeroHits { get; set; }

        [JsonProperty("hero_id")]
        public long HeroId { get; set; }

        [JsonProperty("item_0")]
        public long Item0 { get; set; }

        [JsonProperty("item_1")]
        public long Item1 { get; set; }

        [JsonProperty("item_2")]
        public long Item2 { get; set; }

        [JsonProperty("item_3")]
        public long Item3 { get; set; }

        [JsonProperty("item_4")]
        public long Item4 { get; set; }

        [JsonProperty("item_5")]
        public long Item5 { get; set; }

        [JsonProperty("item_neutral")]
        public long ItemNeutral { get; set; }

        [JsonProperty("item_uses")]
        public Dictionary<string, long> ItemUses { get; set; }

        [JsonProperty("kill_streaks")]
        public Dictionary<string, long> KillStreaks { get; set; }

        [JsonProperty("killed")]
        public Dictionary<string, long> Killed { get; set; }

        [JsonProperty("killed_by")]
        public Dictionary<string, long> KilledBy { get; set; }

        [JsonProperty("kills")]
        public long Kills { get; set; }

        [JsonProperty("kills_log")]
        public KillsLog[] KillsLog { get; set; }

        [JsonProperty("lane_pos")]
        public Dictionary<string, Dictionary<string, long>> LanePos { get; set; }

        [JsonProperty("last_hits")]
        public long LastHits { get; set; }

        [JsonProperty("leaver_status")]
        public long LeaverStatus { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("lh_t")]
        public long[] LhT { get; set; }

        [JsonProperty("life_state")]
        public Dictionary<string, long> LifeState { get; set; }

        [JsonProperty("max_hero_hit")]
        public MaxHeroHit MaxHeroHit { get; set; }

        [JsonProperty("multi_kills")]
        public Dictionary<string, long> MultiKills { get; set; }

        [JsonProperty("net_worth")]
        public long NetWorth { get; set; }

        [JsonProperty("obs")]
        public Dictionary<string, Dictionary<string, long>> Obs { get; set; }

        [JsonProperty("obs_left_log")]
        public Log[] ObsLeftLog { get; set; }

        [JsonProperty("obs_log")]
        public Log[] ObsLog { get; set; }

        [JsonProperty("obs_placed")]
        public long ObsPlaced { get; set; }

        [JsonProperty("party_id")]
        public long PartyId { get; set; }

        [JsonProperty("party_size")]
        public long PartySize { get; set; }

        [JsonProperty("performance_others")]
        public PerformanceOthers PerformanceOthers { get; set; }

        [JsonProperty("permanent_buffs")]
        public PermanentBuff[] PermanentBuffs { get; set; }

        [JsonProperty("pings", NullValueHandling = NullValueHandling.Ignore)]
        public long? Pings { get; set; }

        [JsonProperty("pred_vict")]
        public bool PredVict { get; set; }

        [JsonProperty("purchase")]
        public Dictionary<string, long> Purchase { get; set; }

        [JsonProperty("purchase_log")]
        public PurchaseLog[] PurchaseLog { get; set; }

        [JsonProperty("randomed")]
        public bool Randomed { get; set; }

        [JsonProperty("repicked")]
        public object Repicked { get; set; }

        [JsonProperty("roshans_killed")]
        public long RoshansKilled { get; set; }

        [JsonProperty("rune_pickups")]
        public long RunePickups { get; set; }

        [JsonProperty("runes")]
        public Dictionary<string, long> Runes { get; set; }

        [JsonProperty("runes_log")]
        public RunesLog[] RunesLog { get; set; }

        [JsonProperty("sen")]
        public Dictionary<string, Dictionary<string, long>> Sen { get; set; }

        [JsonProperty("sen_left_log")]
        public Log[] SenLeftLog { get; set; }

        [JsonProperty("sen_log")]
        public Log[] SenLog { get; set; }

        [JsonProperty("sen_placed")]
        public long SenPlaced { get; set; }

        [JsonProperty("stuns")]
        public double Stuns { get; set; }

        [JsonProperty("teamfight_participation")]
        public double TeamfightParticipation { get; set; }

        [JsonProperty("times")]
        public long[] Times { get; set; }

        [JsonProperty("tower_damage")]
        public long TowerDamage { get; set; }

        [JsonProperty("towers_killed")]
        public long TowersKilled { get; set; }

        [JsonProperty("xp_per_min")]
        public long XpPerMin { get; set; }

        [JsonProperty("xp_reasons")]
        public Dictionary<string, long> XpReasons { get; set; }

        [JsonProperty("xp_t")]
        public long[] XpT { get; set; }

        [JsonProperty("personaname")]
        public string Personaname { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonProperty("radiant_win")]
        public bool RadiantWin { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("cluster")]
        public long Cluster { get; set; }

        [JsonProperty("lobby_type")]
        public long LobbyType { get; set; }

        [JsonProperty("game_mode")]
        public long GameMode { get; set; }

        [JsonProperty("is_contributor")]
        public bool IsContributor { get; set; }

        [JsonProperty("patch")]
        public long Patch { get; set; }

        [JsonProperty("region")]
        public long Region { get; set; }

        [JsonProperty("isRadiant")]
        public bool IsRadiant { get; set; }

        [JsonProperty("win")]
        public long Win { get; set; }

        [JsonProperty("lose")]
        public long Lose { get; set; }

        [JsonProperty("total_gold")]
        public long TotalGold { get; set; }

        [JsonProperty("total_xp")]
        public long TotalXp { get; set; }

        [JsonProperty("kills_per_min")]
        public double KillsPerMin { get; set; }

        [JsonProperty("kda")]
        public long Kda { get; set; }

        [JsonProperty("abandons")]
        public long Abandons { get; set; }

        [JsonProperty("neutral_kills")]
        public long NeutralKills { get; set; }

        [JsonProperty("tower_kills")]
        public long TowerKills { get; set; }

        [JsonProperty("courier_kills")]
        public long CourierKills { get; set; }

        [JsonProperty("lane_kills")]
        public long LaneKills { get; set; }

        [JsonProperty("hero_kills")]
        public long HeroKills { get; set; }

        [JsonProperty("observer_kills")]
        public long ObserverKills { get; set; }

        [JsonProperty("sentry_kills")]
        public long SentryKills { get; set; }

        [JsonProperty("roshan_kills")]
        public long RoshanKills { get; set; }

        [JsonProperty("necronomicon_kills")]
        public long NecronomiconKills { get; set; }

        [JsonProperty("ancient_kills")]
        public long AncientKills { get; set; }

        [JsonProperty("buyback_count")]
        public long BuybackCount { get; set; }

        [JsonProperty("observer_uses")]
        public long ObserverUses { get; set; }

        [JsonProperty("sentry_uses")]
        public long SentryUses { get; set; }

        [JsonProperty("lane_efficiency")]
        public double LaneEfficiency { get; set; }

        [JsonProperty("lane_efficiency_pct")]
        public long LaneEfficiencyPct { get; set; }

        [JsonProperty("lane")]
        public long Lane { get; set; }

        [JsonProperty("lane_role")]
        public long LaneRole { get; set; }

        [JsonProperty("is_roaming")]
        public bool IsRoaming { get; set; }

        [JsonProperty("purchase_time")]
        public Dictionary<string, long> PurchaseTime { get; set; }

        [JsonProperty("first_purchase_time")]
        public Dictionary<string, long> FirstPurchaseTime { get; set; }

        [JsonProperty("item_win")]
        public Dictionary<string, long> ItemWin { get; set; }

        [JsonProperty("item_usage")]
        public Dictionary<string, long> ItemUsage { get; set; }

        [JsonProperty("purchase_ward_observer", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseWardObserver { get; set; }

        [JsonProperty("purchase_ward_sentry", NullValueHandling = NullValueHandling.Ignore)]
        public long? PurchaseWardSentry { get; set; }

        [JsonProperty("purchase_tpscroll")]
        public long PurchaseTpscroll { get; set; }

        [JsonProperty("actions_per_min")]
        public long ActionsPerMin { get; set; }

        [JsonProperty("life_state_dead")]
        public long LifeStateDead { get; set; }

        [JsonProperty("rank_tier")]
        public long RankTier { get; set; }

        [JsonProperty("cosmetics")]
        public Cosmetic[] Cosmetics { get; set; }

        [JsonProperty("benchmarks")]
        public Benchmarks Benchmarks { get; set; }
    }

    public partial class AbilityTargets
    {
        [JsonProperty("vengefulspirit_magic_missile", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss VengefulspiritMagicMissile { get; set; }

        [JsonProperty("vengefulspirit_nether_swap", NullValueHandling = NullValueHandling.Ignore)]
        public VengefulspiritNetherSwap VengefulspiritNetherSwap { get; set; }

        [JsonProperty("gyrocopter_homing_missile", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss GyrocopterHomingMissile { get; set; }

        [JsonProperty("bounty_hunter_shuriken_toss", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss BountyHunterShurikenToss { get; set; }

        [JsonProperty("bounty_hunter_track", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss BountyHunterTrack { get; set; }

        [JsonProperty("tiny_toss_tree", NullValueHandling = NullValueHandling.Ignore)]
        public TinyTossTree TinyTossTree { get; set; }

        [JsonProperty("tiny_toss", NullValueHandling = NullValueHandling.Ignore)]
        public TinyToss TinyToss { get; set; }

        [JsonProperty("snapfire_firesnap_cookie", NullValueHandling = NullValueHandling.Ignore)]
        public AbilityTargetsSnapfireFiresnapCookie SnapfireFiresnapCookie { get; set; }

        [JsonProperty("slardar_amplify_damage", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt SlardarAmplifyDamage { get; set; }

        [JsonProperty("juggernaut_omni_slash", NullValueHandling = NullValueHandling.Ignore)]
        public JuggernautOmniSlash JuggernautOmniSlash { get; set; }

        [JsonProperty("rubick_fade_bolt", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt RubickFadeBolt { get; set; }

        [JsonProperty("rubick_telekinesis", NullValueHandling = NullValueHandling.Ignore)]
        public RubickTelekinesis RubickTelekinesis { get; set; }

        [JsonProperty("rubick_spell_steal", NullValueHandling = NullValueHandling.Ignore)]
        public RubickSpellSteal RubickSpellSteal { get; set; }
    }

    public partial class BountyHunterShurikenToss
    {
        [JsonProperty("npc_dota_hero_slardar", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_rubick", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_tiny", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroTiny { get; set; }

        [JsonProperty("npc_dota_hero_snapfire", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroSnapfire { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroJuggernaut { get; set; }

        [JsonProperty("npc_dota_hero_gyrocopter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroGyrocopter { get; set; }
    }

    public partial class JuggernautOmniSlash
    {
        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }
    }

    public partial class RubickFadeBolt
    {
        [JsonProperty("npc_dota_hero_shredder")]
        public long NpcDotaHeroShredder { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter")]
        public long NpcDotaHeroBountyHunter { get; set; }

        [JsonProperty("npc_dota_hero_vengefulspirit")]
        public long NpcDotaHeroVengefulspirit { get; set; }

        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }
    }

    public partial class RubickSpellSteal
    {
        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }

        [JsonProperty("npc_dota_hero_shredder")]
        public long NpcDotaHeroShredder { get; set; }
    }

    public partial class RubickTelekinesis
    {
        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_shredder")]
        public long NpcDotaHeroShredder { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter")]
        public long NpcDotaHeroBountyHunter { get; set; }
    }

    public partial class AbilityTargetsSnapfireFiresnapCookie
    {
        [JsonProperty("npc_dota_hero_snapfire")]
        public long NpcDotaHeroSnapfire { get; set; }

        [JsonProperty("npc_dota_hero_rubick")]
        public long NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut")]
        public long NpcDotaHeroJuggernaut { get; set; }
    }

    public partial class TinyToss
    {
        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }

        [JsonProperty("npc_dota_hero_vengefulspirit")]
        public long NpcDotaHeroVengefulspirit { get; set; }

        [JsonProperty("npc_dota_hero_slardar")]
        public long NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_rubick")]
        public long NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut")]
        public long NpcDotaHeroJuggernaut { get; set; }

        [JsonProperty("npc_dota_hero_shredder")]
        public long NpcDotaHeroShredder { get; set; }
    }

    public partial class TinyTossTree
    {
        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }
    }

    public partial class VengefulspiritNetherSwap
    {
        [JsonProperty("npc_dota_hero_slardar")]
        public long NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut")]
        public long NpcDotaHeroJuggernaut { get; set; }

        [JsonProperty("npc_dota_hero_tiny")]
        public long NpcDotaHeroTiny { get; set; }
    }

    public partial class Benchmarks
    {
        [JsonProperty("gold_per_min")]
        public Dictionary<string, double> GoldPerMin { get; set; }

        [JsonProperty("xp_per_min")]
        public Dictionary<string, double> XpPerMin { get; set; }

        [JsonProperty("kills_per_min")]
        public Dictionary<string, double> KillsPerMin { get; set; }

        [JsonProperty("last_hits_per_min")]
        public Dictionary<string, double> LastHitsPerMin { get; set; }

        [JsonProperty("hero_damage_per_min")]
        public Dictionary<string, double> HeroDamagePerMin { get; set; }

        [JsonProperty("hero_healing_per_min")]
        public Dictionary<string, double> HeroHealingPerMin { get; set; }

        [JsonProperty("tower_damage")]
        public Dictionary<string, double> TowerDamage { get; set; }

        [JsonProperty("stuns_per_min")]
        public Dictionary<string, double> StunsPerMin { get; set; }

        [JsonProperty("lhten")]
        public Dictionary<string, double> Lhten { get; set; }
    }

    public partial class Cosmetic
    {
        [JsonProperty("item_id")]
        public long ItemId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("prefab")]
        public Prefab Prefab { get; set; }

        [JsonProperty("creation_date")]
        public DateTimeOffset? CreationDate { get; set; }

        [JsonProperty("image_inventory")]
        public string ImageInventory { get; set; }

        [JsonProperty("image_path")]
        public string ImagePath { get; set; }

        [JsonProperty("item_description")]
        public string ItemDescription { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("item_rarity")]
        public string ItemRarity { get; set; }

        [JsonProperty("item_type_name")]
        public string ItemTypeName { get; set; }

        [JsonProperty("used_by_heroes")]
        public string UsedByHeroes { get; set; }
    }

    public partial class DamageTargets
    {
        [JsonProperty("vengefulspirit_magic_missile", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss VengefulspiritMagicMissile { get; set; }

        [JsonProperty("null")]
        public Dictionary<string, long> Null { get; set; }

        [JsonProperty("vengefulspirit_wave_of_terror", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss VengefulspiritWaveOfTerror { get; set; }

        [JsonProperty("gyrocopter_homing_missile", NullValueHandling = NullValueHandling.Ignore)]
        public GyrocopterHomingMissile GyrocopterHomingMissile { get; set; }

        [JsonProperty("gyrocopter_rocket_barrage", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss GyrocopterRocketBarrage { get; set; }

        [JsonProperty("gyrocopter_flak_cannon", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss GyrocopterFlakCannon { get; set; }

        [JsonProperty("gyrocopter_call_down", NullValueHandling = NullValueHandling.Ignore)]
        public GyrocopterCallDown GyrocopterCallDown { get; set; }

        [JsonProperty("maelstrom", NullValueHandling = NullValueHandling.Ignore)]
        public Maelstrom Maelstrom { get; set; }

        [JsonProperty("puck_illusory_orb", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss PuckIllusoryOrb { get; set; }

        [JsonProperty("puck_waning_rift", NullValueHandling = NullValueHandling.Ignore)]
        public PuckWaningRift PuckWaningRift { get; set; }

        [JsonProperty("puck_dream_coil", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss PuckDreamCoil { get; set; }

        [JsonProperty("dagon", NullValueHandling = NullValueHandling.Ignore)]
        public Dagon Dagon { get; set; }

        [JsonProperty("orb_of_venom", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, long> OrbOfVenom { get; set; }

        [JsonProperty("bounty_hunter_shuriken_toss", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss BountyHunterShurikenToss { get; set; }

        [JsonProperty("urn_of_shadows", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss UrnOfShadows { get; set; }

        [JsonProperty("shredder_timber_chain", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss ShredderTimberChain { get; set; }

        [JsonProperty("shredder_whirling_death", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss ShredderWhirlingDeath { get; set; }

        [JsonProperty("shredder_chakram", NullValueHandling = NullValueHandling.Ignore)]
        public BountyHunterShurikenToss ShredderChakram { get; set; }

        [JsonProperty("tiny_tree_grab", NullValueHandling = NullValueHandling.Ignore)]
        public TinyTreeGrab TinyTreeGrab { get; set; }

        [JsonProperty("tiny_avalanche", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt TinyAvalanche { get; set; }

        [JsonProperty("tiny_toss_tree", NullValueHandling = NullValueHandling.Ignore)]
        public TinyTossTree TinyTossTree { get; set; }

        [JsonProperty("tiny_toss", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt TinyToss { get; set; }

        [JsonProperty("snapfire_firesnap_cookie", NullValueHandling = NullValueHandling.Ignore)]
        public DamageTargetsSnapfireFiresnapCookie SnapfireFiresnapCookie { get; set; }

        [JsonProperty("snapfire_mortimer_kisses", NullValueHandling = NullValueHandling.Ignore)]
        public SnapfireMortimerKisses SnapfireMortimerKisses { get; set; }

        [JsonProperty("slardar_slithereen_crush", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt SlardarSlithereenCrush { get; set; }

        [JsonProperty("juggernaut_blade_fury", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt JuggernautBladeFury { get; set; }

        [JsonProperty("juggernaut_omni_slash", NullValueHandling = NullValueHandling.Ignore)]
        public JuggernautOmniSlash JuggernautOmniSlash { get; set; }

        [JsonProperty("rubick_fade_bolt", NullValueHandling = NullValueHandling.Ignore)]
        public RubickFadeBolt RubickFadeBolt { get; set; }
    }

    public partial class Dagon
    {
        [JsonProperty("npc_dota_hero_rubick")]
        public long NpcDotaHeroRubick { get; set; }
    }

    public partial class GyrocopterCallDown
    {
        [JsonProperty("npc_dota_hero_slardar")]
        public long NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_rubick")]
        public long NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut")]
        public long NpcDotaHeroJuggernaut { get; set; }
    }

    public partial class GyrocopterHomingMissile
    {
        [JsonProperty("npc_dota_hero_slardar", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_rubick", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_tiny", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroTiny { get; set; }

        [JsonProperty("npc_dota_hero_gyrocopter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroGyrocopter { get; set; }
    }

    public partial class Maelstrom
    {
        [JsonProperty("npc_dota_hero_tiny", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroTiny { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroJuggernaut { get; set; }

        [JsonProperty("npc_dota_hero_gyrocopter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_shredder", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroShredder { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroBountyHunter { get; set; }
    }

    public partial class PuckWaningRift
    {
        [JsonProperty("npc_dota_hero_tiny", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroTiny { get; set; }

        [JsonProperty("npc_dota_hero_slardar", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroSlardar { get; set; }

        [JsonProperty("npc_dota_hero_snapfire", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroSnapfire { get; set; }

        [JsonProperty("npc_dota_hero_juggernaut", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroJuggernaut { get; set; }

        [JsonProperty("npc_dota_hero_rubick", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroRubick { get; set; }

        [JsonProperty("npc_dota_hero_shredder", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroShredder { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroBountyHunter { get; set; }

        [JsonProperty("npc_dota_hero_vengefulspirit", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroVengefulspirit { get; set; }

        [JsonProperty("npc_dota_hero_gyrocopter", NullValueHandling = NullValueHandling.Ignore)]
        public long? NpcDotaHeroGyrocopter { get; set; }
    }

    public partial class DamageTargetsSnapfireFiresnapCookie
    {
        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter")]
        public long NpcDotaHeroBountyHunter { get; set; }

        [JsonProperty("npc_dota_hero_vengefulspirit")]
        public long NpcDotaHeroVengefulspirit { get; set; }
    }

    public partial class SnapfireMortimerKisses
    {
        [JsonProperty("npc_dota_hero_gyrocopter")]
        public long NpcDotaHeroGyrocopter { get; set; }

        [JsonProperty("npc_dota_hero_shredder")]
        public long NpcDotaHeroShredder { get; set; }

        [JsonProperty("npc_dota_hero_vengefulspirit")]
        public long NpcDotaHeroVengefulspirit { get; set; }
    }

    public partial class TinyTreeGrab
    {
        [JsonProperty("npc_dota_hero_puck")]
        public long NpcDotaHeroPuck { get; set; }

        [JsonProperty("npc_dota_hero_bounty_hunter")]
        public long NpcDotaHeroBountyHunter { get; set; }
    }

    public partial class KillsLog
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("tracked_death", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackedDeath { get; set; }

        [JsonProperty("tracked_sourcename", NullValueHandling = NullValueHandling.Ignore)]
        public TrackedSourcename? TrackedSourcename { get; set; }
    }

    public partial class MaxHeroHit
    {
        [JsonProperty("type")]
        public MaxHeroHitType Type { get; set; }

        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("max")]
        public bool Max { get; set; }

        [JsonProperty("inflictor")]
        public string Inflictor { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
    }

    public partial class Log
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("type")]
        public ObsLeftLogType Type { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("attackername", NullValueHandling = NullValueHandling.Ignore)]
        public string Attackername { get; set; }

        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("z")]
        public long Z { get; set; }

        [JsonProperty("entityleft")]
        public bool Entityleft { get; set; }

        [JsonProperty("ehandle")]
        public long Ehandle { get; set; }

        [JsonProperty("player_slot")]
        public long PlayerSlot { get; set; }
    }

    public partial class PerformanceOthers
    {
        [JsonProperty("tracked_deaths")]
        public long TrackedDeaths { get; set; }

        [JsonProperty("track_gold")]
        public long TrackGold { get; set; }
    }

    public partial class PermanentBuff
    {
        [JsonProperty("permanent_buff")]
        public long PermanentBuffPermanentBuff { get; set; }

        [JsonProperty("stack_count")]
        public long StackCount { get; set; }
    }

    public partial class PurchaseLog
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("charges", NullValueHandling = NullValueHandling.Ignore)]
        public long? Charges { get; set; }
    }

    public partial class RunesLog
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("key")]
        public long Key { get; set; }
    }

    public partial class Teamfight
    {
        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("last_death")]
        public long LastDeath { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("players")]
        public TeamfightPlayer[] Players { get; set; }
    }

    public partial class TeamfightPlayer
    {
        [JsonProperty("deaths_pos")]
        public Dictionary<string, Dictionary<string, long>> DeathsPos { get; set; }

        [JsonProperty("ability_uses")]
        public Dictionary<string, long> AbilityUses { get; set; }

        [JsonProperty("ability_targets")]
        public MyWordCounts AbilityTargets { get; set; }

        [JsonProperty("item_uses")]
        public Dictionary<string, long> ItemUses { get; set; }

        [JsonProperty("killed")]
        public PuckWaningRift Killed { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("buybacks")]
        public long Buybacks { get; set; }

        [JsonProperty("damage")]
        public long Damage { get; set; }

        [JsonProperty("healing")]
        public long Healing { get; set; }

        [JsonProperty("gold_delta")]
        public long GoldDelta { get; set; }

        [JsonProperty("xp_delta")]
        public long XpDelta { get; set; }

        [JsonProperty("xp_start")]
        public long XpStart { get; set; }

        [JsonProperty("xp_end")]
        public long XpEnd { get; set; }
    }

    public enum ChatType { BuybackLog, Chat, Chatwheel };

    public enum Prefab { Courier, Taunt, Ward, Wearable };

    public enum TrackedSourcename { NpcDotaHeroBountyHunter };

    public enum MaxHeroHitType { MaxHeroHit };

    public enum ObsLeftLogType { ObsLeftLog, ObsLog, SenLeftLog, SenLog };

    public partial struct Key
    {
        public long? Integer;
        public string String;

        public static implicit operator Key(long Integer) => new Key { Integer = Integer };
        public static implicit operator Key(string String) => new Key { String = String };
    }

    public partial class DotaMatchInfo
    {
        public static DotaMatchInfo FromJson(string json) => JsonConvert.DeserializeObject<DotaMatchInfo>(json, Models.MatchInfoConverter.Settings);
    }

    public static class MatchInfoSerialize
    {
        public static string ToJson(this DotaMatchInfo self) => JsonConvert.SerializeObject(self, Models.MatchInfoConverter.Settings);
    }

    internal static class MatchInfoConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                ChatTypeConverter.Singleton,
                KeyConverter.Singleton,
                PrefabConverter.Singleton,
                TrackedSourcenameConverter.Singleton,
                MaxHeroHitTypeConverter.Singleton,
                ObsLeftLogTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ChatTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChatType) || t == typeof(ChatType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "buyback_log":
                    return ChatType.BuybackLog;
                case "chat":
                    return ChatType.Chat;
                case "chatwheel":
                    return ChatType.Chatwheel;
            }
            throw new Exception("Cannot unmarshal type ChatType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChatType)untypedValue;
            switch (value)
            {
                case ChatType.BuybackLog:
                    serializer.Serialize(writer, "buyback_log");
                    return;
                case ChatType.Chat:
                    serializer.Serialize(writer, "chat");
                    return;
                case ChatType.Chatwheel:
                    serializer.Serialize(writer, "chatwheel");
                    return;
            }
            throw new Exception("Cannot marshal type ChatType");
        }

        public static readonly ChatTypeConverter Singleton = new ChatTypeConverter();
    }

    internal class KeyConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Key) || t == typeof(Key?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Key { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Key { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Key");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Key)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Key");
        }

        public static readonly KeyConverter Singleton = new KeyConverter();
    }

    internal class PrefabConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Prefab) || t == typeof(Prefab?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "courier":
                    return Prefab.Courier;
                case "taunt":
                    return Prefab.Taunt;
                case "ward":
                    return Prefab.Ward;
                case "wearable":
                    return Prefab.Wearable;
            }
            throw new Exception("Cannot unmarshal type Prefab");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Prefab)untypedValue;
            switch (value)
            {
                case Prefab.Courier:
                    serializer.Serialize(writer, "courier");
                    return;
                case Prefab.Taunt:
                    serializer.Serialize(writer, "taunt");
                    return;
                case Prefab.Ward:
                    serializer.Serialize(writer, "ward");
                    return;
                case Prefab.Wearable:
                    serializer.Serialize(writer, "wearable");
                    return;
            }
            throw new Exception("Cannot marshal type Prefab");
        }

        public static readonly PrefabConverter Singleton = new PrefabConverter();
    }

    internal class TrackedSourcenameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TrackedSourcename) || t == typeof(TrackedSourcename?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "npc_dota_hero_bounty_hunter")
            {
                return TrackedSourcename.NpcDotaHeroBountyHunter;
            }
            throw new Exception("Cannot unmarshal type TrackedSourcename");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TrackedSourcename)untypedValue;
            if (value == TrackedSourcename.NpcDotaHeroBountyHunter)
            {
                serializer.Serialize(writer, "npc_dota_hero_bounty_hunter");
                return;
            }
            throw new Exception("Cannot marshal type TrackedSourcename");
        }

        public static readonly TrackedSourcenameConverter Singleton = new TrackedSourcenameConverter();
    }

    internal class MaxHeroHitTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MaxHeroHitType) || t == typeof(MaxHeroHitType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "max_hero_hit")
            {
                return MaxHeroHitType.MaxHeroHit;
            }
            throw new Exception("Cannot unmarshal type MaxHeroHitType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MaxHeroHitType)untypedValue;
            if (value == MaxHeroHitType.MaxHeroHit)
            {
                serializer.Serialize(writer, "max_hero_hit");
                return;
            }
            throw new Exception("Cannot marshal type MaxHeroHitType");
        }

        public static readonly MaxHeroHitTypeConverter Singleton = new MaxHeroHitTypeConverter();
    }

    internal class ObsLeftLogTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ObsLeftLogType) || t == typeof(ObsLeftLogType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "obs_left_log":
                    return ObsLeftLogType.ObsLeftLog;
                case "obs_log":
                    return ObsLeftLogType.ObsLog;
                case "sen_left_log":
                    return ObsLeftLogType.SenLeftLog;
                case "sen_log":
                    return ObsLeftLogType.SenLog;
            }
            throw new Exception("Cannot unmarshal type ObsLeftLogType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ObsLeftLogType)untypedValue;
            switch (value)
            {
                case ObsLeftLogType.ObsLeftLog:
                    serializer.Serialize(writer, "obs_left_log");
                    return;
                case ObsLeftLogType.ObsLog:
                    serializer.Serialize(writer, "obs_log");
                    return;
                case ObsLeftLogType.SenLeftLog:
                    serializer.Serialize(writer, "sen_left_log");
                    return;
                case ObsLeftLogType.SenLog:
                    serializer.Serialize(writer, "sen_log");
                    return;
            }
            throw new Exception("Cannot marshal type ObsLeftLogType");
        }

        public static readonly ObsLeftLogTypeConverter Singleton = new ObsLeftLogTypeConverter();
    }
}



