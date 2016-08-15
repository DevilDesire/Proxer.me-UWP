using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Handler
{
    public interface IUserHandler
    {
        IBaseValue<IUserLoginValue> DoLogin(string username, string password, string apiKey);
        void DoLogout();
    }
}