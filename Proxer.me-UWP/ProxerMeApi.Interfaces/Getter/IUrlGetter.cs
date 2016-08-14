namespace ProxerMeApi.Interfaces.Getter
{
    public interface IUrlGetter
    {
        string GetNotificationCountUrl(string apiVersion);
        string GetNotificationNewsUrl(string apiVersion);
        string GetNotificationDeleteUrl(string apiVersion);
    }
}