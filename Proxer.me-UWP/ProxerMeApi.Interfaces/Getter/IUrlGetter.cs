namespace ProxerMeApi.Interfaces.Getter
{
    public interface IUrlGetter
    {
        #region GetNotification

        string GetNotificationCountUrl(string apiVersion);
        string GetNotificationNewsUrl(string apiVersion);
        string GetNotificationDeleteUrl(string apiVersion);

        #endregion

        #region GetConferences

        string GetConferencesGetConstantsUrl(string apiVersion);
        string GetConferencesGetConferencesUrl(string apiVersion);
        string GetConferencesGetConferenceInfoUrl(string apiVersion);
        string GetConferencesGetUserInfoUrl(string apiVersion);
        string GetConferencesGetMessagesUrl(string apiVersion);
        string GetConferencesNewConferenceUrl(string apiVersion);
        string GetConferencesNewConferenceGroupUrl(string apiVersion);
        string GetConferencesSetReportUrl(string apiVersion);
        string GetConferencesSetMessageUrl(string apiVersion);
        string GetConferencesSetUnreadUrl(string apiVersion);
        string GetConferencesSetBlockUrl(string apiVersion);
        string GetConferencesSetUnblockUrl(string apiVersion);
        string GetConferencesSetFavourUrl(string apiVersion);
        string GetConferencesSetUnfavourUrl(string apiVersion);

        #endregion
    }
}