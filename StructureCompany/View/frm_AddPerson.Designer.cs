namespace StructureCompany.View
{
    partial class frm_AddPerson
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
            btn_Cancel = new Button();
            btn_Okey = new Button();
            txt_MiddleName = new TextBox();
            lbl_MiddleName = new Label();
            txt_LastName = new TextBox();
            lbl_LastName = new Label();
            txt_FirstName = new TextBox();
            lbl_FirstName = new Label();
            SuspendLayout();
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(234, 187);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(90, 25);
            btn_Cancel.TabIndex = 15;
            btn_Cancel.Text = "Отмена";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Okey
            // 
            btn_Okey.Location = new Point(129, 187);
            btn_Okey.Name = "btn_Okey";
            btn_Okey.Size = new Size(90, 25);
            btn_Okey.TabIndex = 14;
            btn_Okey.Text = "ОК";
            btn_Okey.UseVisualStyleBackColor = true;
            btn_Okey.Click += btn_Okey_Click;
            // 
            // txt_MiddleName
            // 
            txt_MiddleName.Location = new Point(148, 125);
            txt_MiddleName.Name = "txt_MiddleName";
            txt_MiddleName.Size = new Size(176, 23);
            txt_MiddleName.TabIndex = 13;
            // 
            // lbl_MiddleName
            // 
            lbl_MiddleName.AutoSize = true;
            lbl_MiddleName.Font = new Font("Segoe UI", 10F);
            lbl_MiddleName.Location = new Point(13, 126);
            lbl_MiddleName.Name = "lbl_MiddleName";
            lbl_MiddleName.Size = new Size(71, 19);
            lbl_MiddleName.TabIndex = 12;
            lbl_MiddleName.Text = "Отчество:";
            // 
            // txt_LastName
            // 
            txt_LastName.Location = new Point(148, 71);
            txt_LastName.Name = "txt_LastName";
            txt_LastName.Size = new Size(176, 23);
            txt_LastName.TabIndex = 17;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI", 10F);
            lbl_LastName.Location = new Point(13, 72);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(69, 19);
            lbl_LastName.TabIndex = 16;
            lbl_LastName.Text = "Фамилия:";
            // 
            // txt_FirstName
            // 
            txt_FirstName.Location = new Point(148, 12);
            txt_FirstName.Name = "txt_FirstName";
            txt_FirstName.Size = new Size(176, 23);
            txt_FirstName.TabIndex = 19;
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI", 10F);
            lbl_FirstName.Location = new Point(13, 13);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(39, 19);
            lbl_FirstName.TabIndex = 18;
            lbl_FirstName.Text = "Имя:";
            // 
            // frm_AddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 224);
            Controls.Add(txt_FirstName);
            Controls.Add(lbl_FirstName);
            Controls.Add(txt_LastName);
            Controls.Add(lbl_LastName);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Okey);
            Controls.Add(txt_MiddleName);
            Controls.Add(lbl_MiddleName);
            MaximumSize = new Size(352, 263);
            MinimumSize = new Size(352, 263);
            Name = "frm_AddPerson";
            Text = "Добавление сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Cancel;
        private Button btn_Okey;
        private TextBox txt_MiddleName;
        private Label lbl_MiddleName;
        private TextBox txt_LastName;
        private Label lbl_LastName;
        private TextBox txt_FirstName;
        private Label lbl_FirstName;
    }
}