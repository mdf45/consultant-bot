namespace Consultant.API.Data
{
    public static class Conf
    {
        public static void Init(string apiKey)
        {
            ApiKey = apiKey;

            Console.WriteLine($"ApiKey: {apiKey}");
        }

        public static string ApiKey { get; private set; }
    }
}
