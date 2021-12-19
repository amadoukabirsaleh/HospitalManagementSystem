
namespace HospitalManagementSystem
{
    partial class DoctorPanel
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.patDiseas = new System.Windows.Forms.TextBox();
            this.patDisease = new System.Windows.Forms.TextBox();
            this.patBloodGroup = new System.Windows.Forms.ComboBox();
            this.patGender = new System.Windows.Forms.ComboBox();
            this.patAge = new System.Windows.Forms.TextBox();
            this.PatientUpdate = new System.Windows.Forms.Button();
            this.patPhone = new System.Windows.Forms.TextBox();
            this.patAddress = new System.Windows.Forms.TextBox();
            this.patName = new System.Windows.Forms.TextBox();
            this.patID = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DoctorExit = new System.Windows.Forms.Button();
            this.DoctorInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DoctorInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 64);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.LightCyan;
            this.label10.Location = new System.Drawing.Point(468, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(466, 37);
            this.label10.TabIndex = 2;
            this.label10.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-1, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 64);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.patDiseas);
            this.panel3.Controls.Add(this.patDisease);
            this.panel3.Controls.Add(this.patBloodGroup);
            this.panel3.Controls.Add(this.patGender);
            this.panel3.Controls.Add(this.patAge);
            this.panel3.Controls.Add(this.PatientUpdate);
            this.panel3.Controls.Add(this.patPhone);
            this.panel3.Controls.Add(this.patAddress);
            this.panel3.Controls.Add(this.patName);
            this.panel3.Controls.Add(this.patID);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.DoctorExit);
            this.panel3.Controls.Add(this.DoctorInfo);
            this.panel3.Controls.Add(this.DoctorLabel);
            this.panel3.Location = new System.Drawing.Point(1, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 605);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Edit Patient Info";
            // 
            // patDiseas
            // 
            this.patDiseas.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patDiseas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patDiseas.BackColor = System.Drawing.Color.Gainsboro;
            this.patDiseas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patDiseas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patDiseas.Location = new System.Drawing.Point(61, 454);
            this.patDiseas.Name = "patDiseas";
            this.patDiseas.Size = new System.Drawing.Size(160, 26);
            this.patDiseas.TabIndex = 21;
            this.patDiseas.Text = "PATIENT DISEASE";
            this.patDiseas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patDisease
            // 
            this.patDisease.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patDisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patDisease.BackColor = System.Drawing.Color.Gainsboro;
            this.patDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patDisease.Location = new System.Drawing.Point(112, 606);
            this.patDisease.Name = "patDisease";
            this.patDisease.ReadOnly = true;
            this.patDisease.Size = new System.Drawing.Size(160, 26);
            this.patDisease.TabIndex = 20;
            this.patDisease.Text = "PATIENT DISEASE";
            this.patDisease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patBloodGroup
            // 
            this.patBloodGroup.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patBloodGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patBloodGroup.FormattingEnabled = true;
            this.patBloodGroup.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.patBloodGroup.Location = new System.Drawing.Point(61, 419);
            this.patBloodGroup.Name = "patBloodGroup";
            this.patBloodGroup.Size = new System.Drawing.Size(159, 29);
            this.patBloodGroup.TabIndex = 19;
            // 
            // patGender
            // 
            this.patGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patGender.FormattingEnabled = true;
            this.patGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patGender.Location = new System.Drawing.Point(61, 384);
            this.patGender.Name = "patGender";
            this.patGender.Size = new System.Drawing.Size(159, 29);
            this.patGender.TabIndex = 18;
            // 
            // patAge
            // 
            this.patAge.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patAge.BackColor = System.Drawing.Color.Gainsboro;
            this.patAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAge.Location = new System.Drawing.Point(61, 352);
            this.patAge.Name = "patAge";
            this.patAge.Size = new System.Drawing.Size(160, 26);
            this.patAge.TabIndex = 17;
            this.patAge.Text = "PATIENT AGE";
            this.patAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatientUpdate
            // 
            this.PatientUpdate.Location = new System.Drawing.Point(93, 495);
            this.PatientUpdate.Name = "PatientUpdate";
            this.PatientUpdate.Size = new System.Drawing.Size(94, 29);
            this.PatientUpdate.TabIndex = 6;
            this.PatientUpdate.Text = "Update";
            this.PatientUpdate.UseVisualStyleBackColor = true;
            this.PatientUpdate.Click += new System.EventHandler(this.PatientUpdate_Click);
            // 
            // patPhone
            // 
            this.patPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.patPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patPhone.Location = new System.Drawing.Point(61, 320);
            this.patPhone.Name = "patPhone";
            this.patPhone.Size = new System.Drawing.Size(160, 26);
            this.patPhone.TabIndex = 16;
            this.patPhone.Text = "PATIENT PHONE";
            this.patPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patAddress
            // 
            this.patAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.patAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAddress.Location = new System.Drawing.Point(61, 288);
            this.patAddress.Name = "patAddress";
            this.patAddress.Size = new System.Drawing.Size(160, 26);
            this.patAddress.TabIndex = 15;
            this.patAddress.Text = "PATIENT ADRESSE";
            this.patAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patName
            // 
            this.patName.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patName.BackColor = System.Drawing.Color.Gainsboro;
            this.patName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patName.Location = new System.Drawing.Point(61, 256);
            this.patName.Name = "patName";
            this.patName.Size = new System.Drawing.Size(160, 26);
            this.patName.TabIndex = 14;
            this.patName.Text = "PATIENT NAME";
            this.patName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patID
            // 
            this.patID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patID.BackColor = System.Drawing.Color.Gainsboro;
            this.patID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patID.Location = new System.Drawing.Point(61, 224);
            this.patID.Name = "patID";
            this.patID.ReadOnly = true;
            this.patID.Size = new System.Drawing.Size(160, 26);
            this.patID.TabIndex = 13;
            this.patID.Text = "PATIENT ID";
            this.patID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(11, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 41);
            this.panel6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reference number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "ID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(11, 135);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 37);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Speciality:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Surgeon";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(27, 555);
            this.DoctorExit.Name = "DoctorExit";
            this.DoctorExit.Size = new System.Drawing.Size(245, 37);
            this.DoctorExit.TabIndex = 3;
            this.DoctorExit.Text = "Log Out";
            this.DoctorExit.UseVisualStyleBackColor = true;
            this.DoctorExit.Click += new System.EventHandler(this.DoctorExit_Click);
            // 
            // DoctorInfo
            // 
            this.DoctorInfo.BackColor = System.Drawing.SystemColors.Info;
            this.DoctorInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoctorInfo.Controls.Add(this.label4);
            this.DoctorInfo.Controls.Add(this.label6);
            this.DoctorInfo.Location = new System.Drawing.Point(11, 98);
            this.DoctorInfo.Name = "DoctorInfo";
            this.DoctorInfo.Size = new System.Drawing.Size(288, 41);
            this.DoctorInfo.TabIndex = 3;
            this.DoctorInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.DoctorInfo_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dr:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saitama";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DoctorLabel.Location = new System.Drawing.Point(11, 0);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(283, 88);
            this.DoctorLabel.TabIndex = 0;
            this.DoctorLabel.Text = "Doctor Panel";
            this.DoctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DoctorLabel.Click += new System.EventHandler(this.DoctorLabel_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(313, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 605);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 191);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(426, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointment List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(445, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 366);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1050, 191);
            this.dataGridView2.TabIndex = 19;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1407, 733);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.DoctorInfo.ResumeLayout(false);
            this.DoctorInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button DoctorExit;
        private System.Windows.Forms.Panel DoctorInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DoctorLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button PatientUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox patDisease;
        private System.Windows.Forms.ComboBox patBloodGroup;
        private System.Windows.Forms.ComboBox patGender;
        private System.Windows.Forms.TextBox patAge;
        private System.Windows.Forms.TextBox patPhone;
        private System.Windows.Forms.TextBox patAddress;
        private System.Windows.Forms.TextBox patName;
        private System.Windows.Forms.TextBox patID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox patDiseas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}