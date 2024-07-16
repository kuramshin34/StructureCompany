using System.ComponentModel.DataAnnotations;

namespace StructureCompany.Models
{
    public class Person
    {
       
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public DateTime? StartJob { get; set; }

        
    }
}
