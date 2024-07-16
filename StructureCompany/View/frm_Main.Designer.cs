namespace StructureCompany
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menu_Add = new ToolStripMenuItem();
            menu_Edit = new ToolStripMenuItem();
            menu_Delete = new ToolStripMenuItem();
            menu_Guide = new ToolStripMenuItem();
            tv_Branch = new TreeView();
            lbl_LastName = new Label();
            lbl_FirstName = new Label();
            lbl_MiddleName = new Label();
            lbl_DateJob = new Label();
            btn_Select = new Button();
            btn_Clean = new Button();
            dtp_DateJob = new DateTimePicker();
            txt_MiddleName = new TextBox();
            txt_FirstName = new TextBox();
            txt_LastName = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_Add, menu_Edit, menu_Delete, menu_Guide });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_Add
            // 
            menu_Add.Enabled = false;
            menu_Add.Image = Properties.Resources.add;
            menu_Add.Name = "menu_Add";
            menu_Add.Size = new Size(87, 20);
            menu_Add.Text = "Добавить";
            menu_Add.Click += menu_Add_Click;
            // 
            // menu_Edit
            // 
            menu_Edit.Enabled = false;
            menu_Edit.Image = Properties.Resources.edit;
            menu_Edit.Name = "menu_Edit";
            menu_Edit.Size = new Size(115, 20);
            menu_Edit.Text = "Редактировать";
            menu_Edit.Click += menu_Edit_Click;
            // 
            // menu_Delete
            // 
            menu_Delete.Enabled = false;
            menu_Delete.Image = Properties.Resources.delete;
            menu_Delete.Name = "menu_Delete";
            menu_Delete.Size = new Size(79, 20);
            menu_Delete.Text = "Удалить";
            menu_Delete.Click += menu_Delete_Click;
            // 
            // menu_Guide
            // 
            menu_Guide.Enabled = false;
            menu_Guide.Image = Properties.Resources.guide;
            menu_Guide.Name = "menu_Guide";
            menu_Guide.Size = new Size(103, 20);
            menu_Guide.Text = "Справочник";
            menu_Guide.Click += menu_Guide_Click;
            // 
            // tv_Branch
            // 
            tv_Branch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tv_Branch.Location = new Point(12, 27);
            tv_Branch.Name = "tv_Branch";
            tv_Branch.Size = new Size(345, 411);
            tv_Branch.TabIndex = 1;
            tv_Branch.AfterSelect += treeView1_AfterSelect;
            // 
            // lbl_LastName
            // 
            lbl_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI", 10F);
            lbl_LastName.Location = new Point(378, 43);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(69, 19);
            lbl_LastName.TabIndex = 2;
            lbl_LastName.Text = "Фамилия:";
            lbl_LastName.Visible = false;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI", 10F);
            lbl_FirstName.Location = new Point(378, 76);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(39, 19);
            lbl_FirstName.TabIndex = 3;
            lbl_FirstName.Text = "Имя:";
            lbl_FirstName.Visible = false;
            // 
            // lbl_MiddleName
            // 
            lbl_MiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_MiddleName.AutoSize = true;
            lbl_MiddleName.Font = new Font("Segoe UI", 10F);
            lbl_MiddleName.Location = new Point(378, 111);
            lbl_MiddleName.Name = "lbl_MiddleName";
            lbl_MiddleName.Size = new Size(71, 19);
            lbl_MiddleName.TabIndex = 4;
            lbl_MiddleName.Text = "Отчество:";
            lbl_MiddleName.Visible = false;
            // 
            // lbl_DateJob
            // 
            lbl_DateJob.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_DateJob.AutoSize = true;
            lbl_DateJob.Font = new Font("Segoe UI", 10F);
            lbl_DateJob.Location = new Point(378, 146);
            lbl_DateJob.Name = "lbl_DateJob";
            lbl_DateJob.Size = new Size(106, 19);
            lbl_DateJob.TabIndex = 5;
            lbl_DateJob.Text = "Дата принятия:";
            lbl_DateJob.Visible = false;
            // 
            // btn_Select
            // 
            btn_Select.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Select.Image = Properties.Resources.select;
            btn_Select.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Select.Location = new Point(378, 187);
            btn_Select.Name = "btn_Select";
            btn_Select.Size = new Size(101, 34);
            btn_Select.TabIndex = 6;
            btn_Select.Text = "Выбрать";
            btn_Select.TextAlign = ContentAlignment.MiddleRight;
            btn_Select.UseVisualStyleBackColor = true;
            btn_Select.Visible = false;
            btn_Select.Click += btn_Select_Click;
            // 
            // btn_Clean
            // 
            btn_Clean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Clean.Image = Properties.Resources.clean;
            btn_Clean.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Clean.Location = new Point(485, 187);
            btn_Clean.Name = "btn_Clean";
            btn_Clean.Size = new Size(101, 34);
            btn_Clean.TabIndex = 7;
            btn_Clean.Text = "Очистить";
            btn_Clean.TextAlign = ContentAlignment.MiddleRight;
            btn_Clean.UseVisualStyleBackColor = true;
            btn_Clean.Visible = false;
            btn_Clean.Click += btn_Clean_Click;
            // 
            // dtp_DateJob
            // 
            dtp_DateJob.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dtp_DateJob.CustomFormat = " ";
            dtp_DateJob.Enabled = false;
            dtp_DateJob.Format = DateTimePickerFormat.Custom;
            dtp_DateJob.Location = new Point(513, 146);
            dtp_DateJob.Name = "dtp_DateJob";
            dtp_DateJob.Size = new Size(115, 23);
            dtp_DateJob.TabIndex = 8;
            dtp_DateJob.Visible = false;
            dtp_DateJob.ValueChanged += dtp_DateJob_ValueChanged;
            // 
            // txt_MiddleName
            // 
            txt_MiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_MiddleName.Enabled = false;
            txt_MiddleName.Location = new Point(513, 110);
            txt_MiddleName.Name = "txt_MiddleName";
            txt_MiddleName.Size = new Size(275, 23);
            txt_MiddleName.TabIndex = 9;
            txt_MiddleName.Visible = false;
            // 
            // txt_FirstName
            // 
            txt_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_FirstName.Enabled = false;
            txt_FirstName.Location = new Point(513, 75);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(275, 23);
            txt_FirstName.TabIndex = 10;
            txt_FirstName.Visible = false;
            // 
            // txt_LastName
            // 
            txt_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_LastName.Enabled = false;
            txt_LastName.Location = new Point(513, 42);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(275, 23);
            txt_LastName.TabIndex = 11;
            txt_LastName.Visible = false;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_LastName);
            Controls.Add(txt_FirstName);
            Controls.Add(txt_MiddleName);
            Controls.Add(dtp_DateJob);
            Controls.Add(btn_Clean);
            Controls.Add(btn_Select);
            Controls.Add(lbl_DateJob);
            Controls.Add(lbl_MiddleName);
            Controls.Add(lbl_FirstName);
            Controls.Add(lbl_LastName);
            Controls.Add(tv_Branch);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 489);
            Name = "frm_Main";
            Text = "Структура предприятия";
            Load += frm_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        public ToolStripMenuItem menu_Add;
        public ToolStripMenuItem menu_Edit;
        public ToolStripMenuItem menu_Delete;
        public ToolStripMenuItem menu_Guide;
        private TreeView tv_Branch;
        public Label lbl_LastName;
        public Label lbl_FirstName;
        public Label lbl_MiddleName;
        public Label lbl_DateJob;
        public Button btn_Select;
        public Button btn_Clean;
        public DateTimePicker dtp_DateJob;
        public TextBox txt_MiddleName;
        public TextBox txt_FirstName;
        public TextBox txt_LastName;
    }
}
