using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HelhouseProgram
{
    public partial class frm_analysis : Form
    {
        public frm_analysis()
        {
            InitializeComponent();
        }

        private void frm_analysis_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            connect.Open();
            //------------------------------------
            SqlDataAdapter DataViewAnalysis;
            DataTable data_table = new DataTable();
            string Query_op = "SELECT m2m_nurse_analysis.op_date,(tbl_nurses.nurse_name + ' ' + tbl_nurses.nurse_surname) AS nurse_name, (tbl_patients.patnt_name + ' ' + tbl_patients.patnt_surname) AS patnt_name, tbl_analysis.ana_name, m2m_nurse_analysis.cost, m2m_nurse_analysis.patnt_payment, m2m_nurse_analysis.balance FROM m2m_nurse_analysis LEFT JOIN tbl_nurses on tbl_nurses.nurse_id = m2m_nurse_analysis.nurse_id LEFT JOIN tbl_patients on tbl_patients.patnt_id = m2m_nurse_analysis.patnt_id LEFT JOIN tbl_analysis on tbl_analysis.ana_id = m2m_nurse_analysis.ana_id ORDER BY m2m_nurse_analysis.op_date DESC";
            DataViewAnalysis = new SqlDataAdapter(Query_op, connect);
            DataViewAnalysis.Fill(data_table);
            dtg_analysis.DataSource = data_table;
            //-------------------------------------

            //load doctors comboboxes 
            SqlDataAdapter da_nurse;
            DataTable dt_nurse = new DataTable();
            da_nurse = new SqlDataAdapter("SELECT nurse_id, (nurse_name+' '+nurse_surname) AS nurse_fname FROM tbl_nurses", connect);
            da_nurse.Fill(dt_nurse);

            cmb_Nurse.ValueMember = "nurse_id";
            cmb_Nurse.DisplayMember = "nurse_fname";
            cmb_Nurse.DataSource = dt_nurse;

            //load patients comboboxes 
            SqlDataAdapter da_patnt;
            DataTable dt_patnt = new DataTable();
            da_patnt = new SqlDataAdapter("SELECT patnt_id, (patnt_name+' '+patnt_surname) AS patnt_fname FROM tbl_patients", connect);
            da_patnt.Fill(dt_patnt);

            cmb_patnt.ValueMember = "patnt_id";
            cmb_patnt.DisplayMember = "patnt_fname";
            cmb_patnt.DataSource = dt_patnt;

            //load disease comboboxes 
            SqlDataAdapter da_ana;
            DataTable dt_ana = new DataTable();
            da_ana = new SqlDataAdapter("SELECT * FROM tbl_analysis", connect);
            da_ana.Fill(dt_ana);

            cmb_anaType.ValueMember = "ana_id";
            cmb_anaType.DisplayMember = "ana_name";
            cmb_anaType.DataSource = dt_ana;

            connect.Close();

        }

        private void btn_addAnalysis_Click(object sender, EventArgs e)
        {
            // combo boxes values
            int nurseId = Convert.ToInt16(cmb_Nurse.SelectedValue);
            int patntId = Convert.ToInt16(cmb_patnt.SelectedValue);
            int anaType = Convert.ToInt16(cmb_anaType.SelectedValue);
            //----------------------------------------------------------------
            Double fees = Convert.ToDouble(txt_fees.Text);
            Double payment = Convert.ToDouble(txt_payment.Text);
            Double balance = fees - payment;
            string ana_date = dtime_anaDate.Text;

            //MessageBox.Show(doc_genderValue.ToString());
            if (nurseId == 0 ||
                patntId == 0 ||
                anaType == 0 
                )
            {
                MessageBox.Show("Please fill all the information..!");
            }
            else
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                string Query = "INSERT INTO m2m_nurse_analysis (op_date,nurse_id,patnt_id,ana_id,cost,patnt_payment,balance) VALUES('" + ana_date + "','" + nurseId + "','" + patntId + "','" + anaType + "','" + fees + "','" + payment + "','" + balance + "')";

                SqlCommand Query_insert = new SqlCommand(Query, connect);
                Query_insert.ExecuteNonQuery();


                MessageBox.Show("successfully inserted to the database..");

                //------------------------------------ Refresh the datagrid view
                //------------------------------------
                SqlDataAdapter DataViewAnalysis;
                DataTable data_table = new DataTable();
                string Query_op = "SELECT m2m_nurse_analysis.op_date,(tbl_nurses.nurse_name + ' ' + tbl_nurses.nurse_surname) AS nurse_name, (tbl_patients.patnt_name + ' ' + tbl_patients.patnt_surname) AS patnt_name, tbl_analysis.ana_name, m2m_nurse_analysis.cost, m2m_nurse_analysis.patnt_payment, m2m_nurse_analysis.balance FROM m2m_nurse_analysis LEFT JOIN tbl_nurses on tbl_nurses.nurse_id = m2m_nurse_analysis.nurse_id LEFT JOIN tbl_patients on tbl_patients.patnt_id = m2m_nurse_analysis.patnt_id LEFT JOIN tbl_analysis on tbl_analysis.ana_id = m2m_nurse_analysis.ana_id ORDER BY m2m_nurse_analysis.op_date DESC";
                DataViewAnalysis = new SqlDataAdapter(Query_op, connect);
                DataViewAnalysis.Fill(data_table);
                dtg_analysis.DataSource = data_table;
                //-------------------------------------
                connect.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }
    }
}
