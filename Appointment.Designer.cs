
namespace HospitalManagementSystem
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DoctorExit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatientAdd = new System.Windows.Forms.Button();
            this.docID = new System.Windows.Forms.TextBox();
            this.patID = new System.Windows.Forms.TextBox();
            this.aptID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.aptTime = new System.Windows.Forms.DateTimePicker();
            this.aptDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 69);
            this.panel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.LightCyan;
            this.label10.Location = new System.Drawing.Point(442, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(466, 37);
            this.label10.TabIndex = 3;
            this.label10.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 618);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 69);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Edit Appointment Info";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 42);
            this.label2.TabIndex = 50;
            this.label2.Text = "Administrator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(19, 563);
            this.DoctorExit.Name = "DoctorExit";
            this.DoctorExit.Size = new System.Drawing.Size(245, 37);
            this.DoctorExit.TabIndex = 49;
            this.DoctorExit.Text = "Go back";
            this.DoctorExit.UseVisualStyleBackColor = true;
            this.DoctorExit.Click += new System.EventHandler(this.DoctorExit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 29);
            this.button2.TabIndex = 48;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 47;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientAdd
            // 
            this.PatientAdd.Location = new System.Drawing.Point(70, 491);
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(73, 29);
            this.PatientAdd.TabIndex = 46;
            this.PatientAdd.Text = "Add";
            this.PatientAdd.UseVisualStyleBackColor = true;
            this.PatientAdd.Click += new System.EventHandler(this.PatientAdd_Click);
            // 
            // docID
            // 
            this.docID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docID.BackColor = System.Drawing.Color.Gainsboro;
            this.docID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docID.Location = new System.Drawing.Point(94, 346);
            this.docID.Name = "docID";
            this.docID.Size = new System.Drawing.Size(170, 26);
            this.docID.TabIndex = 43;
            this.docID.Text = "Doctor ID";
            this.docID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patID
            // 
            this.patID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patID.BackColor = System.Drawing.Color.Gainsboro;
            this.patID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patID.Location = new System.Drawing.Point(94, 286);
            this.patID.Name = "patID";
            this.patID.Size = new System.Drawing.Size(170, 26);
            this.patID.TabIndex = 42;
            this.patID.Text = "Patient  ID";
            this.patID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aptID
            // 
            this.aptID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.aptID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.aptID.BackColor = System.Drawing.Color.Gainsboro;
            this.aptID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aptID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aptID.Location = new System.Drawing.Point(94, 239);
            this.aptID.Name = "aptID";
            this.aptID.Size = new System.Drawing.Size(170, 26);
            this.aptID.TabIndex = 41;
            this.aptID.Text = "apt ID";
            this.aptID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 404);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(701, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 42);
            this.label1.TabIndex = 39;
            this.label1.Text = "Appointment List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aptTime
            // 
            this.aptTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.aptTime.Location = new System.Drawing.Point(94, 441);
            this.aptTime.Name = "aptTime";
            this.aptTime.ShowUpDown = true;
            this.aptTime.Size = new System.Drawing.Size(170, 27);
            this.aptTime.TabIndex = 52;
            // 
            // aptDate
            // 
            this.aptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.aptDate.Location = new System.Drawing.Point(94, 391);
            this.aptDate.Name = "aptDate";
            this.aptDate.ShowUpDown = true;
            this.aptDate.Size = new System.Drawing.Size(170, 27);
            this.aptDate.TabIndex = 53;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 686);
            this.Controls.Add(this.aptDate);
            this.Controls.Add(this.aptTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoctorExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientAdd);
            this.Controls.Add(this.docID);
            this.Controls.Add(this.patID);
            this.Controls.Add(this.aptID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Appointment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoctorExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PatientAdd;
        private System.Windows.Forms.TextBox docID;
        private System.Windows.Forms.TextBox patID;
        private System.Windows.Forms.TextBox aptID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker aptTime;
        private System.Windows.Forms.DateTimePicker aptDate;
    }
}