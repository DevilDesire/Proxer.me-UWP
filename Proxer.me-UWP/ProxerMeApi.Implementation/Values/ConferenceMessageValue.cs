using ProxerMeApi.Interfaces.Enums;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class ConferenceMessageValue : IConferenceMessageValue
    {
        public int Message_Id { get; set; }
        public int Conference_Id { get; set; }
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
        public int Timestamp { get; set; }
        public string Device { get; set; }
        public ConversationSide Side { get; set; }
        public ConversationSide PrevSide { get; set; }
    }
}