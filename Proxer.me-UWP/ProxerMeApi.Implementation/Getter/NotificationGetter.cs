using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Getter;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Getter
{
    public class NotificationGetter : ProxerMeApiBase, INotificationGetter
    {
        public IBaseCollectionValue<INewsValue> GetNews(string apiVersion, string apiKey)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetNotificationNewsUrl(apiVersion), PostParamGetter.GetNewsParams(apiKey));
            BaseCollectionValue<NewsValue> baseCollectionValue = JsonConvert.DeserializeObject<BaseCollectionValue<NewsValue>>(retval);
            ExceptionHandler.CheckForCaptcha(baseCollectionValue.Message);

            return new BaseCollectionValue<INewsValue>
            {
                Error = baseCollectionValue.Error,
                Message = baseCollectionValue.Message,
                Data = new List<INewsValue>(baseCollectionValue.Data)
            };
        }
    }
}