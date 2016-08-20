using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaPublisherValue : IAnimeMangaPublisherValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
    }
}