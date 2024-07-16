
namespace StructureCompany.Patterns.Strategy
{
    public class ParentStrategy : IValidationStrategy
    {
        public void Execute(frm_Main main)
        {
            main.menu_Add.Enabled = true;
            main.menu_Edit.Enabled = false;
            main.menu_Delete.Enabled = false;
            main.menu_Guide.Enabled = true;
            main.lbl_LastName.Visible = false;
            main.lbl_FirstName.Visible = false;
            main.lbl_MiddleName.Visible = false;
            main.lbl_DateJob.Visible = false;
            main.txt_LastName.Visible = false;
            main.txt_FirstName.Visible = false;
            main.txt_MiddleName.Visible = false;
            main.dtp_DateJob.Visible = false;
            main.btn_Select.Visible = false;
            main.btn_Clean.Visible = false;
        }
    }
}
