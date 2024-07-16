using StructureCompany.Models;
using System.ComponentModel.DataAnnotations;

namespace StructureCompany.DTO
{
    public class NodeDTO : CreateNodeDTO
    {
        public int Id { get; set; }
    }

    public class CreateNodeDTO : TreeNode
    {
        public string Name { get; set; }
        [Required]
        public TypeNode TypeBranch { get; set; }

        public int? PersonId { get; set; }
        public int? ParentId { get; set; }
        public Person? Person { get; set; }

    }
}
