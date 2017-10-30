public interface IUserRead
{
    IReadOnlyCollection<User> Listar();
    User ObterPorId(Guid id);
}