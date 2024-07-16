using StructureCompany.IRegistory;
using StructureCompany.Models;

namespace StructureCompany.Registory
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IGenericRepository<Person> _persons;

        private IGenericRepository<Node> _nodes;

        public IGenericRepository<Person> Persons => _persons ??= new GenericRepository<Person>(_context);
        public IGenericRepository<Node> Nodes => _nodes ??= new GenericRepository<Node>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

    }
}
