using Serilog;
using StructureCompany.Data;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    internal class NodeNameHandler : HandlerNode
    {

        public override void Handle(TempBranch temp)
        {
            if (temp.Name == "")
            {
                string message = "У узла ветки не может быть пустое наименование: null";
                Log.Information(message);
                throw new Exception(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }

        public NodeNameHandler()
        {
     
        }

        public NodeNameHandler(HandlerNode handler)
        {
            Successor = handler;

        }
    }
}
