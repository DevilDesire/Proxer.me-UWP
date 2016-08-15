using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Handler
{
    public interface IConferenceHandler
    {
        IBaseCollectionValue<IConferenceValue> GetAllConferences();
        void GetConferenceById(int conferenceId);
        void GetUserFromConverenceByConferenceId(int conferenceId);
        void GetMessagesFromConferenceByConferenceId(int conferenceId);
    }
}