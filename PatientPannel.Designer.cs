
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addPat = new System.Windows.Forms.Button();
            this.deletePat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 125);
            this.panel1.TabIndex = 0;
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // patID
            // 
            this.patID.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patID.BackColor = System.Drawing.Color.Gainsboro;
            this.patID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patID.Location = new System.Drawing.Point(81, 146);
            this.patID.Name = "patID";
            this.patID.Size = new System.Drawing.Size(209, 26);
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
            this.patName.Location = new System.Drawing.Point(80, 191);
            this.patName.Name = "patName";
            this.patName.Size = new System.Drawing.Size(209, 26);
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
            this.patAddress.Location = new System.Drawing.Point(80, 239);
            this.patAddress.Name = "patAddress";
            this.patAddress.Size = new System.Drawing.Size(209, 26);
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
            this.patPhone.Location = new System.Drawing.Point(80, 282);
            this.patPhone.Name = "patPhone";
            this.patPhone.Size = new System.Drawing.Size(209, 26);
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
            this.patAge.Location = new System.Drawing.Point(80, 331);
            this.patAge.Name = "patAge";
            this.patAge.Size = new System.Drawing.Size(209, 26);
            this.patAge.TabIndex = 6;
            this.patAge.Text = "PATIENT AGE";
            this.patAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.patAge.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // patGender
            // 
            this.patGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patGender.FormattingEnabled = true;
            this.patGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.patGender.Location = new System.Drawing.Point(80, 375);
            this.patGender.Name = "patGender";
            this.patGender.Size = new System.Drawing.Size(208, 29);
            this.patGender.TabIndex = 7;
            this.patGender.Text = "Gender";
            this.patGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.patBloodGroup.Location = new System.Drawing.Point(80, 425);
            this.patBloodGroup.Name = "patBloodGroup";
            this.patBloodGroup.Size = new System.Drawing.Size(208, 29);
            this.patBloodGroup.TabIndex = 8;
            this.patBloodGroup.Text = "BloodGroup";
            this.patBloodGroup.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // patDisease
            // 
            this.patDisease.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.patDisease.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.patDisease.BackColor = System.Drawing.Color.Gainsboro;
            this.patDisease.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.patDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patDisease.Location = new System.Drawing.Point(81, 474);
            this.patDisease.Name = "patDisease";
            this.patDisease.Size = new System.Drawing.Size(209, 26);
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
            this.updatePat.Location = new System.Drawing.Point(30, 556);
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
            this.button2.Location = new System.Drawing.Point(141, 556);
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
            this.button3.Location = new System.Drawing.Point(278, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(411, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 402);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(387, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 33);
            this.label10.TabIndex = 9;
            this.label10.Text = "KBU Hospital";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(281, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(404, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(734, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(442, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "MEDECINES";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(442, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "DIAGNOSIS";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(120, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "SYMPTOMS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(92, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "PATIENT NAME";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(296, 38);
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
            this.addPat.Location = new System.Drawing.Point(97, 619);
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
            this.deletePat.Location = new System.Drawing.Point(208, 619);
            this.deletePat.Name = "deletePat";
            this.deletePat.Size = new System.Drawing.Size(105, 46);
            this.deletePat.TabIndex = 16;
            this.deletePat.Text = "Delete";
            this.deletePat.UseVisualStyleBackColor = false;
            // 
            // PatientPannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1471, 719);
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
            this.Text = "PatientPannel";
            this.Load += new System.EventHandler(this.PatientPannel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addPat;
        private System.Windows.Forms.Button deletePat;
    }
}