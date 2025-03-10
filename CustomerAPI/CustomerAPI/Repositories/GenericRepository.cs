using CustomerAPI.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private CustomerContext _customerContext;
        private DbSet<T> _dbSet;

        //Depenedncy Injection
        public GenericRepository(CustomerContext customerContext){

            _customerContext = customerContext;
            _dbSet = _customerContext.Set<T>();

            }

        
        public async Task<T> AddEntity(T Entity)
        {
            //saved the object to table
           var result= await _dbSet.AddAsync(Entity);
            //saved changes in the table
            await _customerContext.SaveChangesAsync();
            return result.Entity;

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
