namespace ProxerMeApi.Interfaces.Values
{
    public interface IStreamValue
    {
        int Id { get; set; }
        string Type { get; set; } 
        string Name { get; set; }
        string Image { get; set; }
        int Uploader { get; set; }
        string Username { get; set; }
        int Timestamp { get; set; }
        int? Tid { get; set; }
        string Tname { get; set; }
        string Htype { get; set; }
        string Sid { get; set; }
        string Replace { get; set; }
    }
}