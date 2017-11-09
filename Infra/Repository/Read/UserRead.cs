using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Model;
using Domain.Repositories.Read;
using MongoDB.Driver;
using Repository.Cache;
using Domain.ValueObjects;
using MongoDB.Bson;

namespace Repository.Read
{
    public class UserRead : IUserRead
    {

        public List<User> Teste()
        {
            var bases = new List<string>();
            var _client = new MongoClient("mongodb://squirrel:tntRd4R6pX6i4HN1PCE1hGcUgkFViR5UGpyG8DABh1BZUpOlufj8lkGVCETHKdG3zgoHhnJ9EGRBVJws6rf0hg==@squirrel.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
            var email = new Email("a@a.com");
            var cpf = new CPF("1112235465464");
            var nomeCompleto = new NomeCompleto("Aciole", "Carmo");
            var user = new User(Guid.NewGuid(), nomeCompleto, cpf, email);
            
            var collection = _client.GetDatabase("1").GetCollection<User>("User");
        
 
            //collection.InsertOne(user);
            
            return collection.Find(x=>x.Nome == user.Nome).ToList();

             
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