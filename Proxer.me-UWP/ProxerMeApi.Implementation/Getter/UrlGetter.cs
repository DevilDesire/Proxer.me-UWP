using ProxerMeApi.Implementation.Utils;
using ProxerMeApi.Interfaces.Getter;

namespace ProxerMeApi.Implementation.Getter
{
    public class UrlGetter : IUrlGetter
    {
        public string GetNotificationCountUrl(string apiVersion)
        {
            return string.Format(UrlCollection.NotificationGetCount, apiVersion); 
        }

        public string GetNotificationNewsUrl(string apiVersion)
        {
            return string.Format(UrlCollection.NotificationGetNews, apiVersion);
        }

        public string GetNotificationDeleteUrl(string apiVersion)
        {
            return string.Format(UrlCollection.NotificationDelete, apiVersion);
        }
    }
}