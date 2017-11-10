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
    public class UserRead : BaseRead<User>, IUserRead
    {
        private const string COLLECTION_NAME = "User";
        public UserRead(string collectionName = COLLECTION_NAME) : base(collectionName)
        {
        }
    }
}