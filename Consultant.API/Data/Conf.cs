namespace Consultant.API.Data
{
    public static class Conf
    {
        public static void Init(string apiKey)
        {
            ApiKey = apiKey;
        }

        public static string ApiKey { get; private set; }
    }
}
