using System.ComponentModel.DataAnnotations.Schema;

namespace TextMeAI.Domain.Entities.Chat;
[NotMapped]
public class Message
{
    public Message(string text, string author, DateTime date)
    {
        Text = text;
        Author = author;
        Date = date;
    }

    public string Text {get; set;}
    public string Author {get; set;}
    public DateTime Date {get; set;}
}