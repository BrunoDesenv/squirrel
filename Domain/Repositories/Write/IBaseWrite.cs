using System;
using Domain.Model;

namespace Domain.Repositories.Write
{
    public interface IBaseWrite<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);

        void Delete(Guid id);
         
    }
}