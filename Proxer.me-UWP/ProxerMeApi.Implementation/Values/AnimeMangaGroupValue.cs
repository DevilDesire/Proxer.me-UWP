using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaGroupValue : IAnimeMangaGroupValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}