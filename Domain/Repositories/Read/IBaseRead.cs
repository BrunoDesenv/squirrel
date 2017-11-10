using System;
using System.Collections.Generic;

namespace Domain.Repositories.Read
{
    public interface IBaseRead<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}