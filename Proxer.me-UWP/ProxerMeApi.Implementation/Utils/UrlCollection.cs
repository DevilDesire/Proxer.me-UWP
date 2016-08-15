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

        #region GetConferences

        public static string ConferencesGetConstantsUrl = "https://proxer.me/api/{0}/messenger/constants";
        public static string ConferencesGetConferencesUrl = "https://proxer.me/api/{0}/messenger/conferences";
        public static string ConferencesGetConferenceInfoUrl = "https://proxer.me/api/{0}/messenger/conferenceinfo";
        public static string ConferencesGetUserInfoUrl = "https://proxer.me/api/{0}/messenger/userinfo";
        public static string ConferencesGetMessagesUrl = "https://proxer.me/api/{0}/messenger/messages";
        public static string ConferencesNewConferenceUrl = "https://proxer.me/api/{0}/messenger/newconference";
        public static string ConferencesNewConferenceGroupUrl = "https://proxer.me/api/{0}/messenger/newconferencegroup";
        public static string ConferencesSetReportUrl = "https://proxer.me/api/{0}/messenger/report";
        public static string ConferencesSetMessageUrl = "https://proxer.me/api/{0}/messenger/setmessage";
        public static string ConferencesSetUnreadUrl = "https://proxer.me/api/{0}/messenger/setunread";
        public static string ConferencesSetBlockUrl = "https://proxer.me/api/{0}/messenger/setblock";
        public static string ConferencesSetUnblockUrl = "https://proxer.me/api/{0}/messenger/setunblock";
        public static string ConferencesSetFavourUrl = "https://proxer.me/api/{0}/messenger/setfavour";
        public static string ConferencesSetUnfavourUrl = "https://proxer.me/api/{0}/messenger/setunfavour";

        #endregion
    }
}