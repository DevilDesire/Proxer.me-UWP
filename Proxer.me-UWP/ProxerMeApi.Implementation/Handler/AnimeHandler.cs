using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Handler;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Handler
{
    public class AnimeHandler : ProxerMeApiBase, IAnimeHandler
    {
        public IAnimeMangaValue GetEntry(int id)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetEntryUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetEntryParams(id, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseValue<AnimeMangaValue> baseValue = JsonConvert.DeserializeObject<BaseValue<AnimeMangaValue>>(retval);

            return baseValue.Data;
        }
    }
}