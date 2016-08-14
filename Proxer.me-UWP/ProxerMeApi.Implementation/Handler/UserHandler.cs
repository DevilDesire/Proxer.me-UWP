using System.Collections.Generic;
using DevilDesireDevLib.Implementation.Networking;
using DevilDesireDevLib.Interfaces.Networking;
using ProxerMeApi.Interfaces.Handler;

namespace ProxerMeApi.Implementation.Handler
{
    public class UserHandler : IUserHandler
    {
        public void DoLogin(string username, string password)
        {
            Dictionary<string, string> postParams = new Dictionary<string, string>
            {
                {"username", username },
                { "password", password },
                { "api_key", "" }
            };

            INetwork network = new Network();
            string retval= network.LoadUrlPost("https://proxer.me/api/v1/user/login", postParams);
        }

        public void DoLogout()
        {
            throw new System.NotImplementedException();
        }
    }
}