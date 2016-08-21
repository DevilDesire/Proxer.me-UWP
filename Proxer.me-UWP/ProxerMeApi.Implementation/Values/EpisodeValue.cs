using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class EpisodeValue : IEpisodeValue
    {
        public int No { get; set; }
        public string Typ { get; set; }
        public object Types { get; set; }
        public object Typeimg { get; set; }
    }
}