using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Getter;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Getter
{
    public class NotificationGetter : ProxerMeApiBase, INotificationGetter
    {
        public IBaseValue<INewsValue> GetNews(string apiVersion, string apiKey)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetNotificationNewsUrl(apiVersion), PostParamGetter.GetNewsParams(apiKey));
            BaseValue<NewsValue> baseValue = JsonConvert.DeserializeObject<BaseValue<NewsValue>>(retval);

            return new BaseValue<INewsValue>
            {
                Error = baseValue.Error,
                Message = baseValue.Message,
                Data = new List<INewsValue>(baseValue.Data)
            };
        }
    }
}