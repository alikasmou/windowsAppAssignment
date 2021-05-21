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
    public partial class frm_nurses : Form
    {
        public frm_nurses()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frm_nurses_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            SqlDataAdapter DataViewNurse;
            DataTable data_table = new DataTable();
            DataViewNurse = new SqlDataAdapter("select * from tbl_nurses", connect);
            DataViewNurse.Fill(data_table);
            dtgrid_nurses.DataSource = data_table;
            //------------------------------------------------------------------------
            //load Gender comboboxes 
            SqlDataAdapter da_Gender;
            DataTable dt_gender = new DataTable();
            da_Gender = new SqlDataAdapter("SELECT * FROM tbl_gender", connect);
            da_Gender.Fill(dt_gender);

            cmb_nurseGender.ValueMember = "gender_id";
            cmb_nurseGender.DisplayMember = "gender_name";
            cmb_nurseGender.DataSource = dt_gender;

            //load cities comboboxes 
            SqlDataAdapter da_city;
            DataTable dt_city = new DataTable();
            da_city = new SqlDataAdapter("SELECT * FROM tbl_cities", connect);
            da_city.Fill(dt_city);

            cmb_NurseCity.ValueMember = "city_id";
            cmb_NurseCity.DisplayMember = "city_name";
            cmb_NurseCity.DataSource = dt_city;

            //load delete patient combobox 
            SqlDataAdapter da_nurse;
            DataTable dt_nurse = new DataTable();
            da_nurse = new SqlDataAdapter("SELECT nurse_id,(nurse_name+' '+nurse_surname) AS fullname FROM tbl_nurses", connect);
            da_nurse.Fill(dt_nurse);

            cmb_nurseDelete.ValueMember = "nurse_id";
            cmb_nurseDelete.DisplayMember = "fullname";
            cmb_nurseDelete.DataSource = dt_nurse;

            connect.Close();


        }

        private void btn_addNurse_Click(object sender, EventArgs e)
        {
            // combo boxes values
            int nurse_genderValue = Convert.ToInt16(cmb_nurseGender.SelectedValue);
            int nurse_city = Convert.ToInt16(cmb_NurseCity.SelectedValue);
            //----------------------------------------------------------------
            string nurse_name = txt_NurseName.Text;
            string nurse_surname = txt_nurseSurname.Text;
            string nurse_birthday = dtime_nurseBirthday.Text;
            string nurse_phone = txt_NursePhone.Text;
            //MessageBox.Show(doc_genderValue.ToString());
            if (nurse_genderValue == 0 ||
                nurse_city == 0 ||
                nurse_name == "" ||
                nurse_surname == "" ||
                nurse_birthday == "" ||
                nurse_phone == ""
                )
            {
                MessageBox.Show("Please fill all the information..!");
            }
            else
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                string Query = "INSERT INTO tbl_nurses (nurse_name,nurse_surname,nurse_birthday,nurse_gender,nurse_phone,nurse_city) VALUES('" + nurse_name + "','" + nurse_surname + "','" + nurse_birthday + "','" + nurse_genderValue + "','" + nurse_phone + "','" + nurse_city + "')";

                SqlCommand Query_insert = new SqlCommand(Query, connect);
                Query_insert.ExecuteNonQuery();

                txt_NurseName.Text = "";
                txt_nurseSurname.Text = "";
                dtime_nurseBirthday.Text = "";
                txt_NursePhone.Text = "";
                MessageBox.Show("successfully inserted to the database..");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewNurse;
                DataTable data_table = new DataTable();
                DataViewNurse = new SqlDataAdapter("select * from tbl_nurses", connect);
                DataViewNurse.Fill(data_table);
                dtgrid_nurses.DataSource = data_table;
                connect.Close();


            }
        }

        private void btn_deleteNurse_Click(object sender, EventArgs e)
        {
            int nurse_DocIdValue = Convert.ToInt16(cmb_nurseDelete.SelectedValue.ToString());
            string nurse_name = cmb_nurseDelete.Text;
            DialogResult dialogResult = MessageBox.Show(nurse_name + " Will be deleted , Are you sure ? ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                SqlCommand query_delete = new SqlCommand("DELETE FROM tbl_nurses WHERE nurse_id='" + nurse_DocIdValue + "'", connect);
                query_delete.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show(nurse_name + " successfully deleted...");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewNurse;
                DataTable data_table = new DataTable();
                DataViewNurse = new SqlDataAdapter("select * from tbl_nurses", connect);
                DataViewNurse.Fill(data_table);
                dtgrid_nurses.DataSource = data_table;
                connect.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("cancelled...");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The table successfully updated");
        }
    }
}
