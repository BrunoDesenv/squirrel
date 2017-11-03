public class BaseRead<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
{
   protected ExemploContext Db = new ExemploContext();


    MongoClient _client;
    MongoServer _server;
    MongoDatabase _db;

    public DataAccess()
    {
        _client = new MongoClient("mongodb://localhost:27017");
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
