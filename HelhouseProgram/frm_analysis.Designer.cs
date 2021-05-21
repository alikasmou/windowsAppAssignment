namespace HelhouseProgram
{
    partial class frm_analysis
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_analysis = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addAnalysis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.cmb_anaType = new System.Windows.Forms.ComboBox();
            this.cmb_patnt = new System.Windows.Forms.ComboBox();
            this.cmb_Nurse = new System.Windows.Forms.ComboBox();
            this.dtime_anaDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_anaId = new System.Windows.Forms.TextBox();
            this.btn_anaDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analysis)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1153, 714);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtg_analysis);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1145, 679);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analysis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1019, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_analysis
            // 
            this.dtg_analysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_analysis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_analysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_analysis.Location = new System.Drawing.Point(4, 7);
            this.dtg_analysis.Name = "dtg_analysis";
            this.dtg_analysis.RowTemplate.Height = 28;
            this.dtg_analysis.Size = new System.Drawing.Size(1135, 427);
            this.dtg_analysis.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1145, 679);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Analysis";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addAnalysis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_payment);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Controls.Add(this.cmb_anaType);
            this.groupBox1.Controls.Add(this.cmb_patnt);
            this.groupBox1.Controls.Add(this.cmb_Nurse);
            this.groupBox1.Controls.Add(this.dtime_anaDate);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 666);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Form";
            // 
            // btn_addAnalysis
            // 
            this.btn_addAnalysis.Location = new System.Drawing.Point(373, 384);
            this.btn_addAnalysis.Name = "btn_addAnalysis";
            this.btn_addAnalysis.Size = new System.Drawing.Size(120, 30);
            this.btn_addAnalysis.TabIndex = 14;
            this.btn_addAnalysis.Text = "Save";
            this.btn_addAnalysis.UseVisualStyleBackColor = true;
            this.btn_addAnalysis.Click += new System.EventHandler(this.btn_addAnalysis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Analysis Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nurse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Analysis Date";
            // 
            // txt_payment
            // 
            this.txt_payment.Location = new System.Drawing.Point(193, 336);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(300, 29);
            this.txt_payment.TabIndex = 6;
            // 
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(193, 285);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(300, 29);
            this.txt_fees.TabIndex = 4;
            // 
            // cmb_anaType
            // 
            this.cmb_anaType.FormattingEnabled = true;
            this.cmb_anaType.Location = new System.Drawing.Point(193, 233);
            this.cmb_anaType.Name = "cmb_anaType";
            this.cmb_anaType.Size = new System.Drawing.Size(300, 30);
            this.cmb_anaType.TabIndex = 3;
            // 
            // cmb_patnt
            // 
            this.cmb_patnt.FormattingEnabled = true;
            this.cmb_patnt.Location = new System.Drawing.Point(193, 181);
            this.cmb_patnt.Name = "cmb_patnt";
            this.cmb_patnt.Size = new System.Drawing.Size(300, 30);
            this.cmb_patnt.TabIndex = 2;
            // 
            // cmb_Nurse
            // 
            this.cmb_Nurse.FormattingEnabled = true;
            this.cmb_Nurse.Location = new System.Drawing.Point(193, 129);
            this.cmb_Nurse.Name = "cmb_Nurse";
            this.cmb_Nurse.Size = new System.Drawing.Size(300, 30);
            this.cmb_Nurse.TabIndex = 1;
            // 
            // dtime_anaDate
            // 
            this.dtime_anaDate.CustomFormat = "yyyy-mm-dd";
            this.dtime_anaDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_anaDate.Location = new System.Drawing.Point(193, 78);
            this.dtime_anaDate.Name = "dtime_anaDate";
            this.dtime_anaDate.Size = new System.Drawing.Size(300, 29);
            this.dtime_anaDate.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1145, 679);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Analysis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_anaId);
            this.groupBox2.Controls.Add(this.btn_anaDelete);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 260);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Form";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Analysis ID";
            // 
            // txt_anaId
            // 
            this.txt_anaId.Location = new System.Drawing.Point(153, 93);
            this.txt_anaId.Name = "txt_anaId";
            this.txt_anaId.Size = new System.Drawing.Size(300, 29);
            this.txt_anaId.TabIndex = 1;
            // 
            // btn_anaDelete
            // 
            this.btn_anaDelete.Location = new System.Drawing.Point(333, 141);
            this.btn_anaDelete.Name = "btn_anaDelete";
            this.btn_anaDelete.Size = new System.Drawing.Size(120, 30);
            this.btn_anaDelete.TabIndex = 0;
            this.btn_anaDelete.Text = "Delete";
            this.btn_anaDelete.UseVisualStyleBackColor = true;
            // 
            // frm_analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 739);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_analysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.frm_analysis_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analysis)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_analysis;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addAnalysis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.ComboBox cmb_anaType;
        private System.Windows.Forms.ComboBox cmb_patnt;
        private System.Windows.Forms.ComboBox cmb_Nurse;
        private System.Windows.Forms.DateTimePicker dtime_anaDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_anaId;
        private System.Windows.Forms.Button btn_anaDelete;
    }
}