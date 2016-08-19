using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Handler
{
    public interface IAnimeHandler
    {
        IAnimeMangaValue GetEntry(int id);
    }
}