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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void Appointment_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {


                aptID.Text = dataGridView1.CurrentRow.Cells["aptID"].Value.ToString();
                patID.Text = dataGridView1.CurrentRow.Cells["patID"].Value.ToString();
                docID.Text = dataGridView1.CurrentRow.Cells["docID"].Value.ToString();
                aptDate.Text = dataGridView1.CurrentRow.Cells["aptDate"].Value.ToString();
                aptTime.Text = dataGridView1.CurrentRow.Cells["aptTime"].Value.ToString();


            }



        }

        void populate()
        {
            Con.Open();
            string query = "select *from AppointmentTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            Con.Close();
        }

        private void PatientAdd_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (aptID.Text == "" || patID.Text == "" || docID.Text == "" || aptDate.Text == "" )

            {
                MessageBox.Show("No empty field accepted");

            }

            else
            {
                // chking non duplicat ID

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from AppointmentTable where aptID = '" + aptID.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Appointment with same ID canNot be added");

                }
                else
                {

                    string query = "insert into AppointmentTable values (" + aptID.Text + ", " + patID.Text + "," + docID.Text + ", '" + aptDate.Value.ToShortDateString() + "', '"+aptTime.Value.ToShortTimeString()+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Successfully Added");
                    Con.Close();
                    populate();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (aptID.Text == "")
            {
                MessageBox.Show("Enter the apt ID");
            }
            else
            {
                Con.Open();
                string query = "delete from AppointmentTable where aptID=" + aptID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment Successfully Deleted");
                Con.Close();

                populate();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aptID.Text == "" || patID.Text == "" || docID.Text == "" || aptDate.Text == "" || aptTime.Text == "")
            {
                MessageBox.Show("No empty field accepted");

            }
            else
            {
                Con.Open();



                string query = "update AppointmentTable set aptID = '" + aptID.Text + "', patID = '" + patID.Text + "', docID = '" + docID.Text + "',aptDate = '" + aptDate.Value.ToShortDateString() + "', aptTime = '" + aptTime.Value.ToShortTimeString() + "' where aptID = " + aptID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Appointment successfully updated");
                Con.Close();
                populate();

            }
        }

        private void DoctorExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }
    }
}
