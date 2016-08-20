using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface IPostParamGetter
    {
        Dictionary<string, string> GetNewsParams(string apiKey);
        Dictionary<string, string> GetUserLoginParams(string username, string password, string apiKey);
        Dictionary<string, string> GetBaseParams(string apiKey);
        Dictionary<string, string> GetMessagesParams(int? conferenceId, int? messageId, string apiKey);
        Dictionary<string, string> GetSetMessageParams(int conferenceId, string message, string apiKey);
        Dictionary<string, string> GetAnimeMangaGetEntryParams(int animeMangaId, string apiKey);
        Dictionary<string, string> GetAnimeMangaGetSeasonParams(int animeMangaId, string apiKey);
        Dictionary<string, string> GetAnimeMangaGetNamesParams(int animeMangaId, string apiKey);
        Dictionary<string, string> GetAnimeMangaGetGroupsParams(int animeMangaId, string apiKey);
        Dictionary<string, string> GetAnimeMangaGetPublisherParams(int animeMangaId, string apiKey);
    }
}