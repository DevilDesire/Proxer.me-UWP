using System.Net;

namespace ProxerMeApi.Implementation.Statics
{
    public static class StaticValues
    {
        public static CookieContainer CookieContainer { get; set; }
        public static string ApiVersion { get; set; }
        public static string ApiToken { get; set; }
        public static int UserId { get; set; }
    }
}