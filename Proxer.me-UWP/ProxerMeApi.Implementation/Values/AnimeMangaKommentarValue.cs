using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class AnimeMangaKommentarValue : IAnimeMangaKommentarValue
    {
        private string m_Avatar;
        public int Id { get; set; }
        public int Tid { get; set; }
        public string Type { get; set; }
        public int State { get; set; }
        public string Data { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public string Episode { get; set; }
        public int Positive { get; set; }
        public int Timestamp { get; set; }
        public string Username { get; set; }
        public int Uid { get; set; }

        public string Avatar
        {
            get { return string.Format("https://cdn.proxer.me/avatar/tn/{0}", m_Avatar); }
            set { m_Avatar = value; }
        }
    }
}