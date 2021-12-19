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
    public partial class AdminDoctorList : Form
    {
        public AdminDoctorList()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {


                docID.Text = dataGridView1.CurrentRow.Cells["docID"].Value.ToString();
                docName.Text = dataGridView1.CurrentRow.Cells["docName"].Value.ToString();
                docPhone.Text = dataGridView1.CurrentRow.Cells["docPhone"].Value.ToString();
                docSpecialty.Text = dataGridView1.CurrentRow.Cells["docSpecialty"].Value.ToString();
                docPass.Text = dataGridView1.CurrentRow.Cells["docPass"].Value.ToString();
             
            }
        }

        private void AdminDoctorList_Load(object sender, EventArgs e)
        {
            populate();
        }


        void populate()
        {
            Con.Open();
            string query = "select *from DoctorTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
         


            Con.Close();
        }

        private void DoctorExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminPanel().Show();
        }

        private void PatientUpdate_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (docID.Text == "" || docName.Text == "" || docPhone.Text == "" || docSpecialty.Text == "" || docSpecialty.Text == "" || docPass.Text=="")

            {
                MessageBox.Show("No empty field accepted");

            }

            else
            {
                // chking non duplicat ID

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTable where docID = '" + docID.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Doctor with same ID canNot be added");

                }
                else
                {

                    string query = "insert into DoctorTable values (" + docID.Text + ", '" + docName.Text + "','" + docPhone.Text + "', '" + docSpecialty.Text + "', " + docPass.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Added");
                    Con.Close();
                    populate();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (docID.Text == "" || docName.Text == "" || docPhone.Text == "" || docSpecialty.Text == "" || docPass.Text == "")
            {
                MessageBox.Show("No empty field accepted");

            }
            else
            {

                    string query = "update DoctorTable set docName = '" + docName.Text + "', docPhone = '" + docPhone.Text + "', docPass = " + docPass.Text+"  where docID = " + docID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor successfully updated");
                    Con.Close();
                    populate();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (docID.Text == "")
            {
                MessageBox.Show("Enter the doctor ID");
            }
            else
            {
                Con.Open();
                string query = "delete from DoctorTable where docID=" + docID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted");
                Con.Close();

                populate();

            }
        }
    }
}
