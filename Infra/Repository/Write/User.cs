public class User : IUser
{
    public Domain.Pessoa Inserir(Domain.Pessoa pessoa)
    {
        Cache.Repositorio.Inserir(pessoa);
        return pessoa;
    }

    public Domain.Pessoa Atualizar(Domain.Pessoa pessoa)
    {
        Cache.Repositorio.Atualizar(pessoa);
        return pessoa;
    }
}