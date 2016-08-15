using System.Collections.Generic;
using ProxerMeApi.Interfaces.Getter;

namespace ProxerMeApi.Implementation.Getter
{
    public class PostParamGetter : IPostParamGetter
    {
        private void AddApiToken(Dictionary<string, string> postParams, string apiKey)
        {
            postParams.Add("api_key", apiKey);
        }

        public Dictionary<string, string> GetNewsParams(string apiKey)
        {
            Dictionary<string, string> postParams = new Dictionary<string, string>();
            AddApiToken(postParams, apiKey);
            return postParams;
        }

        public Dictionary<string, string> GetUserLoginParams(string username, string password, string apiKey)
        {
            Dictionary<string, string> postParams = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };

            AddApiToken(postParams, apiKey);

            return postParams;
        }

        public Dictionary<string, string> GetBaseParams(string apiKey)
        {
            Dictionary<string, string> postParams = new Dictionary<string, string>();
            AddApiToken(postParams, apiKey);

            return postParams;
        }
    }
}