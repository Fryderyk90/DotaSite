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
    public partial class DotaHero
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localized_name")]
        public string LocalizedName { get; set; }

        [JsonProperty("primary_attr")]
        public PrimaryAttr PrimaryAttr { get; set; }

        [JsonProperty("attack_type")]
        public AttackType AttackType { get; set; }

        [JsonProperty("roles")]
        public Role[] Roles { get; set; }

        [JsonProperty("legs")]
        public long Legs { get; set; }
    }

    public enum AttackType { Melee, Ranged };

    public enum PrimaryAttr { Agi, Int, Str };

    public enum Role { Carry, Disabler, Durable, Escape, Initiator, Jungler, Nuker, Pusher, Support };

    public partial class DotaHero
    {
        public static DotaHero[] FromJson(string json) => JsonConvert.DeserializeObject<DotaHero[]>(json, HeroConverter.Settings);
    }

    public static class HeroSerialize
    {
        public static string ToJson(this DotaHero[] self) => JsonConvert.SerializeObject(self, HeroConverter.Settings);
    }

    internal static class HeroConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                AttackTypeConverter.Singleton,
                PrimaryAttrConverter.Singleton,
                RoleConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AttackTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AttackType) || t == typeof(AttackType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Melee":
                    return AttackType.Melee;
                case "Ranged":
                    return AttackType.Ranged;
            }
            throw new Exception("Cannot unmarshal type AttackType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AttackType)untypedValue;
            switch (value)
            {
                case AttackType.Melee:
                    serializer.Serialize(writer, "Melee");
                    return;
                case AttackType.Ranged:
                    serializer.Serialize(writer, "Ranged");
                    return;
            }
            throw new Exception("Cannot marshal type AttackType");
        }

        public static readonly AttackTypeConverter Singleton = new AttackTypeConverter();
    }

    internal class PrimaryAttrConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PrimaryAttr) || t == typeof(PrimaryAttr?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "agi":
                    return PrimaryAttr.Agi;
                case "int":
                    return PrimaryAttr.Int;
                case "str":
                    return PrimaryAttr.Str;
            }
            throw new Exception("Cannot unmarshal type PrimaryAttr");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PrimaryAttr)untypedValue;
            switch (value)
            {
                case PrimaryAttr.Agi:
                    serializer.Serialize(writer, "agi");
                    return;
                case PrimaryAttr.Int:
                    serializer.Serialize(writer, "int");
                    return;
                case PrimaryAttr.Str:
                    serializer.Serialize(writer, "str");
                    return;
            }
            throw new Exception("Cannot marshal type PrimaryAttr");
        }

        public static readonly PrimaryAttrConverter Singleton = new PrimaryAttrConverter();
    }

    internal class RoleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Role) || t == typeof(Role?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Carry":
                    return Role.Carry;
                case "Disabler":
                    return Role.Disabler;
                case "Durable":
                    return Role.Durable;
                case "Escape":
                    return Role.Escape;
                case "Initiator":
                    return Role.Initiator;
                case "Jungler":
                    return Role.Jungler;
                case "Nuker":
                    return Role.Nuker;
                case "Pusher":
                    return Role.Pusher;
                case "Support":
                    return Role.Support;
            }
            throw new Exception("Cannot unmarshal type Role");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Role)untypedValue;
            switch (value)
            {
                case Role.Carry:
                    serializer.Serialize(writer, "Carry");
                    return;
                case Role.Disabler:
                    serializer.Serialize(writer, "Disabler");
                    return;
                case Role.Durable:
                    serializer.Serialize(writer, "Durable");
                    return;
                case Role.Escape:
                    serializer.Serialize(writer, "Escape");
                    return;
                case Role.Initiator:
                    serializer.Serialize(writer, "Initiator");
                    return;
                case Role.Jungler:
                    serializer.Serialize(writer, "Jungler");
                    return;
                case Role.Nuker:
                    serializer.Serialize(writer, "Nuker");
                    return;
                case Role.Pusher:
                    serializer.Serialize(writer, "Pusher");
                    return;
                case Role.Support:
                    serializer.Serialize(writer, "Support");
                    return;
            }
            throw new Exception("Cannot marshal type Role");
        }

        public static readonly RoleConverter Singleton = new RoleConverter();
    }
}



