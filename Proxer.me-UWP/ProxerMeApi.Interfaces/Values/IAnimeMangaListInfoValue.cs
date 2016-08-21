using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Values
{
    public interface IAnimeMangaListInfoValue<T>
    {
        int Start { get; set; }
        int End { get; set; }
        string Kat { get; set; }
        List<string> Lang { get; set; }
        string State { get; set; }
        List<T> Episodes { get; set; }
    }
}