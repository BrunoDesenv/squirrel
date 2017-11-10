using System;
using System.Collections.Generic;
using Domain.Repositories.Read;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using Domain.Model;

namespace Repository.Read
{
    public class BaseRead<TEntity> : IBaseRead<TEntity> where TEntity : ModelBase
    {
        public BaseRead(string collectionName)
        {
            _client = new MongoClient(CONNECTION_STRING);
            _db = _client.GetDatabase(DATABASE_AZURE);
            _collectionName = collectionName;
        }

        private string _collectionName;
        private MongoClient _client; 
        private IMongoDatabase _db;
        private const string CONNECTION_STRING = "mongodb://squirrel:tntRd4R6pX6i4HN1PCE1hGcUgkFViR5UGpyG8DABh1BZUpOlufj8lkGVCETHKdG3zgoHhnJ9EGRBVJws6rf0hg==@squirrel.documents.azure.com:10255/?ssl=true&replicaSet=globaldb";
        private const string DATABASE_AZURE = "1";
      
        TEntity IBaseRead<TEntity>.GetById(Guid id)
        {
            var collection = _db.GetCollection<TEntity>(_collectionName);
            
            var result = collection.AsQueryable().Where(x=>x.Id == id );

             return result.FirstOrDefault();
        }

        IEnumerable<TEntity> IBaseRead<TEntity>.GetAll()
        {
              var collection = _db.GetCollection<TEntity>(_collectionName);

             return collection.Find(_ => true).ToList();
        }
    }
}