using System;

public class MessageService : IMessageService
{
    public void SendMessage(string message)
    {
         
        Console.WriteLine("Received message: " + message);
    }
}
