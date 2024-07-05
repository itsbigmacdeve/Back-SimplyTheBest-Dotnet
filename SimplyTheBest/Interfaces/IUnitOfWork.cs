namespace SimplyTheBest.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository _UserRepository { get; }
    }
}