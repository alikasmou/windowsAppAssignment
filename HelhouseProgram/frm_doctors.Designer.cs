namespace HelhouseProgram
{
    partial class frm_doctors
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
            this.tb_deleteDoctor = new System.Windows.Forms.TabPage();
            this.gbox_deleteDoctor = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_doctorID = new System.Windows.Forms.Label();
            this.cmb_docId = new System.Windows.Forms.ComboBox();
            this.tb_addDoctors = new System.Windows.Forms.TabPage();
            this.gbox_doctorsAdd = new System.Windows.Forms.GroupBox();
            this.txt_docSurname = new System.Windows.Forms.TextBox();
            this.btn_addDoctor = new System.Windows.Forms.Button();
            this.lbl_docCity = new System.Windows.Forms.Label();
            this.dtime_docBirthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_docPhone = new System.Windows.Forms.Label();
            this.lbl_docBirthday = new System.Windows.Forms.Label();
            this.lbl_docSpecialization = new System.Windows.Forms.Label();
            this.cmb_docGender = new System.Windows.Forms.ComboBox();
            this.lbl_docGender = new System.Windows.Forms.Label();
            this.cmb_docSpecialization = new System.Windows.Forms.ComboBox();
            this.lbl_docSurname = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.lbl_docName = new System.Windows.Forms.Label();
            this.txt_docPhone = new System.Windows.Forms.TextBox();
            this.txt_docName = new System.Windows.Forms.TextBox();
            this.tb_doctors = new System.Windows.Forms.TabPage();
            this.dtg_doctors = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.tabControl_doctors = new System.Windows.Forms.TabControl();
            this.tb_deleteDoctor.SuspendLayout();
            this.gbox_deleteDoctor.SuspendLayout();
            this.tb_addDoctors.SuspendLayout();
            this.gbox_doctorsAdd.SuspendLayout();
            this.tb_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doctors)).BeginInit();
            this.tabControl_doctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_deleteDoctor
            // 
            this.tb_deleteDoctor.Controls.Add(this.gbox_deleteDoctor);
            this.tb_deleteDoctor.Location = new System.Drawing.Point(4, 31);
            this.tb_deleteDoctor.Name = "tb_deleteDoctor";
            this.tb_deleteDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tb_deleteDoctor.Size = new System.Drawing.Size(1142, 615);
            this.tb_deleteDoctor.TabIndex = 2;
            this.tb_deleteDoctor.Text = "Delete Doctor";
            this.tb_deleteDoctor.UseVisualStyleBackColor = true;
            // 
            // gbox_deleteDoctor
            // 
            this.gbox_deleteDoctor.Controls.Add(this.cmb_docId);
            this.gbox_deleteDoctor.Controls.Add(this.lbl_doctorID);
            this.gbox_deleteDoctor.Controls.Add(this.btn_delete);
            this.gbox_deleteDoctor.Location = new System.Drawing.Point(30, 30);
            this.gbox_deleteDoctor.Name = "gbox_deleteDoctor";
            this.gbox_deleteDoctor.Size = new System.Drawing.Size(500, 250);
            this.gbox_deleteDoctor.TabIndex = 5;
            this.gbox_deleteDoctor.TabStop = false;
            this.gbox_deleteDoctor.Text = "Delete Form";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(322, 108);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 30);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_doctorID
            // 
            this.lbl_doctorID.AutoSize = true;
            this.lbl_doctorID.Location = new System.Drawing.Point(50, 79);
            this.lbl_doctorID.Name = "lbl_doctorID";
            this.lbl_doctorID.Size = new System.Drawing.Size(58, 22);
            this.lbl_doctorID.TabIndex = 0;
            this.lbl_doctorID.Text = "Doctor";
            // 
            // cmb_docId
            // 
            this.cmb_docId.FormattingEnabled = true;
            this.cmb_docId.Location = new System.Drawing.Point(142, 72);
            this.cmb_docId.Name = "cmb_docId";
            this.cmb_docId.Size = new System.Drawing.Size(300, 30);
            this.cmb_docId.TabIndex = 5;
            // 
            // tb_addDoctors
            // 
            this.tb_addDoctors.Controls.Add(this.gbox_doctorsAdd);
            this.tb_addDoctors.Location = new System.Drawing.Point(4, 31);
            this.tb_addDoctors.Name = "tb_addDoctors";
            this.tb_addDoctors.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addDoctors.Size = new System.Drawing.Size(1142, 615);
            this.tb_addDoctors.TabIndex = 1;
            this.tb_addDoctors.Text = "Add Doctors";
            this.tb_addDoctors.UseVisualStyleBackColor = true;
            this.tb_addDoctors.Click += new System.EventHandler(this.tb_addDoctors_Click);
            // 
            // gbox_doctorsAdd
            // 
            this.gbox_doctorsAdd.Controls.Add(this.txt_docName);
            this.gbox_doctorsAdd.Controls.Add(this.txt_docPhone);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docName);
            this.gbox_doctorsAdd.Controls.Add(this.cmb_city);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docSurname);
            this.gbox_doctorsAdd.Controls.Add(this.cmb_docSpecialization);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docGender);
            this.gbox_doctorsAdd.Controls.Add(this.cmb_docGender);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docSpecialization);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docBirthday);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docPhone);
            this.gbox_doctorsAdd.Controls.Add(this.dtime_docBirthday);
            this.gbox_doctorsAdd.Controls.Add(this.lbl_docCity);
            this.gbox_doctorsAdd.Controls.Add(this.btn_addDoctor);
            this.gbox_doctorsAdd.Controls.Add(this.txt_docSurname);
            this.gbox_doctorsAdd.Location = new System.Drawing.Point(30, 30);
            this.gbox_doctorsAdd.Name = "gbox_doctorsAdd";
            this.gbox_doctorsAdd.Size = new System.Drawing.Size(500, 528);
            this.gbox_doctorsAdd.TabIndex = 21;
            this.gbox_doctorsAdd.TabStop = false;
            this.gbox_doctorsAdd.Text = "Add Form";
            // 
            // txt_docSurname
            // 
            this.txt_docSurname.Location = new System.Drawing.Point(170, 121);
            this.txt_docSurname.Name = "txt_docSurname";
            this.txt_docSurname.Size = new System.Drawing.Size(300, 29);
            this.txt_docSurname.TabIndex = 8;
            // 
            // btn_addDoctor
            // 
            this.btn_addDoctor.Location = new System.Drawing.Point(350, 446);
            this.btn_addDoctor.Name = "btn_addDoctor";
            this.btn_addDoctor.Size = new System.Drawing.Size(120, 33);
            this.btn_addDoctor.TabIndex = 14;
            this.btn_addDoctor.Text = "Add";
            this.btn_addDoctor.UseVisualStyleBackColor = true;
            this.btn_addDoctor.Click += new System.EventHandler(this.btn_addDoctor_Click);
            // 
            // lbl_docCity
            // 
            this.lbl_docCity.AutoSize = true;
            this.lbl_docCity.Location = new System.Drawing.Point(25, 398);
            this.lbl_docCity.Name = "lbl_docCity";
            this.lbl_docCity.Size = new System.Drawing.Size(36, 22);
            this.lbl_docCity.TabIndex = 6;
            this.lbl_docCity.Text = "City";
            // 
            // dtime_docBirthday
            // 
            this.dtime_docBirthday.CustomFormat = "yyyy-mm-dd";
            this.dtime_docBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_docBirthday.Location = new System.Drawing.Point(170, 174);
            this.dtime_docBirthday.Name = "dtime_docBirthday";
            this.dtime_docBirthday.Size = new System.Drawing.Size(300, 29);
            this.dtime_docBirthday.TabIndex = 15;
            // 
            // lbl_docPhone
            // 
            this.lbl_docPhone.AutoSize = true;
            this.lbl_docPhone.Location = new System.Drawing.Point(25, 343);
            this.lbl_docPhone.Name = "lbl_docPhone";
            this.lbl_docPhone.Size = new System.Drawing.Size(55, 22);
            this.lbl_docPhone.TabIndex = 5;
            this.lbl_docPhone.Text = "Phone";
            // 
            // lbl_docBirthday
            // 
            this.lbl_docBirthday.AutoSize = true;
            this.lbl_docBirthday.Location = new System.Drawing.Point(25, 181);
            this.lbl_docBirthday.Name = "lbl_docBirthday";
            this.lbl_docBirthday.Size = new System.Drawing.Size(69, 22);
            this.lbl_docBirthday.TabIndex = 16;
            this.lbl_docBirthday.Text = "Birthday";
            // 
            // lbl_docSpecialization
            // 
            this.lbl_docSpecialization.AutoSize = true;
            this.lbl_docSpecialization.Location = new System.Drawing.Point(25, 291);
            this.lbl_docSpecialization.Name = "lbl_docSpecialization";
            this.lbl_docSpecialization.Size = new System.Drawing.Size(108, 22);
            this.lbl_docSpecialization.TabIndex = 4;
            this.lbl_docSpecialization.Text = "Specialization";
            this.lbl_docSpecialization.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmb_docGender
            // 
            this.cmb_docGender.FormattingEnabled = true;
            this.cmb_docGender.Location = new System.Drawing.Point(170, 227);
            this.cmb_docGender.Name = "cmb_docGender";
            this.cmb_docGender.Size = new System.Drawing.Size(300, 30);
            this.cmb_docGender.TabIndex = 17;
            // 
            // lbl_docGender
            // 
            this.lbl_docGender.AutoSize = true;
            this.lbl_docGender.Location = new System.Drawing.Point(25, 236);
            this.lbl_docGender.Name = "lbl_docGender";
            this.lbl_docGender.Size = new System.Drawing.Size(65, 22);
            this.lbl_docGender.TabIndex = 3;
            this.lbl_docGender.Text = "Gender";
            // 
            // cmb_docSpecialization
            // 
            this.cmb_docSpecialization.FormattingEnabled = true;
            this.cmb_docSpecialization.Location = new System.Drawing.Point(170, 282);
            this.cmb_docSpecialization.Name = "cmb_docSpecialization";
            this.cmb_docSpecialization.Size = new System.Drawing.Size(300, 30);
            this.cmb_docSpecialization.TabIndex = 18;
            // 
            // lbl_docSurname
            // 
            this.lbl_docSurname.AutoSize = true;
            this.lbl_docSurname.Location = new System.Drawing.Point(25, 128);
            this.lbl_docSurname.Name = "lbl_docSurname";
            this.lbl_docSurname.Size = new System.Drawing.Size(74, 22);
            this.lbl_docSurname.TabIndex = 1;
            this.lbl_docSurname.Text = "Surname";
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(170, 390);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(300, 30);
            this.cmb_city.TabIndex = 19;
            // 
            // lbl_docName
            // 
            this.lbl_docName.AutoSize = true;
            this.lbl_docName.Location = new System.Drawing.Point(25, 75);
            this.lbl_docName.Name = "lbl_docName";
            this.lbl_docName.Size = new System.Drawing.Size(53, 22);
            this.lbl_docName.TabIndex = 0;
            this.lbl_docName.Text = "Name";
            // 
            // txt_docPhone
            // 
            this.txt_docPhone.Location = new System.Drawing.Point(170, 337);
            this.txt_docPhone.Name = "txt_docPhone";
            this.txt_docPhone.Size = new System.Drawing.Size(300, 29);
            this.txt_docPhone.TabIndex = 20;
            // 
            // txt_docName
            // 
            this.txt_docName.Location = new System.Drawing.Point(170, 68);
            this.txt_docName.Name = "txt_docName";
            this.txt_docName.Size = new System.Drawing.Size(300, 29);
            this.txt_docName.TabIndex = 7;
            // 
            // tb_doctors
            // 
            this.tb_doctors.Controls.Add(this.btn_save);
            this.tb_doctors.Controls.Add(this.dtg_doctors);
            this.tb_doctors.Location = new System.Drawing.Point(4, 31);
            this.tb_doctors.Name = "tb_doctors";
            this.tb_doctors.Padding = new System.Windows.Forms.Padding(3);
            this.tb_doctors.Size = new System.Drawing.Size(1142, 615);
            this.tb_doctors.TabIndex = 0;
            this.tb_doctors.Text = "Doctors";
            this.tb_doctors.UseVisualStyleBackColor = true;
            // 
            // dtg_doctors
            // 
            this.dtg_doctors.AllowUserToAddRows = false;
            this.dtg_doctors.AllowUserToDeleteRows = false;
            this.dtg_doctors.AllowUserToResizeColumns = false;
            this.dtg_doctors.AllowUserToResizeRows = false;
            this.dtg_doctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_doctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_doctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doctors.Location = new System.Drawing.Point(6, 7);
            this.dtg_doctors.Name = "dtg_doctors";
            this.dtg_doctors.RowTemplate.Height = 28;
            this.dtg_doctors.Size = new System.Drawing.Size(1129, 528);
            this.dtg_doctors.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1015, 541);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 33);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tabControl_doctors
            // 
            this.tabControl_doctors.Controls.Add(this.tb_doctors);
            this.tabControl_doctors.Controls.Add(this.tb_addDoctors);
            this.tabControl_doctors.Controls.Add(this.tb_deleteDoctor);
            this.tabControl_doctors.Location = new System.Drawing.Point(12, 12);
            this.tabControl_doctors.Name = "tabControl_doctors";
            this.tabControl_doctors.SelectedIndex = 0;
            this.tabControl_doctors.Size = new System.Drawing.Size(1150, 650);
            this.tabControl_doctors.TabIndex = 0;
            // 
            // frm_doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 672);
            this.Controls.Add(this.tabControl_doctors);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.frm_doctors_Load);
            this.tb_deleteDoctor.ResumeLayout(false);
            this.gbox_deleteDoctor.ResumeLayout(false);
            this.gbox_deleteDoctor.PerformLayout();
            this.tb_addDoctors.ResumeLayout(false);
            this.gbox_doctorsAdd.ResumeLayout(false);
            this.gbox_doctorsAdd.PerformLayout();
            this.tb_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doctors)).EndInit();
            this.tabControl_doctors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tb_deleteDoctor;
        private System.Windows.Forms.GroupBox gbox_deleteDoctor;
        private System.Windows.Forms.ComboBox cmb_docId;
        private System.Windows.Forms.Label lbl_doctorID;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TabPage tb_addDoctors;
        private System.Windows.Forms.GroupBox gbox_doctorsAdd;
        private System.Windows.Forms.TextBox txt_docName;
        private System.Windows.Forms.TextBox txt_docPhone;
        private System.Windows.Forms.Label lbl_docName;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label lbl_docSurname;
        private System.Windows.Forms.ComboBox cmb_docSpecialization;
        private System.Windows.Forms.Label lbl_docGender;
        private System.Windows.Forms.ComboBox cmb_docGender;
        private System.Windows.Forms.Label lbl_docSpecialization;
        private System.Windows.Forms.Label lbl_docBirthday;
        private System.Windows.Forms.Label lbl_docPhone;
        private System.Windows.Forms.DateTimePicker dtime_docBirthday;
        private System.Windows.Forms.Label lbl_docCity;
        private System.Windows.Forms.Button btn_addDoctor;
        private System.Windows.Forms.TextBox txt_docSurname;
        private System.Windows.Forms.TabPage tb_doctors;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dtg_doctors;
        private System.Windows.Forms.TabControl tabControl_doctors;
    }
}