using StructureCompany.Models;
using System.Linq.Expressions;

namespace StructureCompany.IRegistory
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Person> Persons { get; }
        IGenericRepository<Node> Nodes { get; }

        Task SaveAsync();
    }
}
