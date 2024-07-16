using StructureCompany.Data;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    public abstract class HandlerNode
    {
        protected HandlerNode Successor { get; set; }
        public abstract void Handle(TempBranch temp);
    }
}
