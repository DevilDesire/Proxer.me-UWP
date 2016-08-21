using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class StreamValue : IStreamValue
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Uploader { get; set; }
        public string Username { get; set; }
        public int Timestamp { get; set; }
        public int? Tid { get; set; }
        public string Tname { get; set; }
        public string Htype { get; set; }
        public string Sid { get; set; }
        public string Replace { get; set; }
    }
}