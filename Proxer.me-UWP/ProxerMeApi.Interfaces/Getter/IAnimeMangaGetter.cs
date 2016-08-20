using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface IAnimeMangaGetter
    {
        List<IAnimeMangaSeasonValue> GetSeason(int animeMangaId);
        List<IAnimeMangaPublisherValue> GetPublisher(int animeMangaId);
        List<IAnimeMangaNameValue> GetNames(int animeMangaId);
        List<IAnimeMangaGroupValue> GetGroups(int animeMangaId);
    }
}