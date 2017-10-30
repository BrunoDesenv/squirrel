public class User : IUser
{
    public User Inserir(User user)
    {
        Cache.Repositorio.Inserir(user);
        return user;
    }

    public User Atualizar(User user)
    {
        Cache.Repositorio.Atualizar(user);
        return user;
    }
}