using System;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class UserLoginValue : IUserLoginValue
    {
        private string m_Avatar;

        public int Uid { get; set; }

        public string Avatar
        {
            get
            {
                return string.IsNullOrEmpty(m_Avatar) ? "" : m_Avatar;
            }
            set
            {
                m_Avatar = string.Format("http://cdn.proxer.me/avatar/tn/{0}", value);
            }
        }

        public string Token { get; set; }
    }
}