using TextMeAI.API.Interfaces.Repository;

namespace TextMeAI.API.Interfaces;

public interface IUnitOfWork
{
    public IUserRepository UserRepository { get; }
    public IChatRepository ChatRepository { get; }
}