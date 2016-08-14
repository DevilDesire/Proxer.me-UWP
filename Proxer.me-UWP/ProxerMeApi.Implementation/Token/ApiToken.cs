using ProxerMeApi.Interfaces.Token;

namespace ProxerMeApi.Implementation.Token
{
    public class ApiToken : IApiToken
    {
        public string ApiTokenKey { get; set; }
        public string ApiVersion { get; set; }
    }
}