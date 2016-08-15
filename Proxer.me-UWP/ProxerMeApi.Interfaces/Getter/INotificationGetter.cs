using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Interfaces.Getter
{
    public interface INotificationGetter
    {
        IBaseCollectionValue<INewsValue> GetNews(string apiVersion, string apiKey);
    }
}