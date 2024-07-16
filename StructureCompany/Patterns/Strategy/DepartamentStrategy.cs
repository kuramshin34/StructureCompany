namespace StructureCompany.Patterns.Strategy
{
    public class DepartamentStrategy : IValidationStrategy
    {
       
        public void Execute(frm_Main main)
        {
            main.menu_Add.Enabled = true;
            main.menu_Edit.Enabled = true;
            main.menu_Delete.Enabled = true;
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
        public DepartamentStrategy()
        {
           
        }
    }
}
