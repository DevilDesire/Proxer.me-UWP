using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface IPostParamGetter
    {
        Dictionary<string, string> GetNewsParams(string apiKey);
    }
}