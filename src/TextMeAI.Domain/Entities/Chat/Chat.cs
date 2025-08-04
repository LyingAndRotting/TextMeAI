using TextMeAI.Domain.Entities.Base;

namespace TextMeAI.Domain.Entities.Chat;

public class Chat : BaseEntity
{
    public List<Message> Messages {get; set;}
    public Chat()
    {
        
    }

    #region Navigation
        public ICollection<User> User {get; set;}
    #endregion
}