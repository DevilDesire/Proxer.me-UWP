namespace ProxerMeApi.Interfaces.Values
{
    public interface IBaseValue
    {
        string error { get; set; } 
        string message { get; set; }
        string code { get; set; }
    }
}