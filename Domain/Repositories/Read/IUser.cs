public interface IUser
{
    IReadOnlyCollection<User> Listar();
    User ObterPorId(Guid id);
}