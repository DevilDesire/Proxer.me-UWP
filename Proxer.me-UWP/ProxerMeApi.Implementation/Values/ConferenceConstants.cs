using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class ConferenceConstants : IConferenceConstants
    {
        public int TextCount { get; set; }
        public int ConferenceLimit { get; set; }
        public int MessagesLimit { get; set; }
        public int UserLimit { get; set; }
        public int TopicCount { get; set; }
    }
}