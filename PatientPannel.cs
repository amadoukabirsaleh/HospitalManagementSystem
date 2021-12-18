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
    public partial class PatientPannel : Form
    {

        public PatientPannel()
        {
            InitializeComponent();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

      

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientPannel_Load(object sender, EventArgs e)
        {
            Con.Open();


            patName.Text = SignIn.username;

            //patient ID displaying
            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select patID from PatientTable where patName= '" + patName.Text + "'";
            cmd0.Connection = Con;
            SqlDataReader dr0 = cmd0.ExecuteReader();
            dr0.Read();
            int d0 = dr0.GetInt32(0);
            patID.Text = d0.ToString();
            Con.Close();


            //patient addresse displaying
            Con.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select patAddress from PatientTable where patName= '"+patName.Text+"'";
            cmd1.Connection = Con;
            patAddress.Text = ((string)cmd1.ExecuteScalar());

            //patient Age displaying
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select patAge from PatientTable where patName= '" + patName.Text + "'";
            cmd2.Connection = Con;
            SqlDataReader dr = cmd2.ExecuteReader();
            dr.Read();
            int d = dr.GetInt32(0);
            patAge.Text = d.ToString();
            Con.Close();
            /* SqlCommand cmd2 = new SqlCommand();
             cmd2.CommandText = "select patAge from PatientTable where patName= '" + patName.Text + "'";
             cmd2.Connection = Con;
             patAge.Text = ((string)cmd2.ExecuteScalar());*/

            //patient Phone displaying
            Con.Open();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select patPhone from PatientTable where patName= '" + patName.Text + "'";
            cmd3.Connection = Con;
            patPhone.Text = ((string)cmd3.ExecuteScalar());

            //patient Gender displaying
            SqlCommand cmd4 = new SqlCommand();
            cmd4.CommandText = "select patGender from PatientTable where patName= '" + patName.Text + "'";
            cmd4.Connection = Con;
            patGender.Text = ((string)cmd4.ExecuteScalar());

            //patient BloodGroup displaying
            SqlCommand cmd5 = new SqlCommand();
            cmd5.CommandText = "select patBloodGroup from PatientTable where patName= '" + patName.Text + "'";
            cmd5.Connection = Con;
            patBloodGroup.Text = ((string)cmd5.ExecuteScalar());

            //patient disease displaying
            SqlCommand cmd6 = new SqlCommand();
            cmd6.CommandText = "select patDisease from PatientTable where patName= '" + patName.Text + "'";
            cmd6.Connection = Con;
            patDisease.Text = ((string)cmd6.ExecuteScalar());

            Con.Close();

            populate();
        }

        void populate()
        {
            Con.Open();
            string query = "select *from DiagnosisTable where PatientID = "+patID.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTable set patName = '" + patName.Text + "', patAddress = '" + patAddress.Text + "', patPhone = '" + patPhone.Text + "',patAge = " + patAge.Text + ", patGender = '" + patGender.SelectedItem.ToString() + "',patBloodGroup= '" + patBloodGroup.SelectedItem.ToString() + "', patDisease = '" + patDisease.Text + "' where patID = " + patID.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully updated");
            Con.Close();
            //populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainBoard M = new MainBoard();
            M.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (patID.Text == "" || patName.Text == "" || patAddress.Text == "" || patPhone.Text == "" || patAge.Text == "" || patDisease.Text == "")
            {
                MessageBox.Show("No empty field accepted");

            }

            else {
                Con.Open();
               // string query  = "insert into PatientTable(
                string query = "insert into PatientTable values (" + patID.Text + ", '" + patName.Text + "','" + patAddress.Text + "', '" + patPhone.Text + "', "+patAge.Text+" ,'" + patGender.SelectedItem.ToString() + "', '" + patBloodGroup.SelectedItem.ToString() + "', '" + patDisease.Text + "' )";
            SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                //populate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deletePat_Click(object sender, EventArgs e)
        {
            if(patID.Text == "")
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

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount > 0 )
            {


                patientNamelbl.Text = dataGridView1.CurrentRow.Cells["PatientName"].Value.ToString();
                patientDiagnosislbl.Text = dataGridView1.CurrentRow.Cells["Diagnosis"].Value.ToString();
                patientSymptomlbl.Text = dataGridView1.CurrentRow.Cells["Symptoms"].Value.ToString();
                patientMedecinelbl.Text = dataGridView1.CurrentRow.Cells["Medecines"].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(panel2.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(patientNamelbl.Text +"\n"+ patientDiagnosislbl.Text + "\n" + patientSymptomlbl.Text +"\n" + patientMedecinelbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130,150));
            e.Graphics.DrawString(label9.Text+"\n"+label10.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230,500));

        }

        private void printDocument_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
