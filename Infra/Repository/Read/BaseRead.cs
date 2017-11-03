namespace Repository.Read
{
    public class BaseRead<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        protected ExemploContext Db = new ExemploContext();


        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;

        public DataAccess()
        {
            _client = new MongoClient("mongodb://squirrel:tntRd4R6pX6i4HN1PCE1hGcUgkFViR5UGpyG8DABh1BZUpOlufj8lkGVCETHKdG3zgoHhnJ9EGRBVJws6rf0hg==@squirrel.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
            _server = _client.GetServer();
            _db = _server.GetDatabase("EmployeeDB");      
        }
    
        public void Add(TEntity obj)
        { 
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAllAsNoTracking()
        {
            return Db.Set<TEntity>().AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}