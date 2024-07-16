using StructureCompany.DTO;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public abstract class HandlerPerson
    {
        protected HandlerPerson Successor { get; set; }
        public abstract void Handle(CreatePersonDTO temp);
    }
}
