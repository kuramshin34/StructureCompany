using AutoMapper;
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
    public partial class frm_EditPerson : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly PersonDTO _personDTO;

        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string _middleName;
        public frm_EditPerson(IUnitOfWork unitOfWork, IMapper mapper, PersonDTO personDTO)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _personDTO = personDTO;
            _firstName = _personDTO.FirstName;
            _lastName = _personDTO.LastName;
            _middleName = _personDTO.MiddleName;
        }

        private async void btn_Okey_Click(object sender, EventArgs e)
        {
            try
            {
                new PersonDuplicateNameHandler(_firstName, _lastName, _middleName).Handle(_personDTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _personDTO.FirstName = txt_FirstName.Text;
            _personDTO.LastName = txt_LastName.Text;
            _personDTO.MiddleName = txt_MiddleName.Text;
            var person = _mapper.Map<Person>(_personDTO);
            _unitOfWork.Persons.Update(person);
            await _unitOfWork.SaveAsync();

            DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frm_EditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frm_EditPerson_Load(object sender, EventArgs e)
        {
            txt_FirstName.Text = _personDTO.FirstName;
            txt_LastName.Text = _personDTO.LastName;
            txt_MiddleName.Text = _personDTO.MiddleName;
        }
    }
}
