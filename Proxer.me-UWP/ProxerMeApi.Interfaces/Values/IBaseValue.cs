namespace ProxerMeApi.Interfaces.Values
{
    public interface IBaseValue<T>
    {
        int Error { get; set; }
        string Message { get; set; }
        T Data { get; set; }
    }
}