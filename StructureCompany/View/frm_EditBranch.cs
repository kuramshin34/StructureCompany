using AutoMapper;
using Serilog;
using StructureCompany.Data;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using StructureCompany.Patterns.ChainOfResponsibilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructureCompany.View
{
    public partial class frm_EditBranch : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private NodeDTO _treeNode;
        private string tempName = "";
        public frm_EditBranch(IUnitOfWork unitOfWork, IMapper mapper, NodeDTO treeNode)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _treeNode = treeNode;
            cmb_Branch.SelectedIndex = (int)_treeNode.TypeBranch;
            cmb_Branch.DropDownStyle = ComboBoxStyle.DropDownList;
            tempName = _treeNode.Text;
            txt_Name.Text = tempName;
            cmb_Branch.Enabled = false;
        }

        private async void btn_Okey_Click(object sender, EventArgs e)
        {
            TempBranch temp = new TempBranch()
            {
                Name = txt_Name.Text,
                TypeNode = _treeNode.TypeBranch,
                ParentId = _treeNode.ParentId,
            };
            if (temp.Name != tempName)
            {
                try
                {
                    new NodeNameHandler().Handle(temp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _treeNode.Name = temp.Name;
                _treeNode.Text = temp.Name;

                var node = _mapper.Map<Node>(_treeNode);
                _unitOfWork.Nodes.Update(node);
                await _unitOfWork.SaveAsync();

            }
            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_EditBranch_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
