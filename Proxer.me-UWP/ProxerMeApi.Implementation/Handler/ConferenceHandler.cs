using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Token;
using ProxerMeApi.Interfaces.Handler;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Handler
{
    public class ConferenceHandler : ProxerMeApiBase, IConferenceHandler
    {
        public void GetAllConferences()
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetConferencesGetConferencesUrl(StaticValues.ApiVersion), PostParamGetter.GetNewsParams(StaticValues.ApiToken), StaticValues.CookieContainer);
            IBaseCollectionValue<IConferenceValue> baseValue = JsonConvert.DeserializeObject<IBaseCollectionValue<IConferenceValue>>(retval);
            if (baseValue != null)
            {
                
            }
        }

        public void GetConferenceById(int conferenceId)
        {
            throw new System.NotImplementedException();
        }

        public void GetUserFromConverenceByConferenceId(int conferenceId)
        {
            throw new System.NotImplementedException();
        }

        public void GetMessagesFromConferenceByConferenceId(int conferenceId)
        {
            throw new System.NotImplementedException();
        }
    }
}