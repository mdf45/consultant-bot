using System.Text.Json;

namespace Consultant.Bot.Utility
{
    public static class JsonUtility
    {
        public static JsonSerializerOptions JsonOptions { get; } = new() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };

        public static string GetJson<T>(T data) => JsonSerializer.Serialize(data, JsonOptions);
        public static T GetData<T>(string json) => JsonSerializer.Deserialize<T>(json, JsonOptions);
    }
}
