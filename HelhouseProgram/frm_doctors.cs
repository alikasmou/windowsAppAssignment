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
    public partial class frm_doctors : Form
    {
        public frm_doctors()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_addDoctors_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frm_doctors_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            connect.Open();
            //------------------------------------
            SqlDataAdapter DataViewDoctor;
            DataTable data_table = new DataTable();
            DataTable data_table2 = new DataTable();
            DataViewDoctor = new SqlDataAdapter("select * from tbl_doctors", connect);
            DataViewDoctor.Fill(data_table);
            dtg_doctors.DataSource = data_table;
            //-------------------------------------

            //load Gender comboboxes 
            SqlDataAdapter da_Gender;
            DataTable dt_gender = new DataTable();
            da_Gender = new SqlDataAdapter("SELECT * FROM tbl_gender", connect);
            da_Gender.Fill(dt_gender);
            
            cmb_docGender.ValueMember = "gender_id";
            cmb_docGender.DisplayMember = "gender_name";
            cmb_docGender.DataSource = dt_gender;

            //load specialization comboboxes 
            SqlDataAdapter da_spec;
            DataTable dt_spec = new DataTable();
            da_spec = new SqlDataAdapter("SELECT * FROM tbl_specialization", connect);
            da_spec.Fill(dt_spec);

            cmb_docSpecialization.ValueMember = "spec_id";
            cmb_docSpecialization.DisplayMember = "spec_name";
            cmb_docSpecialization.DataSource = dt_spec;

            //load cities comboboxes 
            SqlDataAdapter da_city;
            DataTable dt_city = new DataTable();
            da_city = new SqlDataAdapter("SELECT * FROM tbl_cities", connect);
            da_city.Fill(dt_city);

            cmb_city.ValueMember = "city_id";
            cmb_city.DisplayMember = "city_name";
            cmb_city.DataSource = dt_city;

            //load delete doctor combobox 
            SqlDataAdapter da_doctor;
            DataTable dt_doctor = new DataTable();
            da_doctor = new SqlDataAdapter("SELECT doc_id,(doc_name+' '+doc_surname) AS fullname FROM tbl_doctors", connect);
            da_doctor.Fill(dt_doctor);

            cmb_docId.ValueMember = "doc_id";
            cmb_docId.DisplayMember = "fullname";
            cmb_docId.DataSource = dt_doctor;

            connect.Close();

        }

        private void btn_addDoctor_Click(object sender, EventArgs e)
        {
            // combo boxes values
            int doc_genderValue = Convert.ToInt16(cmb_docGender.SelectedValue);
            int doc_spec = Convert.ToInt16(cmb_docSpecialization.SelectedValue);
            int doc_city = Convert.ToInt16(cmb_city.SelectedValue);
            //----------------------------------------------------------------
            string doc_name = txt_docName.Text;
            string doc_surname = txt_docSurname.Text;
            string doc_birthday = dtime_docBirthday.Text;
            string doc_phone = txt_docPhone.Text;
            //MessageBox.Show(doc_genderValue.ToString());
            if (doc_genderValue == 0 ||
                doc_spec == 0 ||
                doc_city == 0 ||
                doc_name == "" ||
                doc_surname == "" ||
                doc_birthday == "" ||
                doc_phone == ""
                ){
                MessageBox.Show("Please fill all the information..!");
            }
            else {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                string Query = "INSERT INTO tbl_doctors (doc_name,doc_surname,doc_birthday,doc_gender,doc_specialization,doc_phone,doc_city) VALUES('"+doc_name+"','"+doc_surname+"','"+doc_birthday+"','"+doc_genderValue+"','"+doc_spec+"','"+doc_phone+"','"+doc_city+"')";

                SqlCommand Query_insert = new SqlCommand(Query, connect);
                Query_insert.ExecuteNonQuery();

                connect.Close();
                txt_docName.Text = "";
                txt_docSurname.Text = "";
                dtime_docBirthday.Text = "";
                txt_docPhone.Text = "" ;
                MessageBox.Show("successfully inserted to the database..");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewDoctor;
                DataTable data_table = new DataTable();
                DataViewDoctor = new SqlDataAdapter("select * from tbl_doctors", connect);
                DataViewDoctor.Fill(data_table);
                dtg_doctors.DataSource = data_table;


            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int doc_DocIdValue = Convert.ToInt16(cmb_docId.SelectedValue);
            string doc_name = cmb_docId.Text;
            DialogResult dialogResult = MessageBox.Show( doc_name + " Will be deleted , Are you sure ? ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
                connect.Open();

                SqlCommand query_delete = new SqlCommand("DELETE FROM tbl_doctors WHERE doc_id='" + doc_DocIdValue + "'", connect);
                query_delete.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show( doc_name + " successfully deleted...");

                //------------------------------------ Refresh the datagrid view
                SqlDataAdapter DataViewDoctor;
                DataTable data_table = new DataTable();
                DataViewDoctor = new SqlDataAdapter("select * from tbl_doctors", connect);
                DataViewDoctor.Fill(data_table);
                dtg_doctors.DataSource = data_table;
                connect.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("cancelled...");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
            connect.Open();
            //------------------------------------
            SqlDataAdapter da;
            DataTable dg = new DataTable();
            da = new SqlDataAdapter("select * from tbl_doctors", connect);
            da.Fill(dg);
            dtg_doctors.DataSource = dg;
            //-------------------------------------
            SqlCommandBuilder SaveChanges = new SqlCommandBuilder(da);
            da.Update(dg);
            MessageBox.Show("The table successfully updated");

        }
    }
}
