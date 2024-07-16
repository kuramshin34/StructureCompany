using Serilog;
using StructureCompany.DTO;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public class PersonFirstNameHandler : HandlerPerson
    {
        public override void Handle(CreatePersonDTO temp)
        {
            if (temp.FirstName == "")
            {
                string message = "У сотрудника не может быть пустого имени";
                Log.Information(message);
                throw new Exception(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }

        public PersonFirstNameHandler()
        {
            
        }

        public PersonFirstNameHandler(HandlerPerson temp)
        {
            Successor = temp;
        }
    }
}
