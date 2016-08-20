using ProxerMeApi.Implementation.Utils;
using ProxerMeApi.Interfaces.Getter;

namespace ProxerMeApi.Implementation.Getter
{
    public class UrlGetter : IUrlGetter
    {
        #region GetNotification

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

        #endregion

        #region GetConferences
        public string GetConferencesGetConstantsUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesGetConstantsUrl, apiVersion); 
        }

        public string GetConferencesGetConferencesUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesGetConferencesUrl, apiVersion); 
        }

        public string GetConferencesGetConferenceInfoUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesGetConferenceInfoUrl, apiVersion); 
        }

        public string GetConferencesGetUserInfoUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesGetUserInfoUrl, apiVersion); 
        }

        public string GetConferencesGetMessagesUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesGetMessagesUrl, apiVersion); 
        }

        public string GetConferencesNewConferenceUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesNewConferenceUrl, apiVersion); 
        }

        public string GetConferencesNewConferenceGroupUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesNewConferenceGroupUrl, apiVersion); 
        }

        public string GetConferencesSetReportUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetReportUrl, apiVersion); 
        }

        public string GetConferencesSetMessageUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetMessageUrl, apiVersion); 
        }

        public string GetConferencesSetUnreadUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetUnreadUrl, apiVersion); 
        }

        public string GetConferencesSetBlockUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetBlockUrl, apiVersion); 
        }

        public string GetConferencesSetUnblockUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetUnblockUrl, apiVersion); 
        }

        public string GetConferencesSetFavourUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetFavourUrl, apiVersion); 
        }

        public string GetConferencesSetUnfavourUrl(string apiVersion)
        {
            return string.Format(UrlCollection.ConferencesSetUnfavourUrl, apiVersion); 
        }

        #endregion

        #region Anime Manga

        public string GetAnimeMangaGetEntryUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetEntryUrl, apiVersion);
        }

        public string GetAnimeMangaGetSeasonUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetSeasonUrl, apiVersion);
        }

        public string GetAnimeMangaGetPublisherUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetPublisherUrl, apiVersion);
        }

        public string GetAnimeMangaGetLanguageUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetLanguageUrl, apiVersion);
        }

        public string GetAnimeMangaGetNamesUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetNamesUrl, apiVersion);
        }

        public string GetAnimeMangaGetGroupsUrl(string apiVersion)
        {
            return string.Format(UrlCollection.AnimeMangaGetGroupsUrl, apiVersion);
        }

        #endregion
    }
}