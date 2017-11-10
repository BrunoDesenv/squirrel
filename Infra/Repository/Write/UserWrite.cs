using Domain.Model;
using Domain.Repositories.Write;

namespace Repository.Write
{
    public class UserWrite : BaseWrite<User>, IUserWrite
    {
        private const string COLLECTION_NAME = "User";
        public UserWrite(string collectionName = COLLECTION_NAME) : base(collectionName)
        {
        }
    }
}