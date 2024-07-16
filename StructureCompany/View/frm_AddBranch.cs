using AutoMapper;
using StructureCompany.Data;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using StructureCompany.Patterns.ChainOfResponsibilities;

namespace StructureCompany.View
{
    public partial class frm_AddBranch : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        private NodeDTO _treeNode;
        public frm_AddBranch(IUnitOfWork unitOfWork, IMapper mapper, NodeDTO treeNode)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _treeNode = treeNode;
        }

        private async void btn_Okey_Click(object sender, EventArgs e)
        {
            TempBranch temp = new TempBranch()
            {
                 Name = txt_Name.Text,
                 TypeNode = GetTypeNode(cmb_Branch.SelectedIndex),
                 ParentId = _treeNode.Id
            };

            try
            {
                new NodeNameHandler(new NodeTypeHandler()).Handle(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NodeDTO nodeDTO = new NodeDTO()
            {
                Name = temp.Name,
                Text = temp.Name,
                ParentId = temp.ParentId,
                TypeBranch = temp.TypeNode,
            };
            Node node = _mapper.Map<Node>(nodeDTO); 
            await _unitOfWork.Nodes.Insert(node);
            await _unitOfWork.SaveAsync();

            nodeDTO.Id = (await _unitOfWork.Nodes.Get(x => x.Text == nodeDTO.Name && x.ParentId == nodeDTO.ParentId)).Id;
            _treeNode.Nodes.Add(nodeDTO);
            DialogResult = DialogResult.OK;
        }

        private TypeNode GetTypeNode(int index)
        {
            if (index == 0)
            {
                return TypeNode.Departament;
            }
            else if (index == 1)
            {
                return TypeNode.Position;
            }
            return TypeNode.Uhknow;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_AddBranch_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
