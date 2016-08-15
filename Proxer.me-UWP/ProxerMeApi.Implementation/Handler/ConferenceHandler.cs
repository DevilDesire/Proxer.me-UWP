using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Handler;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Handler
{
    public class ConferenceHandler : ProxerMeApiBase, IConferenceHandler
    {
        public IBaseCollectionValue<IConferenceValue> GetAllConferences()
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetConferencesGetConferencesUrl(StaticValues.ApiVersion), PostParamGetter.GetNewsParams(StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<ConferenceValue> baseValue = JsonConvert.DeserializeObject<BaseCollectionValue<ConferenceValue>>(retval);
            
            return new BaseCollectionValue<IConferenceValue>
            {
                Error = baseValue.Error,
                Message = baseValue.Message,
                Data = new List<IConferenceValue>(baseValue.Data)
            };
        }

        public void GetConferenceById(int conferenceId)
        {
            throw new NotImplementedException();
        }

        public void GetUserFromConverenceByConferenceId(int conferenceId)
        {
            throw new NotImplementedException();
        }

        public void GetMessagesFromConferenceByConferenceId(int conferenceId)
        {
            throw new NotImplementedException();
        }
    }
}