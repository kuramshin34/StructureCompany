using Serilog;
using StructureCompany.DTO;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public class PersonMiddleNameHandler : HandlerPerson
    {
        public override void Handle(CreatePersonDTO temp)
        {
            if (temp.MiddleName == "")
            {
                string message = "У сотрудника не может быть пустого отчества";
                Log.Information(message);
                throw new Exception(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }
        public PersonMiddleNameHandler()
        {

        }

        public PersonMiddleNameHandler(HandlerPerson temp)
        {
            Successor = temp;
        }
    }
}
