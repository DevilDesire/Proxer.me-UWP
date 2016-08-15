using System.Net;

namespace ProxerMeApi.Interfaces.Token
{
    public interface IApiToken
    {
        string ApiTokenKey { get; set; } 
        string ApiVersion { get; set; }
    }
}