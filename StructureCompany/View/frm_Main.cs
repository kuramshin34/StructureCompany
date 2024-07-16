using AutoMapper;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using StructureCompany.Patterns.Strategy;
using StructureCompany.View;

namespace StructureCompany
{

    public partial class frm_Main : Form
    {
        public NodeDTO TreeNode
        {
            get => _treeNode;
        }
        private NodeDTO _treeNode;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public frm_Main(IUnitOfWork unitOfWork, IMapper mapper)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _treeNode = (NodeDTO)e.Node;
            OnTreeViewNodeSelected(_treeNode);
        }

        private void OnTreeViewNodeSelected(NodeDTO node)
        {
            _treeNode = node;
            IValidationStrategy valid = GetValidation(_treeNode);
            valid.Execute(this);
        }

        private static IValidationStrategy GetValidation(NodeDTO node)
        {
            if (node.TypeBranch == TypeNode.Parent)
            {
                return new ParentStrategy();
            }
            else if (node.TypeBranch == TypeNode.Departament)
            {
                return new DepartamentStrategy();
            }
            else if (node.TypeBranch == TypeNode.Position)
            {
                return new PositionStrategy();
            }
            return null;
        }

        private async void menu_Add_Click(object sender, EventArgs e)
        {
            _treeNode = (NodeDTO)tv_Branch.SelectedNode;

            frm_AddBranch add = new frm_AddBranch(_unitOfWork, _mapper, TreeNode);
            if (add.ShowDialog() == DialogResult.OK)
            {

            }
            add.Close();
            tv_Branch.Focus();
            OnTreeViewNodeSelected(_treeNode);
        }

        private void menu_Edit_Click(object sender, EventArgs e)
        {
            frm_EditBranch edit = new frm_EditBranch(_unitOfWork, _mapper, _treeNode);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("GG");
            }
            tv_Branch.Refresh();
            edit.Close();
            tv_Branch.Focus();
            OnTreeViewNodeSelected(_treeNode);
        }

        private async void menu_Delete_Click(object sender, EventArgs e)
        {
            _treeNode = (NodeDTO)tv_Branch.SelectedNode;
            if (_treeNode == null)
            {
                return;
            }
            var list = new List<NodeDTO>() { _treeNode };
            var removesList = GetNodes(_treeNode, list);

            foreach (var remove in removesList)
            {
                if (remove.PersonId != null)
                {
                    remove.Person.StartJob = null;
                    _unitOfWork.Persons.Update(_mapper.Map<Person>(remove.Person));
                }
                var node = _mapper.Map<Node>(remove);
                await _unitOfWork.Nodes.Delete(node.Id);
            }


            await _unitOfWork.SaveAsync();
            _treeNode.Remove();
            tv_Branch.Focus();
            OnTreeViewNodeSelected(_treeNode);
        }

        private void menu_Guide_Click(object sender, EventArgs e)
        {
            frm_Guide guide = new frm_Guide(_unitOfWork, _mapper, null);
            if (guide.ShowDialog() == DialogResult.OK)
            {

            }
            guide.Close();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            

            frm_Guide guide = new frm_Guide(_unitOfWork, _mapper, new AssignedEmployee(_treeNode));
            if (guide.ShowDialog() == DialogResult.OK)
            {
                txt_FirstName.Text = _treeNode.Person?.FirstName;
                txt_LastName.Text = _treeNode.Person?.LastName;
                txt_MiddleName.Text = _treeNode.Person?.MiddleName;
            }
            guide.Close();

            tv_Branch.Focus();
            OnTreeViewNodeSelected(_treeNode);
        }

        private async void btn_Clean_Click(object sender, EventArgs e)
        {
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_MiddleName.Text = "";
            dtp_DateJob.Format = DateTimePickerFormat.Custom;

            var detached = new DetachedEmployee(_treeNode);
            await detached.Execute(_unitOfWork, _mapper, _mapper.Map<PersonDTO>(_treeNode.Person));

            tv_Branch.Focus();
            OnTreeViewNodeSelected(_treeNode);
        }

        private async void frm_Main_Load(object sender, EventArgs e)
        {
            await AddParentNode();
            var nodes = await _unitOfWork.Nodes.GetAll(x => x.ParentId != null, x=>x.Person);
            var nodesDTO = _mapper.Map<IList<NodeDTO>>(nodes);

            GetNodes(_treeNode, nodesDTO);
            tv_Branch.ExpandAll();
            tv_Branch.SelectedNode = _treeNode;
        }

        private List<NodeDTO> GetNodes(NodeDTO parent, List<NodeDTO> nodes)
        {
            
            foreach (NodeDTO node in parent.Nodes)
            {
                nodes.Add(node);
                GetNodes(node, nodes);
            }
            return nodes;
        }

        private void GetNodes(NodeDTO parent, IEnumerable<NodeDTO> fullNodes)
        {
            
            NodeDTO[] nodes = fullNodes.Where(x => x.ParentId == parent.Id).ToArray();
            parent.Nodes.AddRange(nodes);

            foreach (NodeDTO node in parent.Nodes)
            {
                GetNodes(node, fullNodes);
            }
        }

        private async Task AddParentNode()
        {
            var parentNode = await _unitOfWork.Nodes.Get(x => x.ParentId == null, x=>x.Person);
            _treeNode = _mapper.Map<NodeDTO>(parentNode);
            
            tv_Branch.Nodes.Add(_treeNode);
        }

        private async void dtp_DateJob_ValueChanged(object sender, EventArgs e)
        {
            var date = sender as DateTimePicker;
            if (date.Format == DateTimePickerFormat.Custom)
            {
                date.Format = DateTimePickerFormat.Short;
            }

            if (_treeNode.Person.StartJob == date.Value)
            {
                return;
            }

            _treeNode.Person.StartJob = date.Value;
            _unitOfWork.Persons.Update(_treeNode.Person);
            await _unitOfWork.SaveAsync();

        }
    }

}
