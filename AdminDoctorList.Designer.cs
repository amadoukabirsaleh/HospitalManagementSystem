
namespace HospitalManagementSystem
{
    partial class AdminDoctorList
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.docPass = new System.Windows.Forms.TextBox();
            this.docSpecialty = new System.Windows.Forms.TextBox();
            this.docPhone = new System.Windows.Forms.TextBox();
            this.docName = new System.Windows.Forms.TextBox();
            this.docID = new System.Windows.Forms.TextBox();
            this.PatientAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DoctorExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 67);
            this.panel1.TabIndex = 17;
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
            this.panel2.Location = new System.Drawing.Point(0, 617);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1407, 115);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(700, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Doctors List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dataGridView1.Location = new System.Drawing.Point(389, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(985, 404);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // docPass
            // 
            this.docPass.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docPass.BackColor = System.Drawing.Color.Gainsboro;
            this.docPass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docPass.Location = new System.Drawing.Point(93, 428);
            this.docPass.Name = "docPass";
            this.docPass.Size = new System.Drawing.Size(170, 26);
            this.docPass.TabIndex = 32;
            this.docPass.Text = "DOCTOR PASSWORD";
            this.docPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docSpecialty
            // 
            this.docSpecialty.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docSpecialty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docSpecialty.BackColor = System.Drawing.Color.Gainsboro;
            this.docSpecialty.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docSpecialty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docSpecialty.Location = new System.Drawing.Point(93, 378);
            this.docSpecialty.Name = "docSpecialty";
            this.docSpecialty.Size = new System.Drawing.Size(170, 26);
            this.docSpecialty.TabIndex = 31;
            this.docSpecialty.Text = "DOCTOR SPECIALTY";
            this.docSpecialty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docPhone
            // 
            this.docPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.docPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docPhone.Location = new System.Drawing.Point(93, 328);
            this.docPhone.Name = "docPhone";
            this.docPhone.Size = new System.Drawing.Size(170, 26);
            this.docPhone.TabIndex = 30;
            this.docPhone.Text = "DOCTOR PHONE";
            this.docPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docName
            // 
            this.docName.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docName.BackColor = System.Drawing.Color.Gainsboro;
            this.docName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docName.Location = new System.Drawing.Point(93, 268);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(170, 26);
            this.docName.TabIndex = 29;
            this.docName.Text = "DOCTOR NAME";
            this.docName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docID
            // 
            this.docID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docID.BackColor = System.Drawing.Color.Gainsboro;
            this.docID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docID.Location = new System.Drawing.Point(93, 221);
            this.docID.Name = "docID";
            this.docID.Size = new System.Drawing.Size(170, 26);
            this.docID.TabIndex = 28;
            this.docID.Text = "DOCTOR ID";
            this.docID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientAdd
            // 
            this.PatientAdd.Location = new System.Drawing.Point(69, 491);
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(73, 29);
            this.PatientAdd.TabIndex = 33;
            this.PatientAdd.Text = "Add";
            this.PatientAdd.UseVisualStyleBackColor = true;
            this.PatientAdd.Click += new System.EventHandler(this.PatientUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 29);
            this.button1.TabIndex = 34;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 29);
            this.button2.TabIndex = 35;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(18, 563);
            this.DoctorExit.Name = "DoctorExit";
            this.DoctorExit.Size = new System.Drawing.Size(245, 37);
            this.DoctorExit.TabIndex = 36;
            this.DoctorExit.Text = "Go back";
            this.DoctorExit.UseVisualStyleBackColor = true;
            this.DoctorExit.Click += new System.EventHandler(this.DoctorExit_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 42);
            this.label2.TabIndex = 37;
            this.label2.Text = "Administrator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Edit Doctor Info";
            // 
            // AdminDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 733);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoctorExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PatientAdd);
            this.Controls.Add(this.docPass);
            this.Controls.Add(this.docSpecialty);
            this.Controls.Add(this.docPhone);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.docID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDoctorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDoctorList";
            this.Load += new System.EventHandler(this.AdminDoctorList_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox docPass;
        private System.Windows.Forms.TextBox docSpecialty;
        private System.Windows.Forms.TextBox docPhone;
        private System.Windows.Forms.TextBox docName;
        private System.Windows.Forms.TextBox docID;
        private System.Windows.Forms.Button PatientAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DoctorExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}