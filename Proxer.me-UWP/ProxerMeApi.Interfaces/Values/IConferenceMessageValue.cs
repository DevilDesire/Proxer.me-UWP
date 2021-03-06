﻿using ProxerMeApi.Interfaces.Enums;

namespace ProxerMeApi.Interfaces.Values
{
    public interface IConferenceMessageValue
    {
        int Message_Id { get; set; }
        int Conference_Id { get; set; }
        int User_Id { get; set; }
        string Username { get; set; }
        string Message { get; set; }
        string Action { get; set; }
        int Timestamp { get; set; }
        string Device { get; set; } 
        ConversationSide Side { get; set; }
        ConversationSide PrevSide { get; set; }
    }
}