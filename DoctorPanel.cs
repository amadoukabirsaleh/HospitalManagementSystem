using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }

        private void DoctorPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorEdit_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DoctorInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DoctorLabel_Click(object sender, EventArgs e)
        {

        }

        private void AptDelete_Click(object sender, EventArgs e)
        {

        }

        private void AptUpdate_Click(object sender, EventArgs e)
        {

        }

        private void AptAdd_Click(object sender, EventArgs e)
        {

        }

        private void PatientDelete_Click(object sender, EventArgs e)
        {

        }

        private void PatientUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportPage().Show();
        }

        private void PatientAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new PatientListView().Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
