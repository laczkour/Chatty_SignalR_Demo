namespace Chatty.Api.Hubs
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);  
    }
}
