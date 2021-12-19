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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void PatientAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminAddPatient().Show();
        }

        private void DoctorExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void PatientUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminUpdatePatient().Show();
        }

        private void PatientDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done!");
        }

        private void DoctorEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DoctorView().Show();
        }

        private void AptAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AptAdding().Show();
        }

        private void AptUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AptUpdate().Show();
        }
    }
}
