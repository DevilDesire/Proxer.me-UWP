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
            ExceptionHandler.CheckForCaptcha(baseCollection.Message);

            return new List<IAnimeMangaSeasonValue>(baseCollection.Data);
        }

        public List<IAnimeMangaPublisherValue> GetPublisher(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetPublisherUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetPublisherParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaPublisherValue> baseCollection = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaPublisherValue>>(retval);
            ExceptionHandler.CheckForCaptcha(baseCollection.Message);

            return new List<IAnimeMangaPublisherValue>(baseCollection.Data);
        }

        public List<IAnimeMangaNameValue> GetNames(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetNamesUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetSeasonParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaNameValue> baseValue = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaNameValue>>(retval);
            ExceptionHandler.CheckForCaptcha(baseValue.Message);

            return new List<IAnimeMangaNameValue>(baseValue.Data);
        }

        public List<IAnimeMangaGroupValue> GetGroups(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetGroupsUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetGroupsParams(animeMangaId,StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaGroupValue> baseCollection = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaGroupValue>>(retval);
            ExceptionHandler.CheckForCaptcha(baseCollection.Message);

            return new List<IAnimeMangaGroupValue>(baseCollection.Data);
        }

        public List<IStreamValue> GetProxerStreams(int animeMangaId, string episode, string language)
        {
            throw new NotImplementedException();
        }

        public List<IStreamValue> GetStreams(int animeMangaId, string episode, string language)
        {
            throw new NotImplementedException();
        }

        public void IncrementStreamCount(int streamId)
        {
            throw new NotImplementedException();
        }

        public IAnimeMangaListInfoValue<IEpisodeValue> GetListinfo(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetListinfoUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetListinfoParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseValue<AnimeMangaListInfoValue<EpisodeValue>> baseValue = JsonConvert.DeserializeObject<BaseValue<AnimeMangaListInfoValue<EpisodeValue>>>(retval);
            ExceptionHandler.CheckForCaptcha(baseValue.Message);

            return new AnimeMangaListInfoValue<IEpisodeValue>
            {
                Start = baseValue.Data.Start,
                End = baseValue.Data.End,
                Kat = baseValue.Data.Kat,
                Lang = baseValue.Data.Lang,
                State = baseValue.Data.State,
                Episodes = new List<IEpisodeValue>(baseValue.Data.Episodes)
            };
        }

        public List<IAnimeMangaKommentarValue> GetComments(int animeMangaId)
        {
            string retval = Network.LoadUrlPost(UrlGetter.GetAnimeMangaGetCommentsUrl(StaticValues.ApiVersion), PostParamGetter.GetAnimeMangaGetCommentsParams(animeMangaId, StaticValues.ApiToken), StaticValues.CookieContainer);
            BaseCollectionValue<AnimeMangaKommentarValue> baseCollectionValue = JsonConvert.DeserializeObject<BaseCollectionValue<AnimeMangaKommentarValue>>(retval);
            ExceptionHandler.CheckForCaptcha(baseCollectionValue.Message);

            return new List<IAnimeMangaKommentarValue>(baseCollectionValue.Data);
        }
    }
}