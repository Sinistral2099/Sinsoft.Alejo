using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Sinsoft.Alejo
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        [EnumMember(Value = "twitch")]
        Twitch,
        [EnumMember(Value = "youtube")]
        YouTube
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        [EnumMember(Value = "OK")]
        OK,
        [EnumMember(Value = "OFFLINE")]
        Offline,
        [EnumMember(Value = "ERROR")]
        Error
    }
}
