namespace CustomerAPI.Repositories
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> AddEntity(T Entity); //create
        Task<IEnumerable<T>> GetAllValues(); //retrieve
        bool DeleteEntity(long Key); //delete
        Task<T> UpdateEntity(T Entity); //update
        Task<T> GetEntityById(long Key);
    }
}
