using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Handler
{
    public interface IAnimeHandler
    {
        IAnimeMangaValue GetEntry(int id);
        void SetSeason(IAnimeMangaValue animeMangaValue);
        void SetNames(IAnimeMangaValue animeMangaValue);
        void SetGroups(IAnimeMangaValue animeMangaValue);
        void SetPublisher(IAnimeMangaValue animeMangaValue);
        IAnimeMangaListInfoValue<IEpisodeValue> GetEpisodes(int animeMangaId);
        List<IAnimeMangaKommentarValue> GetComments(int animeMangaId);
    }
}