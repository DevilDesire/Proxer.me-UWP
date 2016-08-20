using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Getter;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Getter
{
    public class AnimeMangaGetter :  ProxerMeApiBase, IAnimeMangaGetter
    {
        public List<IAnimeMangaSeasonValue> GetSeason(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetSeasonUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetSeasonParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaSeasonValue> baseCollection = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaSeasonValue>>(retval);

            return new List<IAnimeMangaSeasonValue>(baseCollection.Data);
        }

        public List<IAnimeMangaPublisherValue> GetPublisher(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetPublisherUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetPublisherParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaPublisherValue> baseCollection = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaPublisherValue>>(retval);

            return new List<IAnimeMangaPublisherValue>(baseCollection.Data);
        }

        public List<IAnimeMangaNameValue> GetNames(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetNamesUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetSeasonParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaNameValue> baseValue = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaNameValue>>(retval);

            return new List<IAnimeMangaNameValue>(baseValue.Data);
        }

        public List<IAnimeMangaGroupValue> GetGroups(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetGroupsUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetGroupsParams(animeMangaId,StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaGroupValue> baseCollection = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaGroupValue>>(retval);

            return new List<IAnimeMangaGroupValue>(baseCollection.Data);
        }
    }
}