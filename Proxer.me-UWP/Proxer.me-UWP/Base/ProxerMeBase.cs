using ProxerMeApi.Implementation.Getter;
using ProxerMeApi.Interfaces.Getter;

namespace Proxer.me_UWP.Base
{
    public static class ProxerMeBase
    {
        internal static INotificationGetter NotificationGetter => new NotificationGetter();
    }
}