
namespace StructureCompany.DTO
{
    public class PersonDTO : CreatePersonDTO
    {
        public int Id { get; set; }
        public DateTime? StartJob { get; set; }
    }

    public class CreatePersonDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
