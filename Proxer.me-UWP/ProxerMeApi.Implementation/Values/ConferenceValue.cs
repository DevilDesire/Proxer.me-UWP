using System;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class ConferenceValue : IConferenceValue
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Topic_Custom { get; set; }
        public int Count { get; set; }
        public bool Group { get; set; }
        public int Timestamp_End { get; set; }
        public bool Read { get; set; }
        public int Read_Count { get; set; }
        public string Read_Mid { get; set; }

        private string m_Image ;

        public string Image
        {
            get
            {
                return string.IsNullOrEmpty(m_Image) ? "" : m_Image;
            }
            set
            {
                string imageString = value.Replace("avatar:","");
                m_Image = string.Format("http://cdn.proxer.me/avatar/tn/{0}", imageString);
            }
        }
    }
}