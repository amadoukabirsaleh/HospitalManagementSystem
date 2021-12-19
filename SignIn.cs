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

namespace HospitalManagementSystem
{
    public partial class SignIn : Form
    {
        public static string username = "";

        public SignIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                Password.PasswordChar = '\0';

            }
            else
            {
                Password.PasswordChar = '•';
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new ResetPass().Show();
        }

        private void exitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signinButton_Click(object sender, EventArgs e)
        {

            if (uName.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Enter a Username and a Password");
            }

            else 
            {
                Con.Open();
                //For patients
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from PatientTable where patName = '"+ uName.Text + "' AND patPassword = '" + Password.Text + "'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //For doctors
              SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from DoctorTable where docName = '" + uName.Text + "' AND docPass = '" + Password.Text + "'", Con);
               DataTable dt1 = new DataTable();
               sda1.Fill(dt1);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    username = uName.Text;
                    PatientPannel P = new PatientPannel();
                    P.Show();
                    this.Hide();
                }
                else if (dt1.Rows[0][0].ToString() == "1")
                {
                    username = uName.Text;
                    DoctorPanel d = new DoctorPanel();
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password !");
                    uName.Text = "";
                    Password.Text = "";
                    Con.Close();
                }
              //  this.Hide();
              //  new PatientPannel().Show();
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
