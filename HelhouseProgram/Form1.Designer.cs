namespace HelhouseProgram
{
    partial class frm_cpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cpanel));
            this.btn_reprts = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_patients = new System.Windows.Forms.Button();
            this.btn_nurses = new System.Windows.Forms.Button();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.btn_operationForm = new System.Windows.Forms.Button();
            this.btn_analysisForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_reprts
            // 
            this.btn_reprts.BackColor = System.Drawing.Color.Transparent;
            this.btn_reprts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reprts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_reprts, "btn_reprts");
            this.btn_reprts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reprts.Name = "btn_reprts";
            this.btn_reprts.UseVisualStyleBackColor = false;
            this.btn_reprts.Click += new System.EventHandler(this.btn_reprts_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.Transparent;
            this.btn_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_reports, "btn_reports");
            this.btn_reports.ForeColor = System.Drawing.Color.Transparent;
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_patients
            // 
            this.btn_patients.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_patients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_patients.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_patients, "btn_patients");
            this.btn_patients.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_patients.Name = "btn_patients";
            this.btn_patients.UseVisualStyleBackColor = false;
            this.btn_patients.Click += new System.EventHandler(this.btn_patients_Click);
            // 
            // btn_nurses
            // 
            this.btn_nurses.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_nurses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nurses.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_nurses, "btn_nurses");
            this.btn_nurses.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_nurses.Name = "btn_nurses";
            this.btn_nurses.UseVisualStyleBackColor = false;
            this.btn_nurses.Click += new System.EventHandler(this.btn_nurses_Click);
            // 
            // btn_doctors
            // 
            this.btn_doctors.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_doctors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doctors.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_doctors, "btn_doctors");
            this.btn_doctors.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // btn_operationForm
            // 
            this.btn_operationForm.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_operationForm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_operationForm, "btn_operationForm");
            this.btn_operationForm.Name = "btn_operationForm";
            this.btn_operationForm.UseVisualStyleBackColor = false;
            this.btn_operationForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_analysisForm
            // 
            this.btn_analysisForm.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_analysisForm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_analysisForm, "btn_analysisForm");
            this.btn_analysisForm.Name = "btn_analysisForm";
            this.btn_analysisForm.UseVisualStyleBackColor = false;
            this.btn_analysisForm.Click += new System.EventHandler(this.btn_analysisForm_Click);
            // 
            // frm_cpanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_analysisForm);
            this.Controls.Add(this.btn_operationForm);
            this.Controls.Add(this.btn_doctors);
            this.Controls.Add(this.btn_nurses);
            this.Controls.Add(this.btn_patients);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_reprts);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_cpanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cpanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reprts;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_patients;
        private System.Windows.Forms.Button btn_nurses;
        private System.Windows.Forms.Button btn_doctors;
        private System.Windows.Forms.Button btn_operationForm;
        private System.Windows.Forms.Button btn_analysisForm;
    }
}

