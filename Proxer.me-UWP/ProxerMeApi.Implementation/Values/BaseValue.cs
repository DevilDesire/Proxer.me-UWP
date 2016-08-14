using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class BaseValue : IBaseValue
    {
        public string error { get; set; }
        public string message { get; set; }
        public string code { get; set; }
    }
}