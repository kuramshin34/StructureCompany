using Serilog;
using StructureCompany.DTO;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public class PersonLastNameHandler : HandlerPerson
    {
        public override void Handle(CreatePersonDTO temp)
        {
            if (temp.LastName == "")
            {
                string message = "У сотрудника не может быть пустой фамилии";
                Log.Information(message);
                throw new Exception(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }
        public PersonLastNameHandler()
        {

        }

        public PersonLastNameHandler(HandlerPerson temp)
        {
            Successor = temp;
        }
    }
}
