using System.Collections.Generic;
using DevilDesireDevLib.Implementation.Networking;
using DevilDesireDevLib.Interfaces.Networking;
using ProxerMeApi.Interfaces.Getter;

namespace ProxerMeApi.Implementation.Getter
{
    public class NotificationGetter : INotificationGetter
    {
        private INetwork m_Network = new Network();
        public void GetNews()
        {
        }
    }
}