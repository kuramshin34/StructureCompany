using Microsoft.EntityFrameworkCore;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using System.Linq.Expressions;

namespace StructureCompany.Registory
{
   
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        private readonly DbSet<T> _db;

        public async Task Delete(int id)
        {
            var entity = await _db.FindAsync(id);
            if (entity == null)
            {
                return;
            }
            _db.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            if (entities == null)
            {
                return;
            }

            _db.RemoveRange(entities);
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression, Expression<Func<T, object>> include = null)
        {
            IQueryable<T> query = _db;
            if (include != null)
            {
                query = query.Include(include);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Expression<Func<T, object>> include = null)
        {
            IQueryable<T> query = _db;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                query = query.Include(include);   
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task Insert(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _db.AddRangeAsync(entities);
        }

        public void Update(T entity)
        {
            _context.ChangeTracker.Clear();
            var trackedEntities = _context.ChangeTracker.Entries();

            _db.Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }
    }
    
}
