using System.Collections.Generic;

namespace ProxerMeApi.Interfaces.Values
{
    public interface IBaseCollectionValue<T>
    {
        int Error { get; set; } 
        string Message { get; set; }
        List<T> Data { get; set; }
    }
}