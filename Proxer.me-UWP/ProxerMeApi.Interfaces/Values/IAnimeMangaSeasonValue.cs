namespace ProxerMeApi.Interfaces.Values
{
    public interface IAnimeMangaSeasonValue
    {
        int Id { get; set; }
        int Eid { get; set; }
        string Type { get; set; }
        string Year { get; set; }
        int Season { get; set; }
    }
}