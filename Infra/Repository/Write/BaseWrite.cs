using System;
using Domain.Model;
using Domain.Repositories.Write;
using Domain.ValueObjects;
using MongoDB.Driver;

namespace Repository.Write
{
    public class BaseWrite<TEntity> : IBaseWrite<TEntity> where TEntity : ModelBase
    {
        public BaseWrite(string collectionName)
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
        void IBaseWrite<TEntity>.Add(TEntity entity)
        {
            var collection = _db.GetCollection<TEntity>(_collectionName);

            collection.InsertOne(entity);
        }

        void IBaseWrite<TEntity>.Update(TEntity entity)
        {
            var collection = _db.GetCollection<TEntity>(_collectionName);

            var filter = Builders<TEntity>.Filter.Eq("id", entity.Id);

            var UpdateAllObj = Builders<TEntity>.Update
                .Set(x => x, entity);


            collection.UpdateOne(filter, UpdateAllObj);
        }

        void IBaseWrite<TEntity>.Delete(Guid id)
        {
            var collection = _db.GetCollection<TEntity>(_collectionName);
             var filter = Builders<TEntity>.Filter.Eq("id", id);

            collection.DeleteOne(filter);
        }
    }
}