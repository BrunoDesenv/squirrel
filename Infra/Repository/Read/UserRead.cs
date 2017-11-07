using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Domain.Repositories.Read;
using MongoDB.Driver;
using Repository.Cache;

namespace Repository.Read
{
    public class UserRead : IUserRead
    {

        public IEnumerable<string> Teste(){
            var _client = new MongoClient("mongodb://squirrel:tntRd4R6pX6i4HN1PCE1hGcUgkFViR5UGpyG8DABh1BZUpOlufj8lkGVCETHKdG3zgoHhnJ9EGRBVJws6rf0hg==@squirrel.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
            var _server = _client.GetServer();
            var _db = _server.GetDatabase("Cuzao");  

            
            return _db.GetCollectionNames();
        }

        public IReadOnlyCollection<User> Listar()
                => UserCache.Listar();

        public User ObterPorId(Guid id)
        {   
            var todos = UserCache.Listar();
            return todos.FirstOrDefault(p => p.Id.Equals(id));
        }
    }
}