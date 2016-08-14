namespace ProxerMeApi.Implementation.Utils
{
    public static class UrlCollection
    {
         public static string BaseUrl = "https://proxer.me/api/";

        #region Notifications

        public static string NotificationGetCount = "https://proxer.me/api/{0}/notifications/count";
        public static string NotificationGetNews = "https://proxer.me/api/{0}/notifications/news";
        public static string NotificationDelete = "https://proxer.me/api/{0}/notifications/delete";

        #endregion
    }
}