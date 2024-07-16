namespace StructureCompany.View
{
    partial class frm_Guide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menu_Add = new ToolStripMenuItem();
            menu_Edit = new ToolStripMenuItem();
            menu_Delete = new ToolStripMenuItem();
            lbl_FirstName = new Label();
            txt_FirstName = new TextBox();
            btn_Find = new Button();
            dgv_Persons = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            MiddleName = new DataGridViewTextBoxColumn();
            txt_LastName = new TextBox();
            lbl_LastName = new Label();
            txt_MiddleName = new TextBox();
            lbl_MiddleName = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menu_Add, menu_Edit, menu_Delete });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu_Add
            // 
            menu_Add.Image = Properties.Resources.add;
            menu_Add.Name = "menu_Add";
            menu_Add.Size = new Size(87, 20);
            menu_Add.Text = "Добавить";
            menu_Add.Click += menu_Add_Click;
            // 
            // menu_Edit
            // 
            menu_Edit.Image = Properties.Resources.edit;
            menu_Edit.Name = "menu_Edit";
            menu_Edit.Size = new Size(115, 20);
            menu_Edit.Text = "Редактировать";
            menu_Edit.Click += menu_Edit_Click;
            // 
            // menu_Delete
            // 
            menu_Delete.Image = Properties.Resources.delete;
            menu_Delete.Name = "menu_Delete";
            menu_Delete.Size = new Size(79, 20);
            menu_Delete.Text = "Удалить";
            menu_Delete.Click += menu_Delete_Click;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Location = new Point(17, 40);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(34, 15);
            lbl_FirstName.TabIndex = 1;
            lbl_FirstName.Text = "Имя:";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_FirstName.Location = new Point(77, 35);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(100, 23);
            txt_FirstName.TabIndex = 2;
            // 
            // btn_Find
            // 
            btn_Find.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Find.Location = new Point(698, 33);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(90, 23);
            btn_Find.TabIndex = 3;
            btn_Find.Text = "Найти";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // dgv_Persons
            // 
            dgv_Persons.AllowUserToAddRows = false;
            dgv_Persons.AllowUserToResizeColumns = false;
            dgv_Persons.AllowUserToResizeRows = false;
            dgv_Persons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_Persons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Persons.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, MiddleName });
            dgv_Persons.Location = new Point(0, 68);
            dgv_Persons.Name = "dgv_Persons";
            dgv_Persons.ReadOnly = true;
            dgv_Persons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Persons.Size = new Size(800, 378);
            dgv_Persons.TabIndex = 4;
            dgv_Persons.CellDoubleClick += dgv_Persons_CellDoubleClick;
            // 
            // LastName
            // 
            LastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "Фамилия";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            FirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "Имя";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            MiddleName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MiddleName.DataPropertyName = "MiddleName";
            MiddleName.HeaderText = "Отчество";
            MiddleName.Name = "MiddleName";
            MiddleName.ReadOnly = true;
            // 
            // txt_LastName
            // 
            txt_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_LastName.Location = new Point(298, 35);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(100, 23);
            txt_LastName.TabIndex = 6;
            // 
            // lbl_LastName
            // 
            lbl_LastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_LastName.AutoSize = true;
            lbl_LastName.Location = new Point(221, 40);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(61, 15);
            lbl_LastName.TabIndex = 5;
            lbl_LastName.Text = "Фамилия:";
            // 
            // txt_MiddleName
            // 
            txt_MiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_MiddleName.Location = new Point(527, 35);
            txt_MiddleName.Name = "txt_MiddleName";
            txt_MiddleName.Size = new Size(100, 23);
            txt_MiddleName.TabIndex = 8;
            // 
            // lbl_MiddleName
            // 
            lbl_MiddleName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_MiddleName.AutoSize = true;
            lbl_MiddleName.Location = new Point(444, 40);
            lbl_MiddleName.Name = "lbl_MiddleName";
            lbl_MiddleName.Size = new Size(61, 15);
            lbl_MiddleName.TabIndex = 7;
            lbl_MiddleName.Text = "Отчество:";
            // 
            // frm_Guide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_MiddleName);
            Controls.Add(lbl_MiddleName);
            Controls.Add(txt_LastName);
            Controls.Add(lbl_LastName);
            Controls.Add(dgv_Persons);
            Controls.Add(btn_Find);
            Controls.Add(txt_FirstName);
            Controls.Add(lbl_FirstName);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 489);
            Name = "frm_Guide";
            Text = "Справочник физических лиц";
            FormClosing += frm_Guide_FormClosing;
            Load += frm_Guide_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Persons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menu_Add;
        private ToolStripMenuItem menu_Edit;
        private ToolStripMenuItem menu_Delete;
        private Label lbl_FirstName;
        private TextBox txt_FirstName;
        private Button btn_Find;
        private DataGridView dgv_Persons;
        private TextBox txt_LastName;
        private Label lbl_LastName;
        private TextBox txt_MiddleName;
        private Label lbl_MiddleName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn MiddleName;
    }
}