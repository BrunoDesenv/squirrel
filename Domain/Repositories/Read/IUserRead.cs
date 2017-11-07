using System;
using System.Collections.Generic;
using Domain.Model;

namespace Domain.Repositories.Read
{
    public interface IUserRead
    {
        IReadOnlyCollection<User> Listar();
        User ObterPorId(Guid id);

        IEnumerable<string> Teste();
    }
}