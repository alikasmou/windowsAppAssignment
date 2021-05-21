namespace HelhouseProgram
{
    partial class frm_adds
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
            this.tabControl_adds = new System.Windows.Forms.TabControl();
            this.tb_city = new System.Windows.Forms.TabPage();
            this.btn_citySaveChange = new System.Windows.Forms.Button();
            this.dtg_cities = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_validation = new System.Windows.Forms.Label();
            this.lbl_addCity = new System.Windows.Forms.Label();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.txt_addCity = new System.Windows.Forms.TextBox();
            this.tb_diseases = new System.Windows.Forms.TabPage();
            this.btn_disSaveChange = new System.Windows.Forms.Button();
            this.dtg_diseases = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_validationDis = new System.Windows.Forms.Label();
            this.lbl_addDis = new System.Windows.Forms.Label();
            this.txt_dis = new System.Windows.Forms.TextBox();
            this.btn_addDis = new System.Windows.Forms.Button();
            this.tb_operations = new System.Windows.Forms.TabPage();
            this.dtg_operations = new System.Windows.Forms.DataGridView();
            this.btn_opSaveChange = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_validationOp = new System.Windows.Forms.Label();
            this.lbl_addOp = new System.Windows.Forms.Label();
            this.btn_addOp = new System.Windows.Forms.Button();
            this.txt_addOp = new System.Windows.Forms.TextBox();
            this.tb_analysis = new System.Windows.Forms.TabPage();
            this.btn_analysisSaveChange = new System.Windows.Forms.Button();
            this.dtg_analysis = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_validationAnalysis = new System.Windows.Forms.Label();
            this.lbl_analysis = new System.Windows.Forms.Label();
            this.btn_addAnalysis = new System.Windows.Forms.Button();
            this.txt_analysis = new System.Windows.Forms.TextBox();
            this.tb_specialization = new System.Windows.Forms.TabPage();
            this.btn_specSaveChange = new System.Windows.Forms.Button();
            this.dtg_specialization = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_validationSpec = new System.Windows.Forms.Label();
            this.txt_specialization = new System.Windows.Forms.TextBox();
            this.lbl_specialization = new System.Windows.Forms.Label();
            this.btn_specAdd = new System.Windows.Forms.Button();
            this.tabControl_adds.SuspendLayout();
            this.tb_city.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cities)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tb_diseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_diseases)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tb_operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_operations)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tb_analysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analysis)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tb_specialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_specialization)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_adds
            // 
            this.tabControl_adds.Controls.Add(this.tb_city);
            this.tabControl_adds.Controls.Add(this.tb_diseases);
            this.tabControl_adds.Controls.Add(this.tb_operations);
            this.tabControl_adds.Controls.Add(this.tb_analysis);
            this.tabControl_adds.Controls.Add(this.tb_specialization);
            this.tabControl_adds.Location = new System.Drawing.Point(12, 12);
            this.tabControl_adds.Name = "tabControl_adds";
            this.tabControl_adds.SelectedIndex = 0;
            this.tabControl_adds.Size = new System.Drawing.Size(1195, 728);
            this.tabControl_adds.TabIndex = 0;
            // 
            // tb_city
            // 
            this.tb_city.Controls.Add(this.btn_citySaveChange);
            this.tb_city.Controls.Add(this.dtg_cities);
            this.tb_city.Controls.Add(this.groupBox1);
            this.tb_city.Location = new System.Drawing.Point(4, 31);
            this.tb_city.Name = "tb_city";
            this.tb_city.Padding = new System.Windows.Forms.Padding(3);
            this.tb_city.Size = new System.Drawing.Size(1187, 693);
            this.tb_city.TabIndex = 0;
            this.tb_city.Text = "+City";
            this.tb_city.UseVisualStyleBackColor = true;
            this.tb_city.Click += new System.EventHandler(this.tb_city_Click);
            // 
            // btn_citySaveChange
            // 
            this.btn_citySaveChange.Location = new System.Drawing.Point(1028, 271);
            this.btn_citySaveChange.Name = "btn_citySaveChange";
            this.btn_citySaveChange.Size = new System.Drawing.Size(120, 30);
            this.btn_citySaveChange.TabIndex = 5;
            this.btn_citySaveChange.Text = "Save Changes";
            this.btn_citySaveChange.UseVisualStyleBackColor = true;
            this.btn_citySaveChange.Click += new System.EventHandler(this.btn_citySaveChange_Click);
            // 
            // dtg_cities
            // 
            this.dtg_cities.AllowUserToAddRows = false;
            this.dtg_cities.AllowUserToDeleteRows = false;
            this.dtg_cities.AllowUserToResizeColumns = false;
            this.dtg_cities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_cities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_cities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cities.Location = new System.Drawing.Point(428, 15);
            this.dtg_cities.Name = "dtg_cities";
            this.dtg_cities.ReadOnly = true;
            this.dtg_cities.RowTemplate.Height = 28;
            this.dtg_cities.Size = new System.Drawing.Size(720, 250);
            this.dtg_cities.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_validation);
            this.groupBox1.Controls.Add(this.lbl_addCity);
            this.groupBox1.Controls.Add(this.btn_addCity);
            this.groupBox1.Controls.Add(this.txt_addCity);
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Form";
            // 
            // lbl_validation
            // 
            this.lbl_validation.AutoSize = true;
            this.lbl_validation.ForeColor = System.Drawing.Color.Red;
            this.lbl_validation.Location = new System.Drawing.Point(91, 153);
            this.lbl_validation.Name = "lbl_validation";
            this.lbl_validation.Size = new System.Drawing.Size(19, 22);
            this.lbl_validation.TabIndex = 6;
            this.lbl_validation.Text = "*";
            // 
            // lbl_addCity
            // 
            this.lbl_addCity.AutoSize = true;
            this.lbl_addCity.Location = new System.Drawing.Point(6, 88);
            this.lbl_addCity.Name = "lbl_addCity";
            this.lbl_addCity.Size = new System.Drawing.Size(83, 22);
            this.lbl_addCity.TabIndex = 0;
            this.lbl_addCity.Text = "City Name";
            // 
            // btn_addCity
            // 
            this.btn_addCity.Location = new System.Drawing.Point(275, 116);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Size = new System.Drawing.Size(120, 30);
            this.btn_addCity.TabIndex = 2;
            this.btn_addCity.Text = "add";
            this.btn_addCity.UseVisualStyleBackColor = true;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // txt_addCity
            // 
            this.txt_addCity.Location = new System.Drawing.Point(95, 81);
            this.txt_addCity.Name = "txt_addCity";
            this.txt_addCity.Size = new System.Drawing.Size(300, 29);
            this.txt_addCity.TabIndex = 1;
            // 
            // tb_diseases
            // 
            this.tb_diseases.Controls.Add(this.btn_disSaveChange);
            this.tb_diseases.Controls.Add(this.dtg_diseases);
            this.tb_diseases.Controls.Add(this.groupBox2);
            this.tb_diseases.Location = new System.Drawing.Point(4, 31);
            this.tb_diseases.Name = "tb_diseases";
            this.tb_diseases.Padding = new System.Windows.Forms.Padding(3);
            this.tb_diseases.Size = new System.Drawing.Size(1187, 693);
            this.tb_diseases.TabIndex = 1;
            this.tb_diseases.Text = "+Diseases";
            this.tb_diseases.UseVisualStyleBackColor = true;
            this.tb_diseases.Click += new System.EventHandler(this.tb_diseases_Click);
            // 
            // btn_disSaveChange
            // 
            this.btn_disSaveChange.Location = new System.Drawing.Point(1012, 286);
            this.btn_disSaveChange.Name = "btn_disSaveChange";
            this.btn_disSaveChange.Size = new System.Drawing.Size(120, 30);
            this.btn_disSaveChange.TabIndex = 5;
            this.btn_disSaveChange.Text = "Save Changes";
            this.btn_disSaveChange.UseVisualStyleBackColor = true;
            this.btn_disSaveChange.Click += new System.EventHandler(this.btn_disSaveChange_Click);
            // 
            // dtg_diseases
            // 
            this.dtg_diseases.AllowUserToAddRows = false;
            this.dtg_diseases.AllowUserToDeleteRows = false;
            this.dtg_diseases.AllowUserToResizeColumns = false;
            this.dtg_diseases.AllowUserToResizeRows = false;
            this.dtg_diseases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_diseases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_diseases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_diseases.Location = new System.Drawing.Point(412, 30);
            this.dtg_diseases.Name = "dtg_diseases";
            this.dtg_diseases.ReadOnly = true;
            this.dtg_diseases.RowTemplate.Height = 28;
            this.dtg_diseases.Size = new System.Drawing.Size(720, 250);
            this.dtg_diseases.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_validationDis);
            this.groupBox2.Controls.Add(this.lbl_addDis);
            this.groupBox2.Controls.Add(this.txt_dis);
            this.groupBox2.Controls.Add(this.btn_addDis);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Form";
            // 
            // lbl_validationDis
            // 
            this.lbl_validationDis.AutoSize = true;
            this.lbl_validationDis.ForeColor = System.Drawing.Color.Red;
            this.lbl_validationDis.Location = new System.Drawing.Point(90, 155);
            this.lbl_validationDis.Name = "lbl_validationDis";
            this.lbl_validationDis.Size = new System.Drawing.Size(19, 22);
            this.lbl_validationDis.TabIndex = 7;
            this.lbl_validationDis.Text = "*";
            // 
            // lbl_addDis
            // 
            this.lbl_addDis.AutoSize = true;
            this.lbl_addDis.Location = new System.Drawing.Point(16, 82);
            this.lbl_addDis.Name = "lbl_addDis";
            this.lbl_addDis.Size = new System.Drawing.Size(72, 22);
            this.lbl_addDis.TabIndex = 1;
            this.lbl_addDis.Text = "Diseases";
            // 
            // txt_dis
            // 
            this.txt_dis.Location = new System.Drawing.Point(94, 75);
            this.txt_dis.Name = "txt_dis";
            this.txt_dis.Size = new System.Drawing.Size(300, 29);
            this.txt_dis.TabIndex = 2;
            // 
            // btn_addDis
            // 
            this.btn_addDis.Location = new System.Drawing.Point(274, 110);
            this.btn_addDis.Name = "btn_addDis";
            this.btn_addDis.Size = new System.Drawing.Size(120, 30);
            this.btn_addDis.TabIndex = 0;
            this.btn_addDis.Text = "add";
            this.btn_addDis.UseVisualStyleBackColor = true;
            this.btn_addDis.Click += new System.EventHandler(this.btn_addDis_Click);
            // 
            // tb_operations
            // 
            this.tb_operations.Controls.Add(this.dtg_operations);
            this.tb_operations.Controls.Add(this.btn_opSaveChange);
            this.tb_operations.Controls.Add(this.groupBox3);
            this.tb_operations.Location = new System.Drawing.Point(4, 31);
            this.tb_operations.Name = "tb_operations";
            this.tb_operations.Padding = new System.Windows.Forms.Padding(3);
            this.tb_operations.Size = new System.Drawing.Size(1187, 693);
            this.tb_operations.TabIndex = 2;
            this.tb_operations.Text = "+Operations";
            this.tb_operations.UseVisualStyleBackColor = true;
            this.tb_operations.Click += new System.EventHandler(this.tb_operations_Click);
            // 
            // dtg_operations
            // 
            this.dtg_operations.AllowUserToAddRows = false;
            this.dtg_operations.AllowUserToDeleteRows = false;
            this.dtg_operations.AllowUserToResizeColumns = false;
            this.dtg_operations.AllowUserToResizeRows = false;
            this.dtg_operations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_operations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_operations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_operations.Location = new System.Drawing.Point(412, 30);
            this.dtg_operations.Name = "dtg_operations";
            this.dtg_operations.ReadOnly = true;
            this.dtg_operations.RowTemplate.Height = 28;
            this.dtg_operations.Size = new System.Drawing.Size(720, 250);
            this.dtg_operations.TabIndex = 5;
            // 
            // btn_opSaveChange
            // 
            this.btn_opSaveChange.Location = new System.Drawing.Point(1012, 286);
            this.btn_opSaveChange.Name = "btn_opSaveChange";
            this.btn_opSaveChange.Size = new System.Drawing.Size(120, 30);
            this.btn_opSaveChange.TabIndex = 4;
            this.btn_opSaveChange.Text = "Save Changes";
            this.btn_opSaveChange.UseVisualStyleBackColor = true;
            this.btn_opSaveChange.Click += new System.EventHandler(this.btn_opSaveChange_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_validationOp);
            this.groupBox3.Controls.Add(this.lbl_addOp);
            this.groupBox3.Controls.Add(this.btn_addOp);
            this.groupBox3.Controls.Add(this.txt_addOp);
            this.groupBox3.Location = new System.Drawing.Point(6, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 250);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Form";
            // 
            // lbl_validationOp
            // 
            this.lbl_validationOp.AutoSize = true;
            this.lbl_validationOp.ForeColor = System.Drawing.Color.Red;
            this.lbl_validationOp.Location = new System.Drawing.Point(90, 144);
            this.lbl_validationOp.Name = "lbl_validationOp";
            this.lbl_validationOp.Size = new System.Drawing.Size(19, 22);
            this.lbl_validationOp.TabIndex = 6;
            this.lbl_validationOp.Text = "*";
            // 
            // lbl_addOp
            // 
            this.lbl_addOp.AutoSize = true;
            this.lbl_addOp.Location = new System.Drawing.Point(6, 77);
            this.lbl_addOp.Name = "lbl_addOp";
            this.lbl_addOp.Size = new System.Drawing.Size(82, 22);
            this.lbl_addOp.TabIndex = 1;
            this.lbl_addOp.Text = "Operation";
            // 
            // btn_addOp
            // 
            this.btn_addOp.Location = new System.Drawing.Point(274, 105);
            this.btn_addOp.Name = "btn_addOp";
            this.btn_addOp.Size = new System.Drawing.Size(120, 30);
            this.btn_addOp.TabIndex = 2;
            this.btn_addOp.Text = "add";
            this.btn_addOp.UseVisualStyleBackColor = true;
            this.btn_addOp.Click += new System.EventHandler(this.btn_addOp_Click);
            // 
            // txt_addOp
            // 
            this.txt_addOp.Location = new System.Drawing.Point(94, 70);
            this.txt_addOp.Name = "txt_addOp";
            this.txt_addOp.Size = new System.Drawing.Size(300, 29);
            this.txt_addOp.TabIndex = 0;
            // 
            // tb_analysis
            // 
            this.tb_analysis.Controls.Add(this.btn_analysisSaveChange);
            this.tb_analysis.Controls.Add(this.dtg_analysis);
            this.tb_analysis.Controls.Add(this.groupBox4);
            this.tb_analysis.Location = new System.Drawing.Point(4, 31);
            this.tb_analysis.Name = "tb_analysis";
            this.tb_analysis.Padding = new System.Windows.Forms.Padding(3);
            this.tb_analysis.Size = new System.Drawing.Size(1187, 693);
            this.tb_analysis.TabIndex = 3;
            this.tb_analysis.Text = "+Analysis";
            this.tb_analysis.UseVisualStyleBackColor = true;
            this.tb_analysis.Click += new System.EventHandler(this.tb_analysis_Click);
            // 
            // btn_analysisSaveChange
            // 
            this.btn_analysisSaveChange.Location = new System.Drawing.Point(1012, 286);
            this.btn_analysisSaveChange.Name = "btn_analysisSaveChange";
            this.btn_analysisSaveChange.Size = new System.Drawing.Size(120, 30);
            this.btn_analysisSaveChange.TabIndex = 5;
            this.btn_analysisSaveChange.Text = "Save Changes";
            this.btn_analysisSaveChange.UseVisualStyleBackColor = true;
            this.btn_analysisSaveChange.Click += new System.EventHandler(this.btn_analysisSaveChange_Click);
            // 
            // dtg_analysis
            // 
            this.dtg_analysis.AllowUserToAddRows = false;
            this.dtg_analysis.AllowUserToDeleteRows = false;
            this.dtg_analysis.AllowUserToResizeColumns = false;
            this.dtg_analysis.AllowUserToResizeRows = false;
            this.dtg_analysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_analysis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_analysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_analysis.Location = new System.Drawing.Point(412, 30);
            this.dtg_analysis.Name = "dtg_analysis";
            this.dtg_analysis.ReadOnly = true;
            this.dtg_analysis.RowTemplate.Height = 28;
            this.dtg_analysis.Size = new System.Drawing.Size(720, 250);
            this.dtg_analysis.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_validationAnalysis);
            this.groupBox4.Controls.Add(this.lbl_analysis);
            this.groupBox4.Controls.Add(this.btn_addAnalysis);
            this.groupBox4.Controls.Add(this.txt_analysis);
            this.groupBox4.Location = new System.Drawing.Point(6, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 250);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Form";
            // 
            // lbl_validationAnalysis
            // 
            this.lbl_validationAnalysis.AutoSize = true;
            this.lbl_validationAnalysis.ForeColor = System.Drawing.Color.Red;
            this.lbl_validationAnalysis.Location = new System.Drawing.Point(76, 140);
            this.lbl_validationAnalysis.Name = "lbl_validationAnalysis";
            this.lbl_validationAnalysis.Size = new System.Drawing.Size(19, 22);
            this.lbl_validationAnalysis.TabIndex = 6;
            this.lbl_validationAnalysis.Text = "*";
            // 
            // lbl_analysis
            // 
            this.lbl_analysis.AutoSize = true;
            this.lbl_analysis.Location = new System.Drawing.Point(6, 69);
            this.lbl_analysis.Name = "lbl_analysis";
            this.lbl_analysis.Size = new System.Drawing.Size(66, 22);
            this.lbl_analysis.TabIndex = 1;
            this.lbl_analysis.Text = "Analysis";
            // 
            // btn_addAnalysis
            // 
            this.btn_addAnalysis.Location = new System.Drawing.Point(260, 97);
            this.btn_addAnalysis.Name = "btn_addAnalysis";
            this.btn_addAnalysis.Size = new System.Drawing.Size(120, 30);
            this.btn_addAnalysis.TabIndex = 2;
            this.btn_addAnalysis.Text = "add";
            this.btn_addAnalysis.UseVisualStyleBackColor = true;
            this.btn_addAnalysis.Click += new System.EventHandler(this.btn_addAnalysis_Click);
            // 
            // txt_analysis
            // 
            this.txt_analysis.Location = new System.Drawing.Point(80, 62);
            this.txt_analysis.Name = "txt_analysis";
            this.txt_analysis.Size = new System.Drawing.Size(300, 29);
            this.txt_analysis.TabIndex = 0;
            // 
            // tb_specialization
            // 
            this.tb_specialization.Controls.Add(this.btn_specSaveChange);
            this.tb_specialization.Controls.Add(this.dtg_specialization);
            this.tb_specialization.Controls.Add(this.groupBox5);
            this.tb_specialization.Location = new System.Drawing.Point(4, 31);
            this.tb_specialization.Name = "tb_specialization";
            this.tb_specialization.Padding = new System.Windows.Forms.Padding(3);
            this.tb_specialization.Size = new System.Drawing.Size(1187, 693);
            this.tb_specialization.TabIndex = 4;
            this.tb_specialization.Text = "+Specialization";
            this.tb_specialization.UseVisualStyleBackColor = true;
            // 
            // btn_specSaveChange
            // 
            this.btn_specSaveChange.Location = new System.Drawing.Point(1030, 297);
            this.btn_specSaveChange.Name = "btn_specSaveChange";
            this.btn_specSaveChange.Size = new System.Drawing.Size(120, 30);
            this.btn_specSaveChange.TabIndex = 2;
            this.btn_specSaveChange.Text = "Save Changes";
            this.btn_specSaveChange.UseVisualStyleBackColor = true;
            this.btn_specSaveChange.Click += new System.EventHandler(this.btn_specSaveChange_Click);
            // 
            // dtg_specialization
            // 
            this.dtg_specialization.AllowUserToAddRows = false;
            this.dtg_specialization.AllowUserToDeleteRows = false;
            this.dtg_specialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_specialization.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_specialization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_specialization.Location = new System.Drawing.Point(472, 41);
            this.dtg_specialization.Name = "dtg_specialization";
            this.dtg_specialization.ReadOnly = true;
            this.dtg_specialization.RowTemplate.Height = 28;
            this.dtg_specialization.Size = new System.Drawing.Size(678, 250);
            this.dtg_specialization.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_validationSpec);
            this.groupBox5.Controls.Add(this.txt_specialization);
            this.groupBox5.Controls.Add(this.lbl_specialization);
            this.groupBox5.Controls.Add(this.btn_specAdd);
            this.groupBox5.Location = new System.Drawing.Point(16, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(450, 250);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add form";
            // 
            // lbl_validationSpec
            // 
            this.lbl_validationSpec.AutoSize = true;
            this.lbl_validationSpec.ForeColor = System.Drawing.Color.Red;
            this.lbl_validationSpec.Location = new System.Drawing.Point(114, 142);
            this.lbl_validationSpec.Name = "lbl_validationSpec";
            this.lbl_validationSpec.Size = new System.Drawing.Size(19, 22);
            this.lbl_validationSpec.TabIndex = 3;
            this.lbl_validationSpec.Text = "*";
            // 
            // txt_specialization
            // 
            this.txt_specialization.Location = new System.Drawing.Point(118, 72);
            this.txt_specialization.Name = "txt_specialization";
            this.txt_specialization.Size = new System.Drawing.Size(300, 29);
            this.txt_specialization.TabIndex = 3;
            // 
            // lbl_specialization
            // 
            this.lbl_specialization.AutoSize = true;
            this.lbl_specialization.Location = new System.Drawing.Point(6, 79);
            this.lbl_specialization.Name = "lbl_specialization";
            this.lbl_specialization.Size = new System.Drawing.Size(106, 22);
            this.lbl_specialization.TabIndex = 1;
            this.lbl_specialization.Text = "specialization";
            // 
            // btn_specAdd
            // 
            this.btn_specAdd.Location = new System.Drawing.Point(298, 107);
            this.btn_specAdd.Name = "btn_specAdd";
            this.btn_specAdd.Size = new System.Drawing.Size(120, 30);
            this.btn_specAdd.TabIndex = 0;
            this.btn_specAdd.Text = "add";
            this.btn_specAdd.UseVisualStyleBackColor = true;
            this.btn_specAdd.Click += new System.EventHandler(this.btn_specAdd_Click);
            // 
            // frm_adds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 672);
            this.Controls.Add(this.tabControl_adds);
            this.Font = new System.Drawing.Font("Open Sans Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_adds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add information";
            this.Load += new System.EventHandler(this.frm_adds_Load);
            this.tabControl_adds.ResumeLayout(false);
            this.tb_city.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cities)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tb_diseases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_diseases)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tb_operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_operations)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tb_analysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_analysis)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tb_specialization.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_specialization)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_adds;
        private System.Windows.Forms.TabPage tb_city;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.TextBox txt_addCity;
        private System.Windows.Forms.Label lbl_addCity;
        private System.Windows.Forms.TabPage tb_diseases;
        private System.Windows.Forms.TextBox txt_dis;
        private System.Windows.Forms.Label lbl_addDis;
        private System.Windows.Forms.Button btn_addDis;
        private System.Windows.Forms.TabPage tb_operations;
        private System.Windows.Forms.Button btn_addOp;
        private System.Windows.Forms.Label lbl_addOp;
        private System.Windows.Forms.TextBox txt_addOp;
        private System.Windows.Forms.TabPage tb_analysis;
        private System.Windows.Forms.Button btn_addAnalysis;
        private System.Windows.Forms.Label lbl_analysis;
        private System.Windows.Forms.TextBox txt_analysis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtg_cities;
        private System.Windows.Forms.Button btn_citySaveChange;
        private System.Windows.Forms.Button btn_disSaveChange;
        private System.Windows.Forms.DataGridView dtg_diseases;
        private System.Windows.Forms.DataGridView dtg_operations;
        private System.Windows.Forms.Button btn_opSaveChange;
        private System.Windows.Forms.Button btn_analysisSaveChange;
        private System.Windows.Forms.DataGridView dtg_analysis;
        private System.Windows.Forms.TabPage tb_specialization;
        private System.Windows.Forms.Button btn_specSaveChange;
        private System.Windows.Forms.DataGridView dtg_specialization;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_specialization;
        private System.Windows.Forms.Label lbl_specialization;
        private System.Windows.Forms.Button btn_specAdd;
        private System.Windows.Forms.Label lbl_validation;
        private System.Windows.Forms.Label lbl_validationDis;
        private System.Windows.Forms.Label lbl_validationOp;
        private System.Windows.Forms.Label lbl_validationAnalysis;
        private System.Windows.Forms.Label lbl_validationSpec;
    }
}