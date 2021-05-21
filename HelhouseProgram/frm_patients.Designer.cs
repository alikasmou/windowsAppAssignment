namespace HelhouseProgram
{
    partial class frm_patients
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
            this.tbControl_patient = new System.Windows.Forms.TabControl();
            this.tb_Patient = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtGrid_patnt = new System.Windows.Forms.DataGridView();
            this.tb_addPatient = new System.Windows.Forms.TabPage();
            this.gbox_addForm = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtime_ptntBirthday = new System.Windows.Forms.DateTimePicker();
            this.cmb_patntGender = new System.Windows.Forms.ComboBox();
            this.cmb_patntCity = new System.Windows.Forms.ComboBox();
            this.txt_patntPhone = new System.Windows.Forms.TextBox();
            this.txt_patntSurname = new System.Windows.Forms.TextBox();
            this.txt_patntName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_deletePatient = new System.Windows.Forms.TabPage();
            this.gbox_deleteForm = new System.Windows.Forms.GroupBox();
            this.cmb_patntIddelete = new System.Windows.Forms.ComboBox();
            this.lbl_patntId = new System.Windows.Forms.Label();
            this.btn_patntDelete = new System.Windows.Forms.Button();
            this.tbControl_patient.SuspendLayout();
            this.tb_Patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_patnt)).BeginInit();
            this.tb_addPatient.SuspendLayout();
            this.gbox_addForm.SuspendLayout();
            this.tb_deletePatient.SuspendLayout();
            this.gbox_deleteForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl_patient
            // 
            this.tbControl_patient.Controls.Add(this.tb_Patient);
            this.tbControl_patient.Controls.Add(this.tb_addPatient);
            this.tbControl_patient.Controls.Add(this.tb_deletePatient);
            this.tbControl_patient.Location = new System.Drawing.Point(12, 13);
            this.tbControl_patient.Name = "tbControl_patient";
            this.tbControl_patient.SelectedIndex = 0;
            this.tbControl_patient.Size = new System.Drawing.Size(1150, 715);
            this.tbControl_patient.TabIndex = 0;
            // 
            // tb_Patient
            // 
            this.tb_Patient.Controls.Add(this.button1);
            this.tb_Patient.Controls.Add(this.dtGrid_patnt);
            this.tb_Patient.Location = new System.Drawing.Point(4, 31);
            this.tb_Patient.Name = "tb_Patient";
            this.tb_Patient.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Patient.Size = new System.Drawing.Size(1142, 680);
            this.tb_Patient.TabIndex = 0;
            this.tb_Patient.Text = "Patients";
            this.tb_Patient.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1016, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtGrid_patnt
            // 
            this.dtGrid_patnt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtGrid_patnt.AllowUserToAddRows = false;
            this.dtGrid_patnt.AllowUserToDeleteRows = false;
            this.dtGrid_patnt.AllowUserToResizeColumns = false;
            this.dtGrid_patnt.AllowUserToResizeRows = false;
            this.dtGrid_patnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrid_patnt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtGrid_patnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid_patnt.Location = new System.Drawing.Point(7, 28);
            this.dtGrid_patnt.Name = "dtGrid_patnt";
            this.dtGrid_patnt.RowTemplate.Height = 28;
            this.dtGrid_patnt.Size = new System.Drawing.Size(1129, 581);
            this.dtGrid_patnt.TabIndex = 0;
            // 
            // tb_addPatient
            // 
            this.tb_addPatient.Controls.Add(this.gbox_addForm);
            this.tb_addPatient.Location = new System.Drawing.Point(4, 31);
            this.tb_addPatient.Name = "tb_addPatient";
            this.tb_addPatient.Padding = new System.Windows.Forms.Padding(3);
            this.tb_addPatient.Size = new System.Drawing.Size(1142, 680);
            this.tb_addPatient.TabIndex = 1;
            this.tb_addPatient.Text = "Add Patient";
            this.tb_addPatient.UseVisualStyleBackColor = true;
            // 
            // gbox_addForm
            // 
            this.gbox_addForm.Controls.Add(this.button2);
            this.gbox_addForm.Controls.Add(this.dtime_ptntBirthday);
            this.gbox_addForm.Controls.Add(this.cmb_patntGender);
            this.gbox_addForm.Controls.Add(this.cmb_patntCity);
            this.gbox_addForm.Controls.Add(this.txt_patntPhone);
            this.gbox_addForm.Controls.Add(this.txt_patntSurname);
            this.gbox_addForm.Controls.Add(this.txt_patntName);
            this.gbox_addForm.Controls.Add(this.label6);
            this.gbox_addForm.Controls.Add(this.label5);
            this.gbox_addForm.Controls.Add(this.label4);
            this.gbox_addForm.Controls.Add(this.label3);
            this.gbox_addForm.Controls.Add(this.label2);
            this.gbox_addForm.Controls.Add(this.label1);
            this.gbox_addForm.Location = new System.Drawing.Point(30, 30);
            this.gbox_addForm.Name = "gbox_addForm";
            this.gbox_addForm.Size = new System.Drawing.Size(500, 528);
            this.gbox_addForm.TabIndex = 0;
            this.gbox_addForm.TabStop = false;
            this.gbox_addForm.Text = "Add Form";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtime_ptntBirthday
            // 
            this.dtime_ptntBirthday.CustomFormat = "yyyy-mm-dd";
            this.dtime_ptntBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_ptntBirthday.Location = new System.Drawing.Point(155, 165);
            this.dtime_ptntBirthday.Name = "dtime_ptntBirthday";
            this.dtime_ptntBirthday.Size = new System.Drawing.Size(300, 29);
            this.dtime_ptntBirthday.TabIndex = 11;
            // 
            // cmb_patntGender
            // 
            this.cmb_patntGender.FormattingEnabled = true;
            this.cmb_patntGender.Location = new System.Drawing.Point(155, 223);
            this.cmb_patntGender.Name = "cmb_patntGender";
            this.cmb_patntGender.Size = new System.Drawing.Size(300, 30);
            this.cmb_patntGender.TabIndex = 10;
            // 
            // cmb_patntCity
            // 
            this.cmb_patntCity.FormattingEnabled = true;
            this.cmb_patntCity.Location = new System.Drawing.Point(155, 340);
            this.cmb_patntCity.Name = "cmb_patntCity";
            this.cmb_patntCity.Size = new System.Drawing.Size(300, 30);
            this.cmb_patntCity.TabIndex = 9;
            // 
            // txt_patntPhone
            // 
            this.txt_patntPhone.Location = new System.Drawing.Point(155, 282);
            this.txt_patntPhone.Name = "txt_patntPhone";
            this.txt_patntPhone.Size = new System.Drawing.Size(300, 29);
            this.txt_patntPhone.TabIndex = 8;
            // 
            // txt_patntSurname
            // 
            this.txt_patntSurname.Location = new System.Drawing.Point(155, 107);
            this.txt_patntSurname.Name = "txt_patntSurname";
            this.txt_patntSurname.Size = new System.Drawing.Size(300, 29);
            this.txt_patntSurname.TabIndex = 7;
            // 
            // txt_patntName
            // 
            this.txt_patntName.Location = new System.Drawing.Point(155, 49);
            this.txt_patntName.Name = "txt_patntName";
            this.txt_patntName.Size = new System.Drawing.Size(300, 29);
            this.txt_patntName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_deletePatient
            // 
            this.tb_deletePatient.Controls.Add(this.gbox_deleteForm);
            this.tb_deletePatient.Location = new System.Drawing.Point(4, 31);
            this.tb_deletePatient.Name = "tb_deletePatient";
            this.tb_deletePatient.Padding = new System.Windows.Forms.Padding(3);
            this.tb_deletePatient.Size = new System.Drawing.Size(1142, 680);
            this.tb_deletePatient.TabIndex = 2;
            this.tb_deletePatient.Text = "Delete Patient";
            this.tb_deletePatient.UseVisualStyleBackColor = true;
            // 
            // gbox_deleteForm
            // 
            this.gbox_deleteForm.Controls.Add(this.cmb_patntIddelete);
            this.gbox_deleteForm.Controls.Add(this.lbl_patntId);
            this.gbox_deleteForm.Controls.Add(this.btn_patntDelete);
            this.gbox_deleteForm.Location = new System.Drawing.Point(30, 30);
            this.gbox_deleteForm.Name = "gbox_deleteForm";
            this.gbox_deleteForm.Size = new System.Drawing.Size(500, 250);
            this.gbox_deleteForm.TabIndex = 0;
            this.gbox_deleteForm.TabStop = false;
            this.gbox_deleteForm.Text = "Delete form";
            // 
            // cmb_patntIddelete
            // 
            this.cmb_patntIddelete.FormattingEnabled = true;
            this.cmb_patntIddelete.Location = new System.Drawing.Point(100, 45);
            this.cmb_patntIddelete.Name = "cmb_patntIddelete";
            this.cmb_patntIddelete.Size = new System.Drawing.Size(333, 30);
            this.cmb_patntIddelete.TabIndex = 2;
            // 
            // lbl_patntId
            // 
            this.lbl_patntId.AutoSize = true;
            this.lbl_patntId.Location = new System.Drawing.Point(15, 52);
            this.lbl_patntId.Name = "lbl_patntId";
            this.lbl_patntId.Size = new System.Drawing.Size(59, 22);
            this.lbl_patntId.TabIndex = 1;
            this.lbl_patntId.Text = "Patient";
            // 
            // btn_patntDelete
            // 
            this.btn_patntDelete.Location = new System.Drawing.Point(313, 96);
            this.btn_patntDelete.Name = "btn_patntDelete";
            this.btn_patntDelete.Size = new System.Drawing.Size(120, 30);
            this.btn_patntDelete.TabIndex = 0;
            this.btn_patntDelete.Text = "Delete";
            this.btn_patntDelete.UseVisualStyleBackColor = true;
            this.btn_patntDelete.Click += new System.EventHandler(this.btn_patntDelete_Click);
            // 
            // frm_patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 739);
            this.Controls.Add(this.tbControl_patient);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_patients";
            this.Load += new System.EventHandler(this.frm_patients_Load);
            this.tbControl_patient.ResumeLayout(false);
            this.tb_Patient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid_patnt)).EndInit();
            this.tb_addPatient.ResumeLayout(false);
            this.gbox_addForm.ResumeLayout(false);
            this.gbox_addForm.PerformLayout();
            this.tb_deletePatient.ResumeLayout(false);
            this.gbox_deleteForm.ResumeLayout(false);
            this.gbox_deleteForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl_patient;
        private System.Windows.Forms.TabPage tb_Patient;
        private System.Windows.Forms.TabPage tb_addPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtGrid_patnt;
        private System.Windows.Forms.GroupBox gbox_addForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtime_ptntBirthday;
        private System.Windows.Forms.ComboBox cmb_patntGender;
        private System.Windows.Forms.ComboBox cmb_patntCity;
        private System.Windows.Forms.TextBox txt_patntPhone;
        private System.Windows.Forms.TextBox txt_patntSurname;
        private System.Windows.Forms.TextBox txt_patntName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tb_deletePatient;
        private System.Windows.Forms.GroupBox gbox_deleteForm;
        private System.Windows.Forms.Label lbl_patntId;
        private System.Windows.Forms.Button btn_patntDelete;
        private System.Windows.Forms.ComboBox cmb_patntIddelete;
    }
}