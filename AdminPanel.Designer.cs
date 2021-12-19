
namespace HospitalManagementSystem
{
    partial class AdminPanel
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
            this.AptDelete = new System.Windows.Forms.Button();
            this.AptUpdate = new System.Windows.Forms.Button();
            this.AptAdd = new System.Windows.Forms.Button();
            this.PatientAdd = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.PatientUpdate = new System.Windows.Forms.Button();
            this.PatientDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoctorExit = new System.Windows.Forms.Button();
            this.DoctorInfo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DoctorEdit = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.patDisease = new System.Windows.Forms.TextBox();
            this.patBloodGroup = new System.Windows.Forms.ComboBox();
            this.patGender = new System.Windows.Forms.ComboBox();
            this.patAge = new System.Windows.Forms.TextBox();
            this.patPhone = new System.Windows.Forms.TextBox();
            this.patAddress = new System.Windows.Forms.TextBox();
            this.patName = new System.Windows.Forms.TextBox();
            this.patID = new System.Windows.Forms.TextBox();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patPassword = new System.Windows.Forms.TextBox();
            this.docID = new System.Windows.Forms.TextBox();
            this.DoctorInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AptDelete
            // 
            this.AptDelete.Location = new System.Drawing.Point(982, 563);
            this.AptDelete.Name = "AptDelete";
            this.AptDelete.Size = new System.Drawing.Size(94, 29);
            this.AptDelete.TabIndex = 10;
            this.AptDelete.Text = "Delete";
            this.AptDelete.UseVisualStyleBackColor = true;
            // 
            // AptUpdate
            // 
            this.AptUpdate.Location = new System.Drawing.Point(491, 563);
            this.AptUpdate.Name = "AptUpdate";
            this.AptUpdate.Size = new System.Drawing.Size(94, 29);
            this.AptUpdate.TabIndex = 9;
            this.AptUpdate.Text = "Update";
            this.AptUpdate.UseVisualStyleBackColor = true;
            // 
            // AptAdd
            // 
            this.AptAdd.Location = new System.Drawing.Point(26, 563);
            this.AptAdd.Name = "AptAdd";
            this.AptAdd.Size = new System.Drawing.Size(94, 29);
            this.AptAdd.TabIndex = 8;
            this.AptAdd.Text = "Add";
            this.AptAdd.UseVisualStyleBackColor = true;
            // 
            // PatientAdd
            // 
            this.PatientAdd.Location = new System.Drawing.Point(10, 414);
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(94, 29);
            this.PatientAdd.TabIndex = 5;
            this.PatientAdd.Text = "Add";
            this.PatientAdd.UseVisualStyleBackColor = true;
            this.PatientAdd.Click += new System.EventHandler(this.PatientAdd_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(26, 356);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1050, 193);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Patient ID";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Patient Name";
            this.columnHeader5.Width = 165;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doctor Name";
            this.columnHeader6.Width = 160;
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
            // 
            // PatientUpdate
            // 
            this.PatientUpdate.Location = new System.Drawing.Point(110, 414);
            this.PatientUpdate.Name = "PatientUpdate";
            this.PatientUpdate.Size = new System.Drawing.Size(94, 29);
            this.PatientUpdate.TabIndex = 6;
            this.PatientUpdate.Text = "Update";
            this.PatientUpdate.UseVisualStyleBackColor = true;
            this.PatientUpdate.Click += new System.EventHandler(this.PatientUpdate_Click);
            // 
            // PatientDelete
            // 
            this.PatientDelete.Location = new System.Drawing.Point(210, 414);
            this.PatientDelete.Name = "PatientDelete";
            this.PatientDelete.Size = new System.Drawing.Size(94, 29);
            this.PatientDelete.TabIndex = 7;
            this.PatientDelete.Text = "Delete";
            this.PatientDelete.UseVisualStyleBackColor = true;
            this.PatientDelete.Click += new System.EventHandler(this.PatientDelete_Click);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saitama";
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(27, 563);
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
            this.DoctorInfo.Location = new System.Drawing.Point(15, 93);
            this.DoctorInfo.Name = "DoctorInfo";
            this.DoctorInfo.Size = new System.Drawing.Size(288, 41);
            this.DoctorInfo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Admin";
            // 
            // DoctorEdit
            // 
            this.DoctorEdit.Location = new System.Drawing.Point(52, 173);
            this.DoctorEdit.Name = "DoctorEdit";
            this.DoctorEdit.Size = new System.Drawing.Size(201, 27);
            this.DoctorEdit.TabIndex = 11;
            this.DoctorEdit.Text = "Edit Patient Info";
            this.DoctorEdit.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(15, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 37);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.docID);
            this.panel3.Controls.Add(this.patPassword);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.patDisease);
            this.panel3.Controls.Add(this.patBloodGroup);
            this.panel3.Controls.Add(this.patGender);
            this.panel3.Controls.Add(this.PatientDelete);
            this.panel3.Controls.Add(this.patAge);
            this.panel3.Controls.Add(this.PatientUpdate);
            this.panel3.Controls.Add(this.PatientAdd);
            this.panel3.Controls.Add(this.patPhone);
            this.panel3.Controls.Add(this.patAddress);
            this.panel3.Controls.Add(this.patName);
            this.panel3.Controls.Add(this.patID);
            this.panel3.Controls.Add(this.DoctorEdit);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.DoctorExit);
            this.panel3.Controls.Add(this.DoctorInfo);
            this.panel3.Controls.Add(this.AdminLabel);
            this.panel3.Location = new System.Drawing.Point(2, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 605);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 29);
            this.button2.TabIndex = 32;
            this.button2.Text = "See Doctor List";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // patDisease
            // 
            this.patDisease.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patDisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patDisease.BackColor = System.Drawing.Color.Gainsboro;
            this.patDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patDisease.Location = new System.Drawing.Point(147, 303);
            this.patDisease.Name = "patDisease";
            this.patDisease.Size = new System.Drawing.Size(151, 26);
            this.patDisease.TabIndex = 30;
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
            this.patBloodGroup.Location = new System.Drawing.Point(147, 270);
            this.patBloodGroup.Name = "patBloodGroup";
            this.patBloodGroup.Size = new System.Drawing.Size(150, 29);
            this.patBloodGroup.TabIndex = 29;
            // 
            // patGender
            // 
            this.patGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patGender.FormattingEnabled = true;
            this.patGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patGender.Location = new System.Drawing.Point(148, 239);
            this.patGender.Name = "patGender";
            this.patGender.Size = new System.Drawing.Size(150, 29);
            this.patGender.TabIndex = 28;
            // 
            // patAge
            // 
            this.patAge.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patAge.BackColor = System.Drawing.Color.Gainsboro;
            this.patAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAge.Location = new System.Drawing.Point(10, 367);
            this.patAge.Name = "patAge";
            this.patAge.Size = new System.Drawing.Size(130, 26);
            this.patAge.TabIndex = 27;
            this.patAge.Text = "PATIENT AGE";
            this.patAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patPhone
            // 
            this.patPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.patPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patPhone.Location = new System.Drawing.Point(10, 335);
            this.patPhone.Name = "patPhone";
            this.patPhone.Size = new System.Drawing.Size(130, 26);
            this.patPhone.TabIndex = 26;
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
            this.patAddress.Location = new System.Drawing.Point(10, 303);
            this.patAddress.Name = "patAddress";
            this.patAddress.Size = new System.Drawing.Size(130, 26);
            this.patAddress.TabIndex = 25;
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
            this.patName.Location = new System.Drawing.Point(10, 271);
            this.patName.Name = "patName";
            this.patName.Size = new System.Drawing.Size(130, 26);
            this.patName.TabIndex = 24;
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
            this.patID.Location = new System.Drawing.Point(10, 239);
            this.patID.Name = "patID";
            this.patID.Size = new System.Drawing.Size(130, 26);
            this.patID.TabIndex = 23;
            this.patID.Text = "PATIENT ID";
            this.patID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminLabel
            // 
            this.AdminLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AdminLabel.Location = new System.Drawing.Point(15, 3);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(283, 88);
            this.AdminLabel.TabIndex = 0;
            this.AdminLabel.Text = "Admin Panel";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 669);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 64);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 64);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.AptDelete);
            this.panel4.Controls.Add(this.AptUpdate);
            this.panel4.Controls.Add(this.AptAdd);
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(314, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1093, 605);
            this.panel4.TabIndex = 8;
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 244);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patPassword
            // 
            this.patPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.patPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patPassword.Location = new System.Drawing.Point(147, 335);
            this.patPassword.Name = "patPassword";
            this.patPassword.Size = new System.Drawing.Size(151, 26);
            this.patPassword.TabIndex = 33;
            this.patPassword.Text = "PATIENT PASSWORD";
            this.patPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // docID
            // 
            this.docID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.docID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.docID.BackColor = System.Drawing.Color.Gainsboro;
            this.docID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.docID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.docID.Location = new System.Drawing.Point(147, 367);
            this.docID.Name = "docID";
            this.docID.Size = new System.Drawing.Size(151, 26);
            this.docID.TabIndex = 34;
            this.docID.Text = "DOCTOR ID";
            this.docID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.DoctorInfo.ResumeLayout(false);
            this.DoctorInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AptDelete;
        private System.Windows.Forms.Button AptUpdate;
        private System.Windows.Forms.Button AptAdd;
        private System.Windows.Forms.Button PatientAdd;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PatientUpdate;
        private System.Windows.Forms.Button PatientDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DoctorExit;
        private System.Windows.Forms.Panel DoctorInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DoctorEdit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox patDisease;
        private System.Windows.Forms.ComboBox patBloodGroup;
        private System.Windows.Forms.ComboBox patGender;
        private System.Windows.Forms.TextBox patAge;
        private System.Windows.Forms.TextBox patPhone;
        private System.Windows.Forms.TextBox patAddress;
        private System.Windows.Forms.TextBox patName;
        private System.Windows.Forms.TextBox patID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox docID;
        private System.Windows.Forms.TextBox patPassword;
    }
}