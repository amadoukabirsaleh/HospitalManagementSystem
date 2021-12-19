
namespace HospitalManagementSystem
{
    partial class PatientPannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientPannel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patID = new System.Windows.Forms.TextBox();
            this.patName = new System.Windows.Forms.TextBox();
            this.patAddress = new System.Windows.Forms.TextBox();
            this.patPhone = new System.Windows.Forms.TextBox();
            this.patAge = new System.Windows.Forms.TextBox();
            this.patGender = new System.Windows.Forms.ComboBox();
            this.patBloodGroup = new System.Windows.Forms.ComboBox();
            this.patDisease = new System.Windows.Forms.TextBox();
            this.updatePat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.patientMedecinelbl = new System.Windows.Forms.Label();
            this.patientDiagnosislbl = new System.Windows.Forms.Label();
            this.patientSymptomlbl = new System.Windows.Forms.Label();
            this.patientNamelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addPat = new System.Windows.Forms.Button();
            this.deletePat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 108);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1359, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(571, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATIENT PANNEL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(456, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patID
            // 
            this.patID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patID.BackColor = System.Drawing.Color.Gainsboro;
            this.patID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patID.Location = new System.Drawing.Point(189, 123);
            this.patID.Name = "patID";
            this.patID.ReadOnly = true;
            this.patID.Size = new System.Drawing.Size(160, 26);
            this.patID.TabIndex = 2;
            this.patID.Text = "PATIENT ID";
            this.patID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // patName
            // 
            this.patName.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patName.BackColor = System.Drawing.Color.Gainsboro;
            this.patName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patName.Location = new System.Drawing.Point(188, 168);
            this.patName.Name = "patName";
            this.patName.ReadOnly = true;
            this.patName.Size = new System.Drawing.Size(160, 26);
            this.patName.TabIndex = 3;
            this.patName.Text = "PATIENT NAME";
            this.patName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patName.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // patAddress
            // 
            this.patAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.patAddress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAddress.Location = new System.Drawing.Point(188, 216);
            this.patAddress.Name = "patAddress";
            this.patAddress.ReadOnly = true;
            this.patAddress.Size = new System.Drawing.Size(160, 26);
            this.patAddress.TabIndex = 4;
            this.patAddress.Text = "PATIENT ADRESSE";
            this.patAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // patPhone
            // 
            this.patPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.patPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patPhone.Location = new System.Drawing.Point(188, 259);
            this.patPhone.Name = "patPhone";
            this.patPhone.ReadOnly = true;
            this.patPhone.Size = new System.Drawing.Size(160, 26);
            this.patPhone.TabIndex = 5;
            this.patPhone.Text = "PATIENT PHONE";
            this.patPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patPhone.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // patAge
            // 
            this.patAge.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patAge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patAge.BackColor = System.Drawing.Color.Gainsboro;
            this.patAge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patAge.Location = new System.Drawing.Point(188, 308);
            this.patAge.Name = "patAge";
            this.patAge.ReadOnly = true;
            this.patAge.Size = new System.Drawing.Size(160, 26);
            this.patAge.TabIndex = 6;
            this.patAge.Text = "PATIENT AGE";
            this.patAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patAge.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // patGender
            // 
            this.patGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patGender.FormattingEnabled = true;
            this.patGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patGender.Location = new System.Drawing.Point(188, 352);
            this.patGender.Name = "patGender";
            this.patGender.Size = new System.Drawing.Size(159, 29);
            this.patGender.TabIndex = 7;
            this.patGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // patBloodGroup
            // 
            this.patBloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.patBloodGroup.Location = new System.Drawing.Point(188, 402);
            this.patBloodGroup.Name = "patBloodGroup";
            this.patBloodGroup.Size = new System.Drawing.Size(159, 29);
            this.patBloodGroup.TabIndex = 8;
            this.patBloodGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // patDisease
            // 
            this.patDisease.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patDisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patDisease.BackColor = System.Drawing.Color.Gainsboro;
            this.patDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patDisease.Location = new System.Drawing.Point(189, 451);
            this.patDisease.Name = "patDisease";
            this.patDisease.ReadOnly = true;
            this.patDisease.Size = new System.Drawing.Size(160, 26);
            this.patDisease.TabIndex = 9;
            this.patDisease.Text = "PATIENT DISEASE";
            this.patDisease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patDisease.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // updatePat
            // 
            this.updatePat.BackColor = System.Drawing.Color.Crimson;
            this.updatePat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatePat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updatePat.Location = new System.Drawing.Point(20, 590);
            this.updatePat.Name = "updatePat";
            this.updatePat.Size = new System.Drawing.Size(105, 46);
            this.updatePat.TabIndex = 11;
            this.updatePat.Text = "Update";
            this.updatePat.UseVisualStyleBackColor = false;
            this.updatePat.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(45, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Appointment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(182, 527);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.printDocument);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.patientMedecinelbl);
            this.panel2.Controls.Add(this.patientDiagnosislbl);
            this.panel2.Controls.Add(this.patientSymptomlbl);
            this.panel2.Controls.Add(this.patientNamelbl);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(412, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 314);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // printDocument
            // 
            this.printDocument.BackColor = System.Drawing.Color.Green;
            this.printDocument.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.printDocument.ForeColor = System.Drawing.Color.White;
            this.printDocument.Location = new System.Drawing.Point(820, 18);
            this.printDocument.Name = "printDocument";
            this.printDocument.Size = new System.Drawing.Size(94, 29);
            this.printDocument.TabIndex = 10;
            this.printDocument.Text = "Print";
            this.printDocument.UseVisualStyleBackColor = false;
            this.printDocument.Click += new System.EventHandler(this.printDocument_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(384, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 24);
            this.label10.TabIndex = 9;
            this.label10.Text = "Karabuk University";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(311, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(288, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // patientMedecinelbl
            // 
            this.patientMedecinelbl.AutoSize = true;
            this.patientMedecinelbl.BackColor = System.Drawing.Color.Transparent;
            this.patientMedecinelbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientMedecinelbl.ForeColor = System.Drawing.Color.Crimson;
            this.patientMedecinelbl.Location = new System.Drawing.Point(534, 140);
            this.patientMedecinelbl.Name = "patientMedecinelbl";
            this.patientMedecinelbl.Size = new System.Drawing.Size(0, 24);
            this.patientMedecinelbl.TabIndex = 7;
            this.patientMedecinelbl.Click += new System.EventHandler(this.label7_Click);
            // 
            // patientDiagnosislbl
            // 
            this.patientDiagnosislbl.AutoSize = true;
            this.patientDiagnosislbl.BackColor = System.Drawing.Color.Transparent;
            this.patientDiagnosislbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientDiagnosislbl.ForeColor = System.Drawing.Color.Crimson;
            this.patientDiagnosislbl.Location = new System.Drawing.Point(541, 80);
            this.patientDiagnosislbl.Name = "patientDiagnosislbl";
            this.patientDiagnosislbl.Size = new System.Drawing.Size(0, 24);
            this.patientDiagnosislbl.TabIndex = 6;
            this.patientDiagnosislbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // patientSymptomlbl
            // 
            this.patientSymptomlbl.AutoSize = true;
            this.patientSymptomlbl.BackColor = System.Drawing.Color.Transparent;
            this.patientSymptomlbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientSymptomlbl.ForeColor = System.Drawing.Color.Crimson;
            this.patientSymptomlbl.Location = new System.Drawing.Point(253, 142);
            this.patientSymptomlbl.Name = "patientSymptomlbl";
            this.patientSymptomlbl.Size = new System.Drawing.Size(0, 24);
            this.patientSymptomlbl.TabIndex = 5;
            this.patientSymptomlbl.Click += new System.EventHandler(this.label5_Click);
            // 
            // patientNamelbl
            // 
            this.patientNamelbl.AutoSize = true;
            this.patientNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.patientNamelbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientNamelbl.ForeColor = System.Drawing.Color.Crimson;
            this.patientNamelbl.Location = new System.Drawing.Point(253, 80);
            this.patientNamelbl.Name = "patientNamelbl";
            this.patientNamelbl.Size = new System.Drawing.Size(0, 24);
            this.patientNamelbl.TabIndex = 4;
            this.patientNamelbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(311, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIAGNOSIS SUMMARY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // addPat
            // 
            this.addPat.BackColor = System.Drawing.Color.Crimson;
            this.addPat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addPat.Location = new System.Drawing.Point(131, 590);
            this.addPat.Name = "addPat";
            this.addPat.Size = new System.Drawing.Size(105, 46);
            this.addPat.TabIndex = 15;
            this.addPat.Text = "Add";
            this.addPat.UseVisualStyleBackColor = false;
            this.addPat.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // deletePat
            // 
            this.deletePat.BackColor = System.Drawing.Color.Crimson;
            this.deletePat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletePat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deletePat.Location = new System.Drawing.Point(242, 590);
            this.deletePat.Name = "deletePat";
            this.deletePat.Size = new System.Drawing.Size(105, 46);
            this.deletePat.TabIndex = 16;
            this.deletePat.Text = "Delete";
            this.deletePat.UseVisualStyleBackColor = false;
            this.deletePat.Click += new System.EventHandler(this.deletePat_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(412, 490);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(990, 146);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(821, 451);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(199, 33);
            this.label11.TabIndex = 10;
            this.label11.Text = "DIAGNOSIS LIST";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(12, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "REFERENCE NUMBER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(117, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "NAME";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(93, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 20;
            this.label14.Text = "ADDRESS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(77, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "TELEPHONE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(131, 311);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 22;
            this.label16.Text = "AGE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(100, 356);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "GENDER";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(52, 406);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 19);
            this.label18.TabIndex = 24;
            this.label18.Text = "BLOODGROUP";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(36, 451);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 19);
            this.label19.TabIndex = 25;
            this.label19.Text = "MAJOR DISEASE";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(116, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "PATIENT NAME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(143, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "SYMPTOMS :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(430, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "DIAGNOSIS :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.Crimson;
            this.label20.Location = new System.Drawing.Point(420, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "MEDECINES :";
            // 
            // PatientPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1402, 742);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletePat);
            this.Controls.Add(this.addPat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updatePat);
            this.Controls.Add(this.patDisease);
            this.Controls.Add(this.patBloodGroup);
            this.Controls.Add(this.patGender);
            this.Controls.Add(this.patAge);
            this.Controls.Add(this.patPhone);
            this.Controls.Add(this.patAddress);
            this.Controls.Add(this.patName);
            this.Controls.Add(this.patID);
            this.Controls.Add(this.panel1);
            this.Name = "PatientPannel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientPannel";
            this.Load += new System.EventHandler(this.PatientPannel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patID;
        private System.Windows.Forms.TextBox patName;
        private System.Windows.Forms.TextBox patAddress;
        private System.Windows.Forms.TextBox patPhone;
        private System.Windows.Forms.TextBox patAge;
        private System.Windows.Forms.ComboBox patGender;
        private System.Windows.Forms.ComboBox patBloodGroup;
        private System.Windows.Forms.TextBox patDisease;
        private System.Windows.Forms.Button updatePat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label patientNamelbl;
        private System.Windows.Forms.Label patientDiagnosislbl;
        private System.Windows.Forms.Label patientSymptomlbl;
        private System.Windows.Forms.Label patientMedecinelbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addPat;
        private System.Windows.Forms.Button deletePat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button printDocument;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}