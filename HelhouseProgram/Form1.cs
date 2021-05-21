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
    public partial class frm_cpanel : Form
    {
        public frm_cpanel()
        {
            InitializeComponent();
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");
        }

        private void frm_cpanel_Load(object sender, EventArgs e)
        {

        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            frm_doctors OpenDoc = new frm_doctors();
            OpenDoc.Show();
            // Connet to the database
            SqlConnection connect = new SqlConnection(@"Data Source=.; Initial Catalog= helhouse; Integrated Security= True");

        }

        private void btn_nurses_Click(object sender, EventArgs e)
        {
            frm_nurses OpenNurs = new frm_nurses();
            OpenNurs.Show();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            frm_patients OpenPatient = new frm_patients();
            OpenPatient.Show();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_reports OpenReports = new frm_reports();
            OpenReports.Show();
        }

        private void btn_reprts_Click(object sender, EventArgs e)
        {
            frm_adds OpenAdds = new frm_adds();
            OpenAdds.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_operations OpenOperations = new frm_operations();
            OpenOperations.Show();
        }

        private void btn_analysisForm_Click(object sender, EventArgs e)
        {
            frm_analysis OpenAnalysis = new frm_analysis();
            OpenAnalysis.Show();
        }
    }
}
