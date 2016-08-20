using System.Collections.Generic;
using System.Linq;
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

        public void SetSeason(IAnimeMangaValue animeMangaValue)
        {
            animeMangaValue.Season = AnimeMangaGetter.GetSeason(animeMangaValue.Id);
        }

        public void SetNames(IAnimeMangaValue animeMangaValue)
        {
            List<IAnimeMangaNameValue> retval = AnimeMangaGetter.GetNames(animeMangaValue.Id);
            animeMangaValue.JName = retval.Where(x => x.Type == "namejap").Select(x => x.Name).First();
        }

        public void SetGroups(IAnimeMangaValue animeMangaValue)
        {
            animeMangaValue.Groups = AnimeMangaGetter.GetGroups(animeMangaValue.Id);
        }

        public void SetPublisher(IAnimeMangaValue animeMangaValue)
        {
            animeMangaValue.Publisher = AnimeMangaGetter.GetPublisher(animeMangaValue.Id);
        }
    }
}