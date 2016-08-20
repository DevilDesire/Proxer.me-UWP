using DevilDesireDevLib.Implementation.Networking;
using DevilDesireDevLib.Interfaces.Networking;
using ProxerMeApi.Implementation.Getter;
using ProxerMeApi.Interfaces.Getter;

namespace ProxerMeApi.Implementation
{
    public class ProxerMeApiBase
    {
        protected INetwork Network => new Network();
        protected IUrlGetter UrlGetter => new UrlGetter();
        protected IPostParamGetter PostParamGetter => new PostParamGetter();
        protected IAnimeMangaGetter AnimeMangaGetter => new AnimeMangaGetter();
    }
}