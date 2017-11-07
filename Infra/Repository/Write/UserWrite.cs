using Domain.Model;
using Domain.Repositories.Write;

namespace Repository.Write
{
    public class UserWrite : IUserWrite
    {
        public User Inserir(User user)
        {
            Inserir(user);
            return user;
        }

        public User Atualizar(User user)
        {
            Atualizar(user);
            return user;
        }
    }
}