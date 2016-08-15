using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface IPostParamGetter
    {
        Dictionary<string, string> GetNewsParams(string apiKey);
        Dictionary<string, string> GetUserLoginParams(string username, string password, string apiKey);
        Dictionary<string, string> GetBaseParams(string apiKey);
    }
}