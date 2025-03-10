namespace CustomerAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public Task<T> AddEntity(T Entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(long Key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllValues()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntityById(long Key)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateEntity(T Entity)
        {
            throw new NotImplementedException();
        }
    }
    {
    }
}
