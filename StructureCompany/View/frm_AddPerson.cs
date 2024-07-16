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
    public partial class frm_AddPerson : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly BindingList<PersonDTO> _person;
        public frm_AddPerson(IUnitOfWork unitOfWork, IMapper mapper, BindingList<PersonDTO> person)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _person = person;
        }

        private async void btn_Okey_Click(object sender, EventArgs e)
        {
            CreatePersonDTO createPersonDTO = new CreatePersonDTO()
            {
                FirstName = txt_FirstName.Text,
                LastName = txt_LastName.Text,
                MiddleName = txt_MiddleName.Text,
            };

            try
            {
                new PersonFirstNameHandler(new PersonLastNameHandler(new PersonMiddleNameHandler())).Handle(createPersonDTO);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Person person = _mapper.Map<Person>(createPersonDTO);
            var personDTO = _mapper.Map<PersonDTO>(person);
            _person.Add(personDTO);
            await _unitOfWork.Persons.Insert(person);
            await _unitOfWork.SaveAsync();
           
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
