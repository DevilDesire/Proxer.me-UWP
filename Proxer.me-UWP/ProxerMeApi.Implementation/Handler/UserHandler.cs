using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Handler;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Handler
{
    public class UserHandler : ProxerMeApiBase, IUserHandler
    {
        public IBaseValue<IUserLoginValue> DoLogin(string username, string password, string apiKey)
        {
            Dictionary<string, string> postParams = PostParamGetter.GetUserLoginParams(username, password, apiKey);
            string retval= Network.LoadUrlPost("https://proxer.me/api/v1/user/login", postParams, StaticValues.CookieContainer);
            BaseValue<UserLoginValue> baseValue = JsonConvert.DeserializeObject<BaseValue<UserLoginValue>>(retval);
            return new BaseValue<IUserLoginValue>
            {
                Error = baseValue.Error,
                Message = baseValue.Message,
                Data = baseValue.Data
            };
        }

        public void DoLogout()
        {
            throw new NotImplementedException();
        }
    }
}