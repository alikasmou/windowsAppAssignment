namespace HelhouseProgram
{
    partial class frm_operations
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
            this.dtg_operations = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addOp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.txt_fees = new System.Windows.Forms.TextBox();
            this.cmb_op = new System.Windows.Forms.ComboBox();
            this.cmb_dis = new System.Windows.Forms.ComboBox();
            this.cmb_patnt = new System.Windows.Forms.ComboBox();
            this.cmb_doc = new System.Windows.Forms.ComboBox();
            this.dtime_opDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_deleteOp = new System.Windows.Forms.Button();
            this.txt_opId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_operations)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 698);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtg_operations);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1146, 663);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1020, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_operations
            // 
            this.dtg_operations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_operations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_operations.Location = new System.Drawing.Point(6, 6);
            this.dtg_operations.Name = "dtg_operations";
            this.dtg_operations.RowTemplate.Height = 28;
            this.dtg_operations.Size = new System.Drawing.Size(1134, 402);
            this.dtg_operations.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "add Operations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addOp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_payment);
            this.groupBox1.Controls.Add(this.txt_fees);
            this.groupBox1.Controls.Add(this.cmb_op);
            this.groupBox1.Controls.Add(this.cmb_dis);
            this.groupBox1.Controls.Add(this.cmb_patnt);
            this.groupBox1.Controls.Add(this.cmb_doc);
            this.groupBox1.Controls.Add(this.dtime_opDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 651);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Form";
            // 
            // btn_addOp
            // 
            this.btn_addOp.Location = new System.Drawing.Point(393, 397);
            this.btn_addOp.Name = "btn_addOp";
            this.btn_addOp.Size = new System.Drawing.Size(120, 30);
            this.btn_addOp.TabIndex = 15;
            this.btn_addOp.Text = "Save";
            this.btn_addOp.UseVisualStyleBackColor = true;
            this.btn_addOp.Click += new System.EventHandler(this.btn_addOp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Patient Payment ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fees";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Operation Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Disease";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Operation Date";
            // 
            // txt_payment
            // 
            this.txt_payment.Location = new System.Drawing.Point(213, 353);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(300, 29);
            this.txt_payment.TabIndex = 6;
            // 
            // txt_fees
            // 
            this.txt_fees.Location = new System.Drawing.Point(213, 305);
            this.txt_fees.Name = "txt_fees";
            this.txt_fees.Size = new System.Drawing.Size(300, 29);
            this.txt_fees.TabIndex = 5;
            // 
            // cmb_op
            // 
            this.cmb_op.FormattingEnabled = true;
            this.cmb_op.Location = new System.Drawing.Point(213, 256);
            this.cmb_op.Name = "cmb_op";
            this.cmb_op.Size = new System.Drawing.Size(300, 30);
            this.cmb_op.TabIndex = 4;
            // 
            // cmb_dis
            // 
            this.cmb_dis.FormattingEnabled = true;
            this.cmb_dis.Location = new System.Drawing.Point(213, 207);
            this.cmb_dis.Name = "cmb_dis";
            this.cmb_dis.Size = new System.Drawing.Size(300, 30);
            this.cmb_dis.TabIndex = 3;
            // 
            // cmb_patnt
            // 
            this.cmb_patnt.FormattingEnabled = true;
            this.cmb_patnt.Location = new System.Drawing.Point(213, 158);
            this.cmb_patnt.Name = "cmb_patnt";
            this.cmb_patnt.Size = new System.Drawing.Size(300, 30);
            this.cmb_patnt.TabIndex = 2;
            // 
            // cmb_doc
            // 
            this.cmb_doc.FormattingEnabled = true;
            this.cmb_doc.Location = new System.Drawing.Point(213, 109);
            this.cmb_doc.Name = "cmb_doc";
            this.cmb_doc.Size = new System.Drawing.Size(300, 30);
            this.cmb_doc.TabIndex = 1;
            // 
            // dtime_opDate
            // 
            this.dtime_opDate.CustomFormat = "yyyy-mm-dd";
            this.dtime_opDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_opDate.Location = new System.Drawing.Point(213, 61);
            this.dtime_opDate.Name = "dtime_opDate";
            this.dtime_opDate.Size = new System.Drawing.Size(300, 29);
            this.dtime_opDate.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1146, 663);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Operation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_deleteOp);
            this.groupBox2.Controls.Add(this.txt_opId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1133, 308);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Form";
            // 
            // btn_deleteOp
            // 
            this.btn_deleteOp.Location = new System.Drawing.Point(400, 118);
            this.btn_deleteOp.Name = "btn_deleteOp";
            this.btn_deleteOp.Size = new System.Drawing.Size(120, 30);
            this.btn_deleteOp.TabIndex = 3;
            this.btn_deleteOp.Text = "Delete";
            this.btn_deleteOp.UseVisualStyleBackColor = true;
            // 
            // txt_opId
            // 
            this.txt_opId.Location = new System.Drawing.Point(220, 73);
            this.txt_opId.Name = "txt_opId";
            this.txt_opId.Size = new System.Drawing.Size(300, 29);
            this.txt_opId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operation ID";
            // 
            // frm_operations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 739);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_operations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operations";
            this.Load += new System.EventHandler(this.frm_operations_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_operations)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtg_operations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.TextBox txt_fees;
        private System.Windows.Forms.ComboBox cmb_op;
        private System.Windows.Forms.ComboBox cmb_dis;
        private System.Windows.Forms.ComboBox cmb_patnt;
        private System.Windows.Forms.ComboBox cmb_doc;
        private System.Windows.Forms.DateTimePicker dtime_opDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_deleteOp;
        private System.Windows.Forms.TextBox txt_opId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addOp;
    }
}