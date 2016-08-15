namespace ProxerMeApi.Interfaces.Values
{
    public interface IUserLoginValue
    {
        int Uid { get; set; }
        string Avatar { get; set; }
        string Token { get; set; } 
    }
}