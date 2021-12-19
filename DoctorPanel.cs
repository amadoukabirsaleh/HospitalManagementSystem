﻿using System;
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
    public partial class DoctorPanel : Form
    {
        public DoctorPanel()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\Documents\HMSdb.mdf;Integrated Security=True;Connect Timeout=30");

        private void DoctorPanel_Load(object sender, EventArgs e)
        {
            label6.Text = SignIn.username;

            //Doc ID displaying
            Con.Open();
            SqlCommand cmd0 = new SqlCommand();
            cmd0.CommandType = CommandType.Text;
            cmd0.CommandText = "select docID from DoctorTable where docName= '" + label6.Text + "'";
            cmd0.Connection = Con;
            SqlDataReader dr0 = cmd0.ExecuteReader();
            dr0.Read();
            int d0 = dr0.GetInt32(0);
            label8.Text = d0.ToString();
            Con.Close();


            //Doc Specialty displaying
            Con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select docSpecialty from DoctorTable where docName= '" + label6.Text + "'";
            cmd.Connection = Con;
            label7.Text = ((string)cmd.ExecuteScalar());
            Con.Close();


            populate();
        }

        void populate()
        {
            Con.Open();
            string query = "select *from PatientTable where DocID = " + label8.Text + "";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns["docID"].Visible = false;
            this.dataGridView1.Columns["patPassword"].Visible = false;


            Con.Close();
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
            new AdminUpdatePanel().Show();
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
