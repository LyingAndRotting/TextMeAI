using TextMeAI.Domain.Entities.Base;

namespace TextMeAI.Domain.Entities;

public class User : BaseEntity
{
    public User(string name, string phoneNumber, string? email, string password)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
        Password = password;
    }

    public string Name {get; set;}
    public string PhoneNumber {get; set;}
    public string? Email {get; set;}
    public string Password {get; set;}
    
}