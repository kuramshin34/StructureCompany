using AutoMapper;
using Serilog;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;

namespace StructureCompany.Patterns.Strategy
{
    public class DetachedEmployee : IAssignable
    {
        private readonly NodeDTO _node;

        public async Task Execute(IUnitOfWork unit, IMapper map, PersonDTO personDTO)
        {
            if (_node == null)
            {
                Log.Information("Должность не закрепилась");
                MessageBox.Show("Должность не закрепилась", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_node.PersonId == null)
            {
                Log.Information($"У данной должности {_node.Name} нет сотрудника");
                MessageBox.Show($"У данной должности {_node.Name} нет сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _node.PersonId = null;
            _node.Person = null;

            unit.Nodes.Update(map.Map<Node>(_node));
            await unit.SaveAsync();
            personDTO.StartJob = null;

            unit.Persons.Update(map.Map<Person>(personDTO));

            await unit.SaveAsync();

        }

        public DetachedEmployee(NodeDTO node)
        {
            _node = node;
        }
    }
}
