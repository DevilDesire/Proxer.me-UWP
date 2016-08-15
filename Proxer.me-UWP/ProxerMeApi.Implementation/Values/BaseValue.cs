using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class BaseValue<T> : IBaseValue<T>
    {
        public int Error { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}