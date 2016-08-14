using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Values
{
    public interface IInfoValue
    {
        string id { get; set; }
        string name { get; set; }
        List<string> genre { get; set; }
        List<string> fsk { get; set; }
        string description { get; set; }
        string medium { get; set; }
        string count { get; set; }
        string state { get; set; }
        string rate_sum { get; set; }
        string rate_count { get; set; }
        string clicks { get; set; }
        string license { get; set; }
    }
}