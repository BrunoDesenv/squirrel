namespace Repository.Read
{
    public class UserRead : IUserRead
    {
        public IReadOnlyCollection<User> Listar()
                => Cache.Repositorio.Listar();

        public User ObterPorId(Guid id)
        {   
            var todos = Cache.Repositorio.Listar();
            return todos.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}