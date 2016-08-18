using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Enums;
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

        public IBaseCollectionValue<IConferenceMessageValue> GetMessagesFromConferenceByConferenceId(int conferenceId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetConferencesGetMessagesUrl(StaticValues.ApiVersion), PostParamGetter.GetMessagesParams(conferenceId, null, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<ConferenceMessageValue> baseValue = JsonConvert.DeserializeObject<BaseCollectionValue<ConferenceMessageValue>>(retval);

            return new BaseCollectionValue<IConferenceMessageValue>
            {
                Error = baseValue.Error,
                Message = baseValue.Message,
                Data = SetUserStates(baseValue.Data)
            };
        }

        public void SetMessage(int conferenceId, string message)
        {
            Network.LoadUrlPost(UrlGetter.GetConferencesSetMessageUrl(StaticValues.ApiVersion), PostParamGetter.GetSetMessageParams(conferenceId, message, StaticValues.ApiToken), StaticValues.CookieContainer);
        }

        private List<IConferenceMessageValue> SetUserStates(List<ConferenceMessageValue> baseList)
        {
            List<IConferenceMessageValue> retval = new List<IConferenceMessageValue>(baseList);

            foreach (IConferenceMessageValue conferenceMessageValue in retval)
            {
                conferenceMessageValue.Side = conferenceMessageValue.User_Id == StaticValues.UserId
                    ? ConversationSide.Me
                    : ConversationSide.You;
            }

            return retval;
        }
    }
}