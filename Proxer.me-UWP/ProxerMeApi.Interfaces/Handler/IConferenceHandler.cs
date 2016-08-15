namespace ProxerMeApi.Interfaces.Handler
{
    public interface IConferenceHandler
    {
        void GetAllConferences();
        void GetConferenceById(int conferenceId);
        void GetUserFromConverenceByConferenceId(int conferenceId);
        void GetMessagesFromConferenceByConferenceId(int conferenceId);
    }
}