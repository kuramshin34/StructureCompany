using Serilog;
using StructureCompany.Data;
using StructureCompany.Models;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    internal class NodeTypeHandler : HandlerNode
    {

        public override void Handle(TempBranch temp)
        {
            if (temp.TypeNode == TypeNode.Uhknow)
            {
                string message = "У узла ветки не может быть пустого типа";
                Log.Information(message);
                throw new Exception(message);
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }

        public NodeTypeHandler()
        {

        }

        public NodeTypeHandler(HandlerNode handler, TempBranch temp)
        {
            Successor = handler;
        }
    }
}
