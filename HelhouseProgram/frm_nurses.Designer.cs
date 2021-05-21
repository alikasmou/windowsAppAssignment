namespace HelhouseProgram
{
    partial class frm_nurses
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
            this.tabControl_nurses = new System.Windows.Forms.TabControl();
            this.tb_nurses = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtgrid_nurses = new System.Windows.Forms.DataGridView();
            this.tb_addNurse = new System.Windows.Forms.TabPage();
            this.gbox_addNurse = new System.Windows.Forms.GroupBox();
            this.lbl_NurseName = new System.Windows.Forms.Label();
            this.btn_addNurse = new System.Windows.Forms.Button();
            this.txt_NurseName = new System.Windows.Forms.TextBox();
            this.lbl_NurseCity = new System.Windows.Forms.Label();
            this.txt_nurseSurname = new System.Windows.Forms.TextBox();
            this.lbl_NursePhone = new System.Windows.Forms.Label();
            this.txt_NursePhone = new System.Windows.Forms.TextBox();
            this.lbl_NurseGender = new System.Windows.Forms.Label();
            this.dtime_nurseBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_NurseBirthday = new System.Windows.Forms.Label();
            this.cmb_nurseGender = new System.Windows.Forms.ComboBox();
            this.lbl_NurseSurname = new System.Windows.Forms.Label();
            this.cmb_NurseCity = new System.Windows.Forms.ComboBox();
            this.tb_delete = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_nurseDelete = new System.Windows.Forms.ComboBox();
            this.lbl_NurseId = new System.Windows.Forms.Label();
            this.btn_deleteNurse = new System.Windows.Forms.Button();
            this.tabControl_nurses.SuspendLayout();
            this.tb_nurses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_nurses)).BeginInit();
            this.tb_addNurse.SuspendLayout();
            this.gbox_addNurse.SuspendLayout();
            this.tb_delete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_nurses
            // 
            this.tabControl_nurses.Controls.Add(this.tb_nurses);
            this.tabControl_nurses.Controls.Add(this.tb_addNurse);
            this.tabControl_nurses.Controls.Add(this.tb_delete);
            this.tabControl_nurses.Location = new System.Drawing.Point(12, 12);
            this.tabControl_nurses.Name = "tabControl_nurses";
            this.tabControl_nurses.SelectedIndex = 0;
            this.tabControl_nurses.Size = new System.Drawing.Size(1150, 650);
            this.tabControl_nurses.TabIndex = 1;
            // 
            // tb_nurses
            // 
            this.tb_nurses.Controls.Add(this.btn_save);
            this.tb_nurses.Controls.Add(this.dtgrid_nurses);
            this.tb_nurses.Location = new System.Drawing.Point(4, 31);
            this.tb_nurses.Name = "tb_nurses";
            this.tb_nurses.Padding = new System.Windows.Forms.Padding(3);
            this.tb_nurses.Size = new System.Drawing.Size(1142, 615);
            this.tb_nurses.TabIndex = 0;
            this.tb_nurses.Text = "Nurses";
            this.tb_nurses.UseVisualStyleBackColor = true;
            this.tb_nurses.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1015, 584);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 33);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtgrid_nurses
            // 
            this.dtgrid_nurses.AllowUserToAddRows = false;
            this.dtgrid_nurses.AllowUserToDeleteRows = false;
            this.dtgrid_nurses.AllowUserToResizeColumns = false;
            this.dtgrid_nurses.AllowUserToResizeRows = false;
            this.dtgrid_nurses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_nurses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_nurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_nurses.Location = new System.Drawing.Point(6, 50);
            this.dtgrid_nurses.Name = "dtgrid_nurses";
            this.dtgrid_nurses.RowTemplate.Height = 28;
            this.dtgrid_nurses.Size = new System.Drawing.Size(1129, 528);
            this.dtgrid_nurses.TabIndex = 0;
            // 
            // tb_addNurse
            // 
            this.tb_addNurse.Controls.Add(this.gbox_addNurse);
            this.tb_addNurse.Location = new System.Drawing.Point(4, 31);
            this.tb_addNurse.Name = "tb_addNurse";
            this.tb_addNurse.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addNurse.Size = new System.Drawing.Size(1142, 615);
            this.tb_addNurse.TabIndex = 1;
            this.tb_addNurse.Text = "Add Nurses";
            this.tb_addNurse.UseVisualStyleBackColor = true;
            // 
            // gbox_addNurse
            // 
            this.gbox_addNurse.Controls.Add(this.lbl_NurseName);
            this.gbox_addNurse.Controls.Add(this.btn_addNurse);
            this.gbox_addNurse.Controls.Add(this.txt_NurseName);
            this.gbox_addNurse.Controls.Add(this.lbl_NurseCity);
            this.gbox_addNurse.Controls.Add(this.txt_nurseSurname);
            this.gbox_addNurse.Controls.Add(this.lbl_NursePhone);
            this.gbox_addNurse.Controls.Add(this.txt_NursePhone);
            this.gbox_addNurse.Controls.Add(this.lbl_NurseGender);
            this.gbox_addNurse.Controls.Add(this.dtime_nurseBirthday);
            this.gbox_addNurse.Controls.Add(this.lbl_NurseBirthday);
            this.gbox_addNurse.Controls.Add(this.cmb_nurseGender);
            this.gbox_addNurse.Controls.Add(this.lbl_NurseSurname);
            this.gbox_addNurse.Controls.Add(this.cmb_NurseCity);
            this.gbox_addNurse.Location = new System.Drawing.Point(30, 30);
            this.gbox_addNurse.Name = "gbox_addNurse";
            this.gbox_addNurse.Size = new System.Drawing.Size(500, 528);
            this.gbox_addNurse.TabIndex = 13;
            this.gbox_addNurse.TabStop = false;
            this.gbox_addNurse.Text = "Add Form";
            // 
            // lbl_NurseName
            // 
            this.lbl_NurseName.AutoSize = true;
            this.lbl_NurseName.Location = new System.Drawing.Point(41, 99);
            this.lbl_NurseName.Name = "lbl_NurseName";
            this.lbl_NurseName.Size = new System.Drawing.Size(53, 22);
            this.lbl_NurseName.TabIndex = 6;
            this.lbl_NurseName.Text = "Name";
            // 
            // btn_addNurse
            // 
            this.btn_addNurse.Location = new System.Drawing.Point(312, 392);
            this.btn_addNurse.Name = "btn_addNurse";
            this.btn_addNurse.Size = new System.Drawing.Size(120, 30);
            this.btn_addNurse.TabIndex = 12;
            this.btn_addNurse.Text = "Save";
            this.btn_addNurse.UseVisualStyleBackColor = true;
            this.btn_addNurse.Click += new System.EventHandler(this.btn_addNurse_Click);
            // 
            // txt_NurseName
            // 
            this.txt_NurseName.Location = new System.Drawing.Point(132, 91);
            this.txt_NurseName.Name = "txt_NurseName";
            this.txt_NurseName.Size = new System.Drawing.Size(300, 29);
            this.txt_NurseName.TabIndex = 0;
            // 
            // lbl_NurseCity
            // 
            this.lbl_NurseCity.AutoSize = true;
            this.lbl_NurseCity.Location = new System.Drawing.Point(41, 350);
            this.lbl_NurseCity.Name = "lbl_NurseCity";
            this.lbl_NurseCity.Size = new System.Drawing.Size(36, 22);
            this.lbl_NurseCity.TabIndex = 11;
            this.lbl_NurseCity.Text = "City";
            // 
            // txt_nurseSurname
            // 
            this.txt_nurseSurname.Location = new System.Drawing.Point(132, 141);
            this.txt_nurseSurname.Name = "txt_nurseSurname";
            this.txt_nurseSurname.Size = new System.Drawing.Size(300, 29);
            this.txt_nurseSurname.TabIndex = 1;
            // 
            // lbl_NursePhone
            // 
            this.lbl_NursePhone.AutoSize = true;
            this.lbl_NursePhone.Location = new System.Drawing.Point(41, 300);
            this.lbl_NursePhone.Name = "lbl_NursePhone";
            this.lbl_NursePhone.Size = new System.Drawing.Size(55, 22);
            this.lbl_NursePhone.TabIndex = 10;
            this.lbl_NursePhone.Text = "Phone";
            // 
            // txt_NursePhone
            // 
            this.txt_NursePhone.Location = new System.Drawing.Point(132, 292);
            this.txt_NursePhone.Name = "txt_NursePhone";
            this.txt_NursePhone.Size = new System.Drawing.Size(300, 29);
            this.txt_NursePhone.TabIndex = 2;
            // 
            // lbl_NurseGender
            // 
            this.lbl_NurseGender.AutoSize = true;
            this.lbl_NurseGender.Location = new System.Drawing.Point(41, 250);
            this.lbl_NurseGender.Name = "lbl_NurseGender";
            this.lbl_NurseGender.Size = new System.Drawing.Size(65, 22);
            this.lbl_NurseGender.TabIndex = 9;
            this.lbl_NurseGender.Text = "Gender";
            // 
            // dtime_nurseBirthday
            // 
            this.dtime_nurseBirthday.CustomFormat = "yyyy-mm-dd";
            this.dtime_nurseBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_nurseBirthday.Location = new System.Drawing.Point(132, 191);
            this.dtime_nurseBirthday.Name = "dtime_nurseBirthday";
            this.dtime_nurseBirthday.Size = new System.Drawing.Size(300, 29);
            this.dtime_nurseBirthday.TabIndex = 3;
            // 
            // lbl_NurseBirthday
            // 
            this.lbl_NurseBirthday.AutoSize = true;
            this.lbl_NurseBirthday.Location = new System.Drawing.Point(41, 199);
            this.lbl_NurseBirthday.Name = "lbl_NurseBirthday";
            this.lbl_NurseBirthday.Size = new System.Drawing.Size(69, 22);
            this.lbl_NurseBirthday.TabIndex = 8;
            this.lbl_NurseBirthday.Text = "Birthday";
            // 
            // cmb_nurseGender
            // 
            this.cmb_nurseGender.FormattingEnabled = true;
            this.cmb_nurseGender.Location = new System.Drawing.Point(132, 241);
            this.cmb_nurseGender.Name = "cmb_nurseGender";
            this.cmb_nurseGender.Size = new System.Drawing.Size(300, 30);
            this.cmb_nurseGender.TabIndex = 4;
            // 
            // lbl_NurseSurname
            // 
            this.lbl_NurseSurname.AutoSize = true;
            this.lbl_NurseSurname.Location = new System.Drawing.Point(41, 149);
            this.lbl_NurseSurname.Name = "lbl_NurseSurname";
            this.lbl_NurseSurname.Size = new System.Drawing.Size(74, 22);
            this.lbl_NurseSurname.TabIndex = 7;
            this.lbl_NurseSurname.Text = "Surname";
            // 
            // cmb_NurseCity
            // 
            this.cmb_NurseCity.FormattingEnabled = true;
            this.cmb_NurseCity.Location = new System.Drawing.Point(132, 342);
            this.cmb_NurseCity.Name = "cmb_NurseCity";
            this.cmb_NurseCity.Size = new System.Drawing.Size(300, 30);
            this.cmb_NurseCity.TabIndex = 5;
            // 
            // tb_delete
            // 
            this.tb_delete.Controls.Add(this.groupBox1);
            this.tb_delete.Location = new System.Drawing.Point(4, 31);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Padding = new System.Windows.Forms.Padding(3);
            this.tb_delete.Size = new System.Drawing.Size(1142, 615);
            this.tb_delete.TabIndex = 2;
            this.tb_delete.Text = "Delete Nurse";
            this.tb_delete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_nurseDelete);
            this.groupBox1.Controls.Add(this.lbl_NurseId);
            this.groupBox1.Controls.Add(this.btn_deleteNurse);
            this.groupBox1.Location = new System.Drawing.Point(30, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Form";
            // 
            // cmb_nurseDelete
            // 
            this.cmb_nurseDelete.FormattingEnabled = true;
            this.cmb_nurseDelete.Location = new System.Drawing.Point(121, 70);
            this.cmb_nurseDelete.Name = "cmb_nurseDelete";
            this.cmb_nurseDelete.Size = new System.Drawing.Size(336, 30);
            this.cmb_nurseDelete.TabIndex = 2;
            // 
            // lbl_NurseId
            // 
            this.lbl_NurseId.AutoSize = true;
            this.lbl_NurseId.Location = new System.Drawing.Point(42, 77);
            this.lbl_NurseId.Name = "lbl_NurseId";
            this.lbl_NurseId.Size = new System.Drawing.Size(53, 22);
            this.lbl_NurseId.TabIndex = 1;
            this.lbl_NurseId.Text = "Nurse";
            // 
            // btn_deleteNurse
            // 
            this.btn_deleteNurse.Location = new System.Drawing.Point(337, 106);
            this.btn_deleteNurse.Name = "btn_deleteNurse";
            this.btn_deleteNurse.Size = new System.Drawing.Size(120, 30);
            this.btn_deleteNurse.TabIndex = 0;
            this.btn_deleteNurse.Text = "Delete";
            this.btn_deleteNurse.UseVisualStyleBackColor = true;
            this.btn_deleteNurse.Click += new System.EventHandler(this.btn_deleteNurse_Click);
            // 
            // frm_nurses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 672);
            this.Controls.Add(this.tabControl_nurses);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_nurses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nurses";
            this.Load += new System.EventHandler(this.frm_nurses_Load);
            this.tabControl_nurses.ResumeLayout(false);
            this.tb_nurses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_nurses)).EndInit();
            this.tb_addNurse.ResumeLayout(false);
            this.gbox_addNurse.ResumeLayout(false);
            this.gbox_addNurse.PerformLayout();
            this.tb_delete.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_nurses;
        private System.Windows.Forms.TabPage tb_nurses;
        private System.Windows.Forms.TabPage tb_addNurse;
        private System.Windows.Forms.TabPage tb_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dtgrid_nurses;
        private System.Windows.Forms.Button btn_addNurse;
        private System.Windows.Forms.Label lbl_NurseCity;
        private System.Windows.Forms.Label lbl_NursePhone;
        private System.Windows.Forms.Label lbl_NurseGender;
        private System.Windows.Forms.Label lbl_NurseBirthday;
        private System.Windows.Forms.Label lbl_NurseSurname;
        private System.Windows.Forms.Label lbl_NurseName;
        private System.Windows.Forms.ComboBox cmb_NurseCity;
        private System.Windows.Forms.ComboBox cmb_nurseGender;
        private System.Windows.Forms.DateTimePicker dtime_nurseBirthday;
        private System.Windows.Forms.TextBox txt_NursePhone;
        private System.Windows.Forms.TextBox txt_nurseSurname;
        private System.Windows.Forms.TextBox txt_NurseName;
        private System.Windows.Forms.Label lbl_NurseId;
        private System.Windows.Forms.Button btn_deleteNurse;
        private System.Windows.Forms.GroupBox gbox_addNurse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_nurseDelete;
    }
}