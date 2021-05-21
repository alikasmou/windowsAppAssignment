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
    public partial class frm_operations : Form
    {
        public frm_operations()
        {
            InitializeComponent();
        }

        private void frm_operations_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            connect.Open();
            //------------------------------------
            SqlDataAdapter DataViewOP;
            DataTable data_table = new DataTable();
            string Query_op = "SELECT  m2m_doctors_operations.rec_id , m2m_doctors_operations.op_date , (tbl_doctors.doc_name + ' ' + tbl_doctors.doc_surname) AS doc_fullname,(tbl_patients.patnt_name + ' ' + tbl_patients.patnt_surname) AS patnt_fullname, tbl_diseases.dis_name, tbl_operations.op_name, m2m_doctors_operations.cost, m2m_doctors_operations.patnt_payment, m2m_doctors_operations.balance FROM m2m_doctors_operations LEFT JOIN tbl_doctors on tbl_doctors.doc_id = m2m_doctors_operations.doc_id LEFT JOIN tbl_patients on tbl_patients.patnt_id = m2m_doctors_operations.patnt_id LEFT JOIN tbl_diseases on tbl_diseases.dis_id = m2m_doctors_operations.dis_id LEFT JOIN tbl_operations on tbl_operations.op_id = m2m_doctors_operations.op_id ORDER BY m2m_doctors_operations.op_date DESC";
            DataViewOP = new SqlDataAdapter( Query_op , connect);
            DataViewOP.Fill(data_table);
            dtg_operations.DataSource = data_table;
            //-------------------------------------

            //load doctors comboboxes 
            SqlDataAdapter da_doctor;
            DataTable dt_doctor = new DataTable();
            da_doctor = new SqlDataAdapter("SELECT doc_id, (doc_name+' '+doc_surname) AS doc_fname FROM tbl_doctors", connect);
            da_doctor.Fill(dt_doctor);

            cmb_doc.ValueMember = "doc_id";
            cmb_doc.DisplayMember = "doc_fname";
            cmb_doc.DataSource = dt_doctor;

            //load patients comboboxes 
            SqlDataAdapter da_patnt;
            DataTable dt_patnt = new DataTable();
            da_patnt = new SqlDataAdapter("SELECT patnt_id, (patnt_name+' '+patnt_surname) AS patnt_fname FROM tbl_patients", connect);
            da_patnt.Fill(dt_patnt);

            cmb_patnt.ValueMember = "patnt_id";
            cmb_patnt.DisplayMember = "patnt_fname";
            cmb_patnt.DataSource = dt_patnt;

            //load disease comboboxes 
            SqlDataAdapter da_dis;
            DataTable dt_dis = new DataTable();
            da_dis = new SqlDataAdapter("SELECT * FROM tbl_diseases", connect);
            da_dis.Fill(dt_dis);

            cmb_dis.ValueMember = "dis_id";
            cmb_dis.DisplayMember = "dis_name";
            cmb_dis.DataSource = dt_dis;

            //load operationType comboboxes 
            SqlDataAdapter da_OpType;
            DataTable dt_OpType = new DataTable();
            da_OpType = new SqlDataAdapter("SELECT * FROM tbl_operations", connect);
            da_OpType.Fill(dt_OpType);

            cmb_op.ValueMember = "op_id";
            cmb_op.DisplayMember = "op_name";
            cmb_op.DataSource = dt_OpType;

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_addOp_Click(object sender, EventArgs e)
        {
            // combo boxes values
            int op_doc = Convert.ToInt16(cmb_doc.SelectedValue);
            int op_patnt = Convert.ToInt16(cmb_patnt.SelectedValue);
            int op_dis = Convert.ToInt16(cmb_dis.SelectedValue);
            int op_op = Convert.ToInt16(cmb_op.SelectedValue);
            //----------------------------------------------------------------
            Double fees = 0;
            Double payment = 0;
            Double balance = fees - payment;
            if (txt_fees.Text == "" || txt_payment.Text == "" || txt_fees.Text is string || txt_payment.Text is string )
            {
                MessageBox.Show("fees and payment inputs must be numaric");
            }
            else {

                fees = Convert.ToDouble(txt_fees.Text);
                payment = Convert.ToDouble(txt_payment.Text);
            }
             
            
            string op_date = dtime_opDate.Text;

            //MessageBox.Show(doc_genderValue.ToString());
            if (op_doc == 0 ||
                op_patnt == 0 ||
                op_dis == 0 ||
                op_op == 0 ||
                fees == 0 ||
                payment == 0
                
                ){

                MessageBox.Show("Please fill all the information..!");
            }
            else{

                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                string Query = "INSERT INTO m2m_doctors_operations (op_date,doc_id,patnt_id,dis_id,op_id,cost,patnt_payment,balance) VALUES('" + op_date + "','" + op_doc + "','" + op_patnt + "','" + op_dis + "','" + op_op + "','" + fees + "','" + payment + "','"+balance+"')";

                SqlCommand Query_insert = new SqlCommand(Query, connect);
                Query_insert.ExecuteNonQuery();

                
                MessageBox.Show("successfully inserted to the database..");

                //------------------------------------ Refresh the datagrid view
                //------------------------------------
                SqlDataAdapter DataViewOP;
                DataTable data_table = new DataTable();
                string Query_op = "SELECT  m2m_doctors_operations.rec_id , m2m_doctors_operations.op_date , (tbl_doctors.doc_name + ' ' + tbl_doctors.doc_surname) AS doc_fullname,(tbl_patients.patnt_name + ' ' + tbl_patients.patnt_surname) AS patnt_fullname, tbl_diseases.dis_name, tbl_operations.op_name, m2m_doctors_operations.cost, m2m_doctors_operations.patnt_payment, m2m_doctors_operations.balance FROM m2m_doctors_operations LEFT JOIN tbl_doctors on tbl_doctors.doc_id = m2m_doctors_operations.doc_id LEFT JOIN tbl_patients on tbl_patients.patnt_id = m2m_doctors_operations.patnt_id LEFT JOIN tbl_diseases on tbl_diseases.dis_id = m2m_doctors_operations.dis_id LEFT JOIN tbl_operations on tbl_operations.op_id = m2m_doctors_operations.op_id ORDER BY m2m_doctors_operations.op_date DESC";
                DataViewOP = new SqlDataAdapter(Query_op, connect);
                DataViewOP.Fill(data_table);
                dtg_operations.DataSource = data_table;
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
