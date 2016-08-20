using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaSeasonValue : IAnimeMangaSeasonValue
    {
        public int Id { get; set; }
        public int Eid { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public int Season { get; set; }
    }
}