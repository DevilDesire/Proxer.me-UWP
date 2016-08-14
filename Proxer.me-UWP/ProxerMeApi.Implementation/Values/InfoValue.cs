using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class InfoValue : IInfoValue
    {
        public string id { get; set; }
        public string name { get; set; }
        public List<string> genre { get; set; }
        public List<string> fsk { get; set; }
        public string description { get; set; }
        public string medium { get; set; }
        public string count { get; set; }
        public string state { get; set; }
        public string rate_sum { get; set; }
        public string rate_count { get; set; }
        public string clicks { get; set; }
        public string license { get; set; }
    }
}