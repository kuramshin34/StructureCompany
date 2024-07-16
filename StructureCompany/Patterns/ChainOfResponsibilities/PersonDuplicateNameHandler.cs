using Serilog;
using StructureCompany.DTO;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public class PersonDuplicateNameHandler : HandlerPerson
    {
        private string _firstName;
        private string _lastName;
        private string _middletName;
        public override void Handle(CreatePersonDTO temp)
        {
            if (temp.FirstName == _firstName && temp.LastName == _lastName && temp.MiddleName == _middletName)
            {
                string message = "У сотрудника ничего не изменилось";
                Log.Information(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }
        public PersonDuplicateNameHandler(string firstName, string lastName, string middleName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _middletName = middleName;
        }
    }
}
