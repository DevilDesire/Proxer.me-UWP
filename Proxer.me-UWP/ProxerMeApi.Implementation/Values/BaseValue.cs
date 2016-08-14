using System.Collections.Generic;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Values
{
    public class BaseValue<T> : IBaseValue<T>
    {
        public List<T> Data { get; set; }

        public int Error { get; set; }

        public string Message { get; set; }
    }
}