using AutoMapper;
using Serilog;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;

namespace StructureCompany.Patterns.Strategy
{
    public class AssignedEmployee : IAssignable
    {
        private readonly NodeDTO _node;

        public async Task Execute(IUnitOfWork unit, IMapper map, PersonDTO personDTO)
        {
            if (_node == null)
            {
                Log.Information("Должность не закрепилась");
                throw new Exception("Должность не закрепилась");
            }

            if (_node.PersonId != null)
            {

                Log.Information($"У данной должности {_node.Name} уже есть сотрудник " +
                    $"[{_node.Person.FirstName} {_node.Person.LastName} {_node.Person.MiddleName}].");
                throw new Exception($"У данной должности {_node.Name} уже есть сотрудник " +
                    $"[{_node.Person.FirstName} {_node.Person.LastName} {_node.Person.MiddleName}].");
            }

            var node = await unit.Nodes.Get(x => x.PersonId == personDTO.Id);
            if (node != null)
            {
                Log.Information($"Сотрудник [{personDTO.FirstName} {personDTO.LastName} {personDTO.MiddleName}] " +
                    $"уже находится на должности [{node.Text}]");
                throw new Exception($"Сотрудник [{personDTO.FirstName} {personDTO.LastName} {personDTO.MiddleName}] " +
                    $"уже находится на должности [{node.Text}]");
            }

            _node.PersonId = personDTO.Id;
            _node.Person = map.Map<Person>(personDTO);

            unit.Nodes.Update(map.Map<Node>(_node));
            await unit.SaveAsync();
        }

        public AssignedEmployee(NodeDTO node)
        {
            _node = node;
        }
    }
}
