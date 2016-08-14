namespace ProxerMeApi.Interfaces.Handler
{
    public interface IUserHandler
    {
        void DoLogin(string username, string password);
        void DoLogout();
    }
}