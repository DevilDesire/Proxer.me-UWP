using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaNameValue : IAnimeMangaNameValue
    {
        public int Id { get; set; }
        public int Eid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}