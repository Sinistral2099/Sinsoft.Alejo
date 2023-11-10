#nullable enable

using Newtonsoft.Json;
using System;

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
    public partial class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("pronoun_id")]
        public string PronounId { get; set; }
    }
}
