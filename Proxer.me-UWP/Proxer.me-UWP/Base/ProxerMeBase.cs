using ProxerMeApi.Implementation.Getter;
using ProxerMeApi.Implementation.Handler;
using ProxerMeApi.Interfaces.Getter;
using ProxerMeApi.Interfaces.Handler;

namespace Proxer.me_UWP.Base
{
    public static class ProxerMeBase
    {
        internal static INotificationGetter NotificationGetter => new NotificationGetter();
        internal static IConferenceHandler ConferenceHandler => new ConferenceHandler();
        internal static IAnimeHandler AnimeHandler => new AnimeHandler();
    }
}