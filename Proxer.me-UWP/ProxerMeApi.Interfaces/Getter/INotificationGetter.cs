using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface INotificationGetter
    {
        IBaseValue<INewsValue> GetNews(string apiVersion, string apiKey);
    }
}