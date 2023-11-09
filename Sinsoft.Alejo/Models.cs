#nullable enable

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sinsoft.Alejo
{
    [Serializable]
    public partial class Pronoun
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("singular")]
        public bool Singular { get; set; }
    }

    [Serializable]
    public partial class PronounUser
    {
        [JsonProperty("channel_id")]
        public int ChannelId { get; set; }

        [JsonProperty("channel_login")]
        public string ChannelLogin { get; set; }

        [JsonProperty("pronoun_id")]
        public string PronounId { get; set; }

        [JsonProperty("alt_pronoun_id")]
        public string? AltPronounId { get; set; }
    }

    [Serializable]
    public partial class HealthCheck
    {
        [JsonProperty("cache-keys")]
        public List<string> CacheKeys { get; set; }

        [JsonProperty("cache-size")]
        public long CacheSize { get; set; }

        [JsonProperty("cache-status")]
        public Status CacheStatus { get; set; }

        [JsonProperty("db-pronouns")]
        public List<DbPronoun> DbPronouns { get; set; }

        [JsonProperty("db-status")]
        public Status DbStatus { get; set; }

        [JsonProperty("feature_flags")]
        public FeatureFlags FeatureFlags { get; set; }

        [JsonProperty("redis-status")]
        public Status RedisStatus { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    [Serializable]
    public partial class DbPronoun : Pronoun
    {
        [JsonProperty("ID")]
        public long Id { get; set; }
    }

    [Serializable]
    public partial class FeatureFlags
    {
        [JsonProperty("FEATURE_FLAG_PUBLIC")]
        public bool FeatureFlagPublic { get; set; }
    }
}
