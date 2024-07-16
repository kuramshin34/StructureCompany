﻿namespace StructureCompany.View
{
    partial class frm_AddBranch
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
            cmb_Branch = new ComboBox();
            btn_Cancel = new Button();
            btn_Okey = new Button();
            txt_Name = new TextBox();
            lbl_Name = new Label();
            lbl_Branch = new Label();
            SuspendLayout();
            // 
            // cmb_Branch
            // 
            cmb_Branch.FormattingEnabled = true;
            cmb_Branch.Items.AddRange(new object[] { "Подразделение", "Должность" });
            cmb_Branch.Location = new Point(150, 10);
            cmb_Branch.Name = "cmb_Branch";
            cmb_Branch.Size = new Size(176, 23);
            cmb_Branch.TabIndex = 12;
            cmb_Branch.Text = "[Выберите значение]";
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(236, 117);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(90, 25);
            btn_Cancel.TabIndex = 11;
            btn_Cancel.Text = "Отмена";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_Okey
            // 
            btn_Okey.Location = new Point(131, 117);
            btn_Okey.Name = "btn_Okey";
            btn_Okey.Size = new Size(90, 25);
            btn_Okey.TabIndex = 10;
            btn_Okey.Text = "ОК";
            btn_Okey.UseVisualStyleBackColor = true;
            btn_Okey.Click += btn_Okey_Click;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(150, 55);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(176, 23);
            txt_Name.TabIndex = 9;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 10F);
            lbl_Name.Location = new Point(15, 56);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(107, 19);
            lbl_Name.TabIndex = 8;
            lbl_Name.Text = "Наименование:";
            // 
            // lbl_Branch
            // 
            lbl_Branch.AutoSize = true;
            lbl_Branch.Font = new Font("Segoe UI", 10F);
            lbl_Branch.Location = new Point(15, 10);
            lbl_Branch.Name = "lbl_Branch";
            lbl_Branch.Size = new Size(74, 19);
            lbl_Branch.TabIndex = 7;
            lbl_Branch.Text = "Тип ветки:";
            // 
            // frm_AddBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 152);
            Controls.Add(cmb_Branch);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Okey);
            Controls.Add(txt_Name);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Branch);
            MaximumSize = new Size(356, 191);
            MinimumSize = new Size(356, 191);
            Name = "frm_AddBranch";
            Text = "Добавление ветки";
            FormClosing += frm_AddBranch_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Branch;
        private Button btn_Cancel;
        private Button btn_Okey;
        private TextBox txt_Name;
        private Label lbl_Name;
        private Label lbl_Branch;
    }
}