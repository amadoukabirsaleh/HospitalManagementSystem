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
    public partial class AdminAddDoctor : Form
    {
        public AdminAddDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Added");
            this.Hide();
            new AdminPanel().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }
    }
}
