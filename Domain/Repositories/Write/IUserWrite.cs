namespace Domain.Repositories.Write
{
    public interface IUserWrite
    {
        User Inserir(User pessoa);
        User Atualizar(User pessoa);
    }
}