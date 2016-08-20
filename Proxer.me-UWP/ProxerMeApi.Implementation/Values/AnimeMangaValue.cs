using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaValue : IAnimeMangaValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GerName { get; set; }
        public string JName { get; set; }
        public string Genre { get; set; }
        public string Fsk { get; set; }
        public string Description { get; set; }
        public string Medium { get; set; }
        public List<IAnimeMangaSeasonValue> Season { get; set; }
        public List<IAnimeMangaGroupValue> Groups { get; set; }
        public List<IAnimeMangaPublisherValue> Publisher { get; set; }
        public string Tags { get; set; }
        public int Count { get; set; }
        public int State { get; set; }
        public int Rate_Sum { get; set; }
        public int Rate_Count { get; set; }
        public int Clicks { get; set; }
        public string Kat { get; set; }
        public int License { get; set; }

        public string ImageUrl => string.Format("http://cdn.proxer.me/cover/{0}.jpg", Id);
    }
}