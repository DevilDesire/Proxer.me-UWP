namespace ProxerMeApi.Interfaces.Values
{
    public interface IAnimeMangaKommentarValue
    {
        int Id { get; set; }
        int Tid { get; set; }
        string Type { get; set; }
        int State { get; set; }
        string Data { get; set; }
        string Comment { get; set; }
        int Rating { get; set; }
        string Episode { get; set; }
        int Positive { get; set; }
        int Timestamp { get; set; }
        string Username { get; set; }
        int Uid { get; set; }
        string Avatar { get; set; }
    }
}