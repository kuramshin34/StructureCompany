using AutoMapper;
using StructureCompany.DTO;
using StructureCompany.IRegistory;
using StructureCompany.Models;
using StructureCompany.Patterns.Strategy;
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
    public partial class frm_Guide : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private BindingList<PersonDTO> personsDTO;
        private PersonDTO _person;
        private readonly IAssignable _assignable;
        public PersonDTO Person
        {
            get => _person;
        }

        public frm_Guide(IUnitOfWork unitOfWork, IMapper mapper, IAssignable assignable)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _assignable = assignable;
            dgv_Persons.AutoGenerateColumns = false;
        }

        private void menu_Add_Click(object sender, EventArgs e)
        {
            frm_AddPerson add = new frm_AddPerson(_unitOfWork, _mapper, personsDTO);
            if (add.ShowDialog() == DialogResult.OK)
            {

            }
            dgv_Persons.Refresh();
            add.Close();
            dgv_Persons.CurrentCell = dgv_Persons.Rows[dgv_Persons.Rows.Count-1].Cells[0];
        }

        private async void menu_Edit_Click(object sender, EventArgs e)
        {
            if (dgv_Persons.Rows.Count == 0)
            {
                return;
            }
            var _personDTO = personsDTO[dgv_Persons.CurrentRow.Index];
            var person = await _unitOfWork.Persons.Get(x => x.FirstName == _personDTO.FirstName
                && x.LastName == _personDTO.LastName
                && x.MiddleName == _personDTO.MiddleName);
            frm_EditPerson edit = new frm_EditPerson(_unitOfWork, _mapper, _mapper.Map(person, _personDTO));
            if (edit.ShowDialog() == DialogResult.OK)
            {

            }
            dgv_Persons.Refresh();
            edit.Close();
        }

        private async void menu_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Persons.Rows.Count == 0)
            {
                return;
            }
            var _personDTO = personsDTO[dgv_Persons.CurrentRow.Index];
            var person = await _unitOfWork.Persons.Get(x=>x.FirstName == _personDTO.FirstName 
                && x.LastName == _personDTO.LastName
                && x.MiddleName== _personDTO.MiddleName);
            await _unitOfWork.Persons.Delete(person.Id);
            await _unitOfWork.SaveAsync();
            personsDTO.Remove(_personDTO);
        }

        private async void btn_Find_Click(object sender, EventArgs e)
        {
            var persons = await _unitOfWork.Persons.GetAll(x => x.FirstName.Contains(txt_FirstName.Text)
            && x.LastName.Contains(txt_LastName.Text)
            && x.MiddleName.Contains(txt_MiddleName.Text));
            personsDTO = _mapper.Map<BindingList<PersonDTO>>(persons);
            dgv_Persons.DataSource = personsDTO;
        }

        private void frm_Guide_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private async void frm_Guide_Load(object sender, EventArgs e)
        {
            IList<Person> persons = await _unitOfWork.Persons.GetAll();
            personsDTO = _mapper.Map<BindingList<PersonDTO>>(persons);
            dgv_Persons.DataSource = personsDTO;


        }

        private async void dgv_Persons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (_assignable == null)
            {
                return;
            }
            try
            {
                await _assignable.Execute(_unitOfWork, _mapper, personsDTO[e.RowIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
