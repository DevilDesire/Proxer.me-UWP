using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Values
{
    public interface IAnimeMangaValue
    {
        int Id { get; set; }
        string Name { get; set; }
        string GerName { get; set; }
        string JName { get; set; }
        string Genre { get; set; }
        string Fsk { get; set; }
        string Description { get; set; }
        string Medium { get; set; }
        List<IAnimeMangaSeasonValue> Season { get; set; }
        List<IAnimeMangaGroupValue> Groups { get; set; }
        List<IAnimeMangaPublisherValue> Publisher { get; set; }
        string Tags { get; set; }
        int Count { get; set; }
        int State { get; set; }
        int Rate_Sum { get; set; }
        int Rate_Count { get; set; }
        int Clicks { get; set; }
        string Kat { get; set; }
        int License { get; set; }
        string ImageUrl { get; }
    }
}