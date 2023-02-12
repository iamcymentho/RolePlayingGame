using System.Text.Json.Serialization;

namespace RolePlayingGame.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RolePlayingGame
    {
        Knight = 1,
        Mage = 2,
        Claric = 3,

    }
}