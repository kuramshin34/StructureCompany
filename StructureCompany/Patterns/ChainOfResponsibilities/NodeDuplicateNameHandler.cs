using Serilog;
using StructureCompany.Data;

namespace StructureCompany.Patterns.ChainOfResponsibilities
{
    internal class NodeDuplicateNameHandler : HandlerNode
    {
        private string _tempName;
 
        public override void Handle(TempBranch temp)
        {
            if (temp.Name == _tempName)
            {
                Log.Information($"У узла ветки наименование никак не изменилось : {_tempName}");
            }
            else if (Successor != null)
            {
                Successor.Handle(temp);
            }
        }
        public NodeDuplicateNameHandler(string tempName)
        {
            _tempName = tempName;
           
        }

        public NodeDuplicateNameHandler(HandlerNode temp, string tempName)
        {
            Successor = temp;
            _tempName = tempName;
        }
    }
}
