namespace ProxerMeApi.Interfaces.Values
{
    public interface IConferenceValue
    {
        int Id { get; set; }
        string Topic { get; set; }
        string Topic_Custom { get; set; }
        int Count { get; set; }
        bool Group { get; set; }
        int Timestamp_End { get; set; }
        bool Read { get; set; }
        int Read_Count { get; set; }
        string Read_Mid { get; set; }
        string Image { get; set; }
    }
}