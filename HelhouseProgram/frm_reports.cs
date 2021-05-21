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
    public partial class frm_reports : Form
    {
        public frm_reports()
        {
            InitializeComponent();
        }

        private void frm_reports_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            connect.Open();
            //-----------------doctors Count
            SqlCommand SelectingCount_doc = new SqlCommand("SELECT COUNT(doc_id) AS dt_count FROM tbl_doctors",connect);
            SqlDataReader fetchValue_doc = SelectingCount_doc.ExecuteReader();
            fetchValue_doc.Read();
            int doc_count = Convert.ToInt16(fetchValue_doc[0].ToString());
            lbl_docCount.Text = doc_count.ToString();
            connect.Close();
            //-----------------Nurses Count
            connect.Open();
            SqlCommand SelectingCount_nurse = new SqlCommand("SELECT COUNT(nurse_id) AS dt_count FROM tbl_nurses", connect);
            SqlDataReader fetchValue_nurse = SelectingCount_nurse.ExecuteReader();
            fetchValue_nurse.Read();
            int dt_count_nurse = Convert.ToInt16(fetchValue_nurse[0].ToString());
            lbl_nurseCount.Text = dt_count_nurse.ToString();
            connect.Close();
            //-----------------Patients Count
            connect.Open();
            SqlCommand SelectingCount_patnt = new SqlCommand("SELECT COUNT(patnt_id) AS dt_count FROM tbl_patients", connect);
            SqlDataReader fetchValue_patnt = SelectingCount_patnt.ExecuteReader();
            fetchValue_patnt.Read();
            int dt_count_patnt = Convert.ToInt16(fetchValue_patnt[0].ToString());
            lbl_patntCount.Text = dt_count_patnt.ToString();
            connect.Close();
            //------------------operations Count
            connect.Open();
            SqlCommand SelectingCount_op = new SqlCommand("SELECT COUNT(op_id) AS dt_count FROM tbl_operations", connect);
            SqlDataReader fetchValue_op = SelectingCount_op.ExecuteReader();
            fetchValue_op.Read();
            int dt_count_op = Convert.ToInt16(fetchValue_op[0].ToString());
            lbl_opCount.Text = dt_count_op.ToString();
            connect.Close();
            //-------------------analaysis count
            connect.Open();
            SqlCommand SelectingCount_ana = new SqlCommand("SELECT COUNT(ana_id) AS dt_count FROM tbl_analysis", connect);
            SqlDataReader fetchValue_ana = SelectingCount_op.ExecuteReader();
            fetchValue_ana.Read();
            int dt_count_ana = Convert.ToInt16(fetchValue_ana[0].ToString());
            lbl_anaCount.Text = dt_count_ana.ToString();
            connect.Close();
            //-----------------analysis income
            connect.Open();
            SqlCommand ana_income = new SqlCommand("SELECT SUM(m2m_nurse_analysis.patnt_payment) AS dt_sum FROM m2m_nurse_analysis", connect);
            SqlDataReader fetchValue_anaInc = ana_income.ExecuteReader();
            fetchValue_anaInc.Read();
            double anaInc = Convert.ToDouble(fetchValue_anaInc[0].ToString());
            btn_incomeAna.Text = anaInc.ToString();
            connect.Close();
            //-------------------operations income
            connect.Open();
            SqlCommand op_income = new SqlCommand("SELECT SUM(m2m_doctors_operations.patnt_payment) AS dt_sum FROM m2m_doctors_operations", connect);
            SqlDataReader fetchValue_opInc = op_income.ExecuteReader();
            fetchValue_opInc.Read();
            double opInc = Convert.ToDouble(fetchValue_opInc[0].ToString());
            btn_incomeOp.Text = opInc.ToString();
            connect.Close();
            //------------------------------------------------------------------------------
            double incomeTotal = opInc + anaInc ;
            btn_incomeTot.Text = incomeTotal.ToString();

        }
    }
}
