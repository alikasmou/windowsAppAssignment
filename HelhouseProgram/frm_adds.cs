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
    public partial class frm_adds : Form
    {
        public frm_adds()
        {
            InitializeComponent();
        }

        private void frm_adds_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");

            SqlDataAdapter DataViewCities;
            DataTable data_table = new DataTable();
            DataViewCities = new SqlDataAdapter("select * from tbl_cities", connect);
            DataViewCities.Fill(data_table);
            dtg_cities.DataSource = data_table;

            SqlDataAdapter DataViewDiseases;
            DataTable data_table2 = new DataTable();
            DataViewDiseases = new SqlDataAdapter("select * from tbl_diseases", connect);
            DataViewDiseases.Fill(data_table2);
            dtg_diseases.DataSource = data_table2;

            SqlDataAdapter DataViewOperations;
            DataTable data_table3 = new DataTable();
            DataViewOperations = new SqlDataAdapter("select * from tbl_operations", connect);
            DataViewOperations.Fill(data_table3);
            dtg_operations.DataSource = data_table3;

            SqlDataAdapter DataViewAnalysis;
            DataTable data_table4 = new DataTable();
            DataViewAnalysis = new SqlDataAdapter("select * from tbl_analysis", connect);
            DataViewAnalysis.Fill(data_table4);
            dtg_analysis.DataSource = data_table4;

            SqlDataAdapter DataViewSpec;
            DataTable data_table5 = new DataTable();
            DataViewSpec = new SqlDataAdapter("select * from tbl_specialization", connect);
            DataViewSpec.Fill(data_table5);
            dtg_specialization.DataSource = data_table5;

        }

        private void tb_city_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_diseases_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_operations_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_analysis_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_addCity_Click(object sender, EventArgs e)
        {
            string city = txt_addCity.Text;
            if (city != "") {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();
                string query = "INSERT INTO tbl_cities(tbl_cities.city_name) VALUES('" + city + "')";
                SqlCommand inserting = new SqlCommand(query, connect);
                inserting.ExecuteNonQuery();
                connect.Close();
                txt_addCity.Text = "";
                MessageBox.Show("City successfully inserted...");
                SqlDataAdapter DataViewCities;
                DataTable data_table = new DataTable();
                DataViewCities = new SqlDataAdapter("select * from tbl_cities", connect);
                DataViewCities.Fill(data_table);
                dtg_cities.DataSource = data_table;
            } else {
                lbl_validation.Text = "* Don not enter an empty value";
            }
            

        }

        private void btn_addDis_Click(object sender, EventArgs e)
        {
            string dis = txt_dis.Text;
            if (dis != "")
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();
                string query = "INSERT INTO tbl_diseases(dis_name) VALUES('" + dis + "')";
                SqlCommand inserting = new SqlCommand(query, connect);
                inserting.ExecuteNonQuery();
                connect.Close();
                txt_dis.Text = "";
                MessageBox.Show("Disease successfully inserted...");
                SqlDataAdapter DataViewDiseases;
                DataTable data_table2 = new DataTable();
                DataViewDiseases = new SqlDataAdapter("select * from tbl_diseases", connect);
                DataViewDiseases.Fill(data_table2);
                dtg_diseases.DataSource = data_table2;
            }
            else
            {
                lbl_validationDis.Text = "* Don not enter an empty value";
            }
        }

        private void btn_addOp_Click(object sender, EventArgs e)
        {
            string op = txt_addOp.Text;
            if (op != "")
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();
                string query = "INSERT INTO tbl_operations(op_name) VALUES('"+op+"')";
                SqlCommand inserting = new SqlCommand(query, connect);
                inserting.ExecuteNonQuery();
                connect.Close();
                txt_addOp.Text = "";
                MessageBox.Show("Operation successfully inserted...");
                SqlDataAdapter DataViewOperations;
                DataTable data_table3 = new DataTable();
                DataViewOperations = new SqlDataAdapter("select * from tbl_operations", connect);
                DataViewOperations.Fill(data_table3);
                dtg_operations.DataSource = data_table3;
            }
            else
            {
                lbl_validationOp.Text = "* Don not enter an empty value";
            }
        }

        private void btn_addAnalysis_Click(object sender, EventArgs e)
        {
            string analysis = txt_analysis.Text;
            if (analysis != "")
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();
                string query = "INSERT INTO tbl_analysis(ana_name) VALUES('" + analysis + "')";
                SqlCommand inserting = new SqlCommand(query, connect);
                inserting.ExecuteNonQuery();
                connect.Close();
                txt_analysis.Text = "";
                MessageBox.Show("Analysis successfully inserted...");
                SqlDataAdapter DataViewAnalysis;
                DataTable data_table4 = new DataTable();
                DataViewAnalysis = new SqlDataAdapter("select * from tbl_analysis", connect);
                DataViewAnalysis.Fill(data_table4);
                dtg_analysis.DataSource = data_table4;
            }
            else
            {
                lbl_validationAnalysis.Text = "* Don not enter an empty value";
            }
        }

        private void btn_specAdd_Click(object sender, EventArgs e)
        {
            string spec = txt_specialization.Text;
            if (spec != "")
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();
                string query = "INSERT INTO tbl_specialization(spec_name) VALUES('" + spec + "')";
                SqlCommand inserting = new SqlCommand(query, connect);
                inserting.ExecuteNonQuery();
                connect.Close();
                txt_specialization.Text = "";
                MessageBox.Show("Specialization successfully inserted...");
                SqlDataAdapter DataViewSpec;
                DataTable data_table5 = new DataTable();
                DataViewSpec = new SqlDataAdapter("select * from tbl_specialization", connect);
                DataViewSpec.Fill(data_table5);
                dtg_specialization.DataSource = data_table5;
            }
            else
            {
                lbl_validationSpec.Text = "* Don not enter an empty value";
            }
        }

        private void btn_citySaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }

        private void btn_disSaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }

        private void btn_opSaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }

        private void btn_analysisSaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }

        private void btn_specSaveChange_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }
    }
}
