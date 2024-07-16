using System.Linq.Expressions;


namespace StructureCompany.IRegistory
{
    public interface IGenericRepository<T> where T : class
    {
      
        Task<T> Get(Expression<Func<T, bool>> expression = null,
            Expression<Func<T, object>> include = null);
        Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null,
            Expression<Func<T, object>> include = null);
        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
        
    }
}
