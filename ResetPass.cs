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
    public partial class ResetPass : Form
    {
        public ResetPass()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                NewPass.PasswordChar = '\0';
                ConfPass.PasswordChar = '\0';

            }
            else
            {
                NewPass.PasswordChar = '•';
                ConfPass.PasswordChar = '•';
            }
        }

        private void NewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Successfully Modified!");
        }
    }
}
