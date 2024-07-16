using AutoMapper;
using StructureCompany.DTO;
using StructureCompany.IRegistory;

namespace StructureCompany.Patterns.Strategy
{
    public interface IAssignable
    {
        Task Execute(IUnitOfWork unit, IMapper map, PersonDTO personDTO);
    }
}
