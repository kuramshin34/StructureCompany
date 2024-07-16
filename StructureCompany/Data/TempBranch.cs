using StructureCompany.Models;

namespace StructureCompany.Data
{
    public class TempBranch 
    {
        public string Name { get; set; }
        public TypeNode TypeNode { get; set; }
        public int? ParentId { get; set; }
    }
}
