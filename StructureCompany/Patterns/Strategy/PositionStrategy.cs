
namespace StructureCompany.Patterns.Strategy
{
    public class PositionStrategy : IValidationStrategy
    {
        public void Execute(frm_Main main)
        {
            main.menu_Add.Enabled = false;
            main.menu_Edit.Enabled = true;
            main.menu_Delete.Enabled = true;
            main.menu_Guide.Enabled = true;
            main.lbl_LastName.Visible = true;
            main.lbl_FirstName.Visible = true;
            main.lbl_MiddleName.Visible = true;
            main.lbl_DateJob.Visible = true;
            main.txt_LastName.Visible = true;
            main.txt_FirstName.Visible = true;
            main.txt_MiddleName.Visible = true;
            main.dtp_DateJob.Visible = true;
            main.btn_Select.Visible = true;
            main.btn_Clean.Visible = true;
            if (main.TreeNode == null)
            {
                return;
            }

            Get(main).Execute();
        }
        
        private static IValidText Get(frm_Main main)
        {
            if (main.TreeNode.PersonId == null)
            {
                return new NonPerson(main);
            }
            else if (main.TreeNode.Person.StartJob == null)
            {
                return new PersonNoDate(main);
            }
            else if (main.TreeNode.Person.StartJob != null)
            {
                return new PersonYesDate(main);
            }
            return null;
        }
    }
    

    public interface IValidText
    {
        void Execute();
    }

    public class NonPerson : IValidText
    {
        private frm_Main _main;
        public void Execute()
        {
            _main.txt_FirstName.Text = "";
            _main.txt_LastName.Text = "";
            _main.txt_MiddleName.Text = "";
            _main.dtp_DateJob.Enabled = false;
            _main.dtp_DateJob.Format = DateTimePickerFormat.Custom;
        }
        public NonPerson(frm_Main main)
        {
            _main = main;
        }
    }
    public class PersonYesDate : IValidText
    {
        private frm_Main _main;
        public void Execute()
        {
            _main.txt_FirstName.Text = _main.TreeNode?.Person?.FirstName;
            _main.txt_LastName.Text = _main.TreeNode?.Person?.LastName;
            _main.txt_MiddleName.Text = _main.TreeNode?.Person?.MiddleName;
            _main.dtp_DateJob.Enabled = false;
            _main.dtp_DateJob.Format = DateTimePickerFormat.Short;
            _main.dtp_DateJob.Value = (DateTime)_main.TreeNode?.Person?.StartJob;
        }
        public PersonYesDate(frm_Main main)
        {
            _main = main;
        }
    }

    public class PersonNoDate : IValidText
    {
        private frm_Main _main;
        public void Execute()
        {
            _main.txt_FirstName.Text = _main.TreeNode?.Person?.FirstName;
            _main.txt_LastName.Text = _main.TreeNode?.Person?.LastName;
            _main.txt_MiddleName.Text = _main.TreeNode?.Person?.MiddleName;
            _main.dtp_DateJob.Enabled = true;
            _main.dtp_DateJob.Format = DateTimePickerFormat.Custom;
        }
        public PersonNoDate(frm_Main main)
        {
            _main = main;
        }
    }
}
