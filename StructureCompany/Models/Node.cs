using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StructureCompany.Models
{

    /// <summary>
    /// Узел
    /// </summary>
    public class Node
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }

        public TypeNode TypeBranch { get; set; }

        [ForeignKey(nameof(Person))]
        public int? PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public int? ParentId { get; set; }
    }

    public enum TypeNode
    {
        Parent = -1,
        Departament = 0,
        Position = 1,
        Uhknow = 2
    }
}
