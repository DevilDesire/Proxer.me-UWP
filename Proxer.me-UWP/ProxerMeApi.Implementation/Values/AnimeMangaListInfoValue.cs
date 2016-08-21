using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaListInfoValue<T> : IAnimeMangaListInfoValue<T>
    {
        public int Start { get; set; }
        public int End { get; set; }
        public string Kat { get; set; }
        public List<string> Lang { get; set; }
        public string State { get; set; }
        public List<T> Episodes { get; set; }
    }
}