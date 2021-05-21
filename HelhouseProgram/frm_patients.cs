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
    public partial class frm_patients : Form
    {
        public frm_patients()
        {
            InitializeComponent();
        }

        private void frm_patients_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            SqlDataAdapter DataViewPatient;
            DataTable data_table = new DataTable();
            DataViewPatient = new SqlDataAdapter("select * from tbl_patients", connect);
            DataViewPatient.Fill(data_table);
            dtGrid_patnt.DataSource = data_table;
            //----------------------------------------------------------------------------

            //load Gender comboboxes 
            SqlDataAdapter da_Gender;
            DataTable dt_gender = new DataTable();
            da_Gender = new SqlDataAdapter("SELECT * FROM tbl_gender", connect);
            da_Gender.Fill(dt_gender);

            cmb_patntGender.ValueMember = "gender_id";
            cmb_patntGender.DisplayMember = "gender_name";
            cmb_patntGender.DataSource = dt_gender;

            //load cities comboboxes 
            SqlDataAdapter da_city;
            DataTable dt_city = new DataTable();
            da_city = new SqlDataAdapter("SELECT * FROM tbl_cities", connect);
            da_city.Fill(dt_city);

            cmb_patntCity.ValueMember = "city_id";
            cmb_patntCity.DisplayMember = "city_name";
            cmb_patntCity.DataSource = dt_city;

            //load delete patient combobox 
            SqlDataAdapter da_patnt;
            DataTable dt_patnt = new DataTable();
            da_patnt = new SqlDataAdapter("SELECT patnt_id,(patnt_name+' '+patnt_surname) AS fullname FROM tbl_patients", connect);
            da_patnt.Fill(dt_patnt);

            cmb_patntIddelete.ValueMember = "patnt_id";
            cmb_patntIddelete.DisplayMember = "fullname";
            cmb_patntIddelete.DataSource = dt_patnt;

            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // combo boxes values
            int patnt_genderValue = Convert.ToInt16(cmb_patntGender.SelectedValue);
            int patnt_city = Convert.ToInt16(cmb_patntCity.SelectedValue);
            //----------------------------------------------------------------
            string patnt_name = txt_patntName.Text;
            string patnt_surname = txt_patntSurname.Text;
            string patnt_birthday = dtime_ptntBirthday.Text;
            string patnt_phone = txt_patntPhone.Text;
            //MessageBox.Show(doc_genderValue.ToString());
            if (patnt_genderValue == 0 ||
                patnt_city == 0 ||
                patnt_name == "" ||
                patnt_surname == "" ||
                patnt_birthday == "" ||
                patnt_phone == ""
                )
            {
                MessageBox.Show("Please fill all the information..!");
            }
            else
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                string Query = "INSERT INTO tbl_patients (patnt_name,patnt_surname,patnt_birthday,patnt_gender,patnt_phone,patnt_city) VALUES('" + patnt_name + "','" + patnt_surname + "','" + patnt_birthday + "','" + patnt_genderValue + "','" + patnt_phone + "','" + patnt_city + "')";

                SqlCommand Query_insert = new SqlCommand(Query, connect);
                Query_insert.ExecuteNonQuery();

                txt_patntName.Text = "";
                txt_patntSurname.Text = "";
                dtime_ptntBirthday.Text = "";
                txt_patntPhone.Text = "";
                MessageBox.Show("successfully inserted to the database..");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewPatient;
                DataTable data_table = new DataTable();
                DataViewPatient = new SqlDataAdapter("select * from tbl_patients", connect);
                DataViewPatient.Fill(data_table);
                dtGrid_patnt.DataSource = data_table;
                connect.Close();


            }
        }

        private void btn_patntDelete_Click(object sender, EventArgs e)
        {
            int patnt_DocIdValue = Convert.ToInt16(cmb_patntIddelete.SelectedValue.ToString());
            string patnt_name = cmb_patntIddelete.Text;
            DialogResult dialogResult = MessageBox.Show(patnt_name + " Will be deleted , Are you sure ? ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                SqlCommand query_delete = new SqlCommand("DELETE FROM tbl_patients WHERE patnt_id='" + patnt_DocIdValue + "'", connect);
                query_delete.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show(patnt_name + " successfully deleted...");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewPatient;
                DataTable data_table = new DataTable();
                DataViewPatient = new SqlDataAdapter("select * from tbl_patients", connect);
                DataViewPatient.Fill(data_table);
                dtGrid_patnt.DataSource = data_table;
                connect.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("cancelled...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }
    }
}
