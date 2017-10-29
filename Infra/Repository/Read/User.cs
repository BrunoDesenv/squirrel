public class User : IUser
{
    public IReadOnlyCollection<User> Listar()
            => Cache.Repositorio.Listar();

    public Domain.Pessoa ObterPorId(Guid id)
    {   
        var todos = Cache.Repositorio.Listar();
        return todos.FirstOrDefault(p => p.Id.Equals(id));
    }
}