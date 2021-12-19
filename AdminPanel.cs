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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");


        private void PatientAdd_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (patID.Text == "" || patName.Text == "" || patAddress.Text == "" || patPhone.Text == "" || patAge.Text == "" || patDisease.Text == "" || patPassword.Text=="" || docID.Text=="")
                
            {
                MessageBox.Show("No empty field accepted");

            }

            else
            {
                // chking non duplicat ID

                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from PatientTable where patID = '" + patID.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Patient with same ID canNot be added");
                    
                }
                else {

                    string query = "insert into PatientTable values (" + patID.Text + ", '" + patName.Text + "','" + patAddress.Text + "', '" + patPhone.Text + "', " + patAge.Text + " ,'" + patGender.SelectedItem.ToString() + "', '" + patBloodGroup.SelectedItem.ToString() + "', '" + patDisease.Text + "' , '" + patPassword.Text + "', " + docID.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Added");
                    Con.Close();
                    populate();
                }
            }
        }

        private void DoctorExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignIn().Show();
        }

        private void PatientUpdate_Click(object sender, EventArgs e)
        {
            if (patID.Text == "" || patName.Text == "" || patAddress.Text == "" || patPhone.Text == "" || patAge.Text == "" || patDisease.Text == "")
            {
                MessageBox.Show("No empty field accepted");

            }
            else
            {
                Con.Open();

               
               
                    string query = "update PatientTable set patName = '" + patName.Text + "', patAddress = '" + patAddress.Text + "', patPhone = '" + patPhone.Text + "',patAge = " + patAge.Text + ", patGender = '" + patGender.SelectedItem.ToString() + "',patBloodGroup= '" + patBloodGroup.SelectedItem.ToString() + "', patDisease = '" + patDisease.Text + "' where patID = " + patID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient successfully updated");
                    Con.Close();
                    populate();
                
            }
        }

        private void PatientDelete_Click(object sender, EventArgs e)
        {
            
            if (patID.Text == "")
            {
                MessageBox.Show("Enter the patient ID");
            }
            else
            {
                Con.Open();
                string query = "delete from PatientTable where patID=" + patID.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();

                populate();

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            label6.Text = SignIn.username;
            populate();

        }

        void populate()
        {
            Con.Open();
            string query = "select *from PatientTable";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns["docID"].Visible = false;
            this.dataGridView1.Columns["patPassword"].Visible = false;


            Con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {


                patID.Text = dataGridView1.CurrentRow.Cells["patID"].Value.ToString();
                patName.Text = dataGridView1.CurrentRow.Cells["patName"].Value.ToString();
                patAddress.Text = dataGridView1.CurrentRow.Cells["patAddress"].Value.ToString();
                patPhone.Text = dataGridView1.CurrentRow.Cells["patPhone"].Value.ToString();

                patAge.Text = dataGridView1.CurrentRow.Cells["patAge"].Value.ToString();
                patGender.Text = dataGridView1.CurrentRow.Cells["patGender"].Value.ToString();
                patBloodGroup.Text = dataGridView1.CurrentRow.Cells["patBloodGroup"].Value.ToString();
                patDisease.Text = dataGridView1.CurrentRow.Cells["patDisease"].Value.ToString();

                patPassword.Text = dataGridView1.CurrentRow.Cells["patPassword"].Value.ToString();
                docID.Text = dataGridView1.CurrentRow.Cells["docID"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDoctorList().Show();
        }
    }
}
