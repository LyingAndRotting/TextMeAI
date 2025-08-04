namespace TextMeAI.Domain.Entities.Base;

public class BaseEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id {get; set;}
}