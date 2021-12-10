
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DoctorExit = new System.Windows.Forms.Button();
            this.DoctorInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoctorLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AptDelete = new System.Windows.Forms.Button();
            this.AptUpdate = new System.Windows.Forms.Button();
            this.AptAdd = new System.Windows.Forms.Button();
            this.PatientDelete = new System.Windows.Forms.Button();
            this.PatientUpdate = new System.Windows.Forms.Button();
            this.PatientAdd = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PatientId = new System.Windows.Forms.ColumnHeader();
            this.PatientName = new System.Windows.Forms.ColumnHeader();
            this.PatientSurname = new System.Windows.Forms.ColumnHeader();
            this.PatientNumber = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DoctorEdit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.DoctorInfo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 64);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-1, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1406, 64);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.DoctorEdit);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.DoctorExit);
            this.panel3.Controls.Add(this.DoctorInfo);
            this.panel3.Controls.Add(this.DoctorLabel);
            this.panel3.Location = new System.Drawing.Point(1, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 606);
            this.panel3.TabIndex = 3;
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(28, 562);
            this.DoctorExit.Name = "DoctorExit";
            this.DoctorExit.Size = new System.Drawing.Size(244, 38);
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
            this.DoctorInfo.Location = new System.Drawing.Point(11, 146);
            this.DoctorInfo.Name = "DoctorInfo";
            this.DoctorInfo.Size = new System.Drawing.Size(288, 41);
            this.DoctorInfo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Surgeon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saitama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Speciality:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dr:";
            // 
            // DoctorLabel
            // 
            this.DoctorLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.DoctorLabel.Location = new System.Drawing.Point(15, 21);
            this.DoctorLabel.Name = "DoctorLabel";
            this.DoctorLabel.Size = new System.Drawing.Size(284, 88);
            this.DoctorLabel.TabIndex = 0;
            this.DoctorLabel.Text = "Doctor Panel";
            this.DoctorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.AptDelete);
            this.panel4.Controls.Add(this.AptUpdate);
            this.panel4.Controls.Add(this.AptAdd);
            this.panel4.Controls.Add(this.PatientDelete);
            this.panel4.Controls.Add(this.PatientUpdate);
            this.panel4.Controls.Add(this.PatientAdd);
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(313, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 606);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // AptDelete
            // 
            this.AptDelete.Location = new System.Drawing.Point(982, 562);
            this.AptDelete.Name = "AptDelete";
            this.AptDelete.Size = new System.Drawing.Size(94, 29);
            this.AptDelete.TabIndex = 10;
            this.AptDelete.Text = "Delete";
            this.AptDelete.UseVisualStyleBackColor = true;
            // 
            // AptUpdate
            // 
            this.AptUpdate.Location = new System.Drawing.Point(492, 562);
            this.AptUpdate.Name = "AptUpdate";
            this.AptUpdate.Size = new System.Drawing.Size(94, 29);
            this.AptUpdate.TabIndex = 9;
            this.AptUpdate.Text = "Update";
            this.AptUpdate.UseVisualStyleBackColor = true;
            // 
            // AptAdd
            // 
            this.AptAdd.Location = new System.Drawing.Point(26, 562);
            this.AptAdd.Name = "AptAdd";
            this.AptAdd.Size = new System.Drawing.Size(94, 29);
            this.AptAdd.TabIndex = 8;
            this.AptAdd.Text = "Add";
            this.AptAdd.UseVisualStyleBackColor = true;
            // 
            // PatientDelete
            // 
            this.PatientDelete.Location = new System.Drawing.Point(982, 256);
            this.PatientDelete.Name = "PatientDelete";
            this.PatientDelete.Size = new System.Drawing.Size(94, 29);
            this.PatientDelete.TabIndex = 7;
            this.PatientDelete.Text = "Delete";
            this.PatientDelete.UseVisualStyleBackColor = true;
            // 
            // PatientUpdate
            // 
            this.PatientUpdate.Location = new System.Drawing.Point(492, 256);
            this.PatientUpdate.Name = "PatientUpdate";
            this.PatientUpdate.Size = new System.Drawing.Size(94, 29);
            this.PatientUpdate.TabIndex = 6;
            this.PatientUpdate.Text = "Update";
            this.PatientUpdate.UseVisualStyleBackColor = true;
            // 
            // PatientAdd
            // 
            this.PatientAdd.Location = new System.Drawing.Point(26, 256);
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(94, 29);
            this.PatientAdd.TabIndex = 5;
            this.PatientAdd.Text = "Add";
            this.PatientAdd.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
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
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Patient ID";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientId,
            this.PatientName,
            this.PatientSurname,
            this.PatientNumber,
            this.Status});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1050, 177);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PatientId
            // 
            this.PatientId.Text = "ID";
            this.PatientId.Width = 200;
            // 
            // PatientName
            // 
            this.PatientName.Text = "Name";
            this.PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientName.Width = 200;
            // 
            // PatientSurname
            // 
            this.PatientSurname.Text = "Surname";
            this.PatientSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientSurname.Width = 200;
            // 
            // PatientNumber
            // 
            this.PatientNumber.Text = "Phone Number";
            this.PatientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatientNumber.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 200;
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(11, 184);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 37);
            this.panel5.TabIndex = 4;
            // 
            // DoctorEdit
            // 
            this.DoctorEdit.Location = new System.Drawing.Point(48, 256);
            this.DoctorEdit.Name = "DoctorEdit";
            this.DoctorEdit.Size = new System.Drawing.Size(201, 45);
            this.DoctorEdit.TabIndex = 11;
            this.DoctorEdit.Text = "Edit Personal Info";
            this.DoctorEdit.UseVisualStyleBackColor = true;
            // 
            // DoctorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1407, 734);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Panel";
            this.Load += new System.EventHandler(this.DoctorPanel_Load);
            this.panel3.ResumeLayout(false);
            this.DoctorInfo.ResumeLayout(false);
            this.DoctorInfo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.Button AptUpdate;
        private System.Windows.Forms.Button AptAdd;
        private System.Windows.Forms.Button PatientDelete;
        private System.Windows.Forms.Button PatientUpdate;
        private System.Windows.Forms.Button PatientAdd;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AptDelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader PatientId;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader PatientSurname;
        private System.Windows.Forms.ColumnHeader PatientNumber;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button DoctorEdit;
        private System.Windows.Forms.Panel panel5;
    }
}