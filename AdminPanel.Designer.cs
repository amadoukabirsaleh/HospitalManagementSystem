
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.PatientId = new System.Windows.Forms.ColumnHeader();
            this.PatientName = new System.Windows.Forms.ColumnHeader();
            this.PatientSurname = new System.Windows.Forms.ColumnHeader();
            this.PatientNumber = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
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
            this.AdminLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoctorInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // AptDelete
            // 
            this.AptDelete.Location = new System.Drawing.Point(859, 422);
            this.AptDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AptDelete.Name = "AptDelete";
            this.AptDelete.Size = new System.Drawing.Size(82, 22);
            this.AptDelete.TabIndex = 10;
            this.AptDelete.Text = "Delete";
            this.AptDelete.UseVisualStyleBackColor = true;
            // 
            // AptUpdate
            // 
            this.AptUpdate.Location = new System.Drawing.Point(430, 422);
            this.AptUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AptUpdate.Name = "AptUpdate";
            this.AptUpdate.Size = new System.Drawing.Size(82, 22);
            this.AptUpdate.TabIndex = 9;
            this.AptUpdate.Text = "Update";
            this.AptUpdate.UseVisualStyleBackColor = true;
            this.AptUpdate.Click += new System.EventHandler(this.AptUpdate_Click);
            // 
            // AptAdd
            // 
            this.AptAdd.Location = new System.Drawing.Point(23, 422);
            this.AptAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AptAdd.Name = "AptAdd";
            this.AptAdd.Size = new System.Drawing.Size(82, 22);
            this.AptAdd.TabIndex = 8;
            this.AptAdd.Text = "Add";
            this.AptAdd.UseVisualStyleBackColor = true;
            this.AptAdd.Click += new System.EventHandler(this.AptAdd_Click);
            // 
            // PatientAdd
            // 
            this.PatientAdd.Location = new System.Drawing.Point(23, 192);
            this.PatientAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientAdd.Name = "PatientAdd";
            this.PatientAdd.Size = new System.Drawing.Size(82, 22);
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
            this.listView2.Location = new System.Drawing.Point(23, 267);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(919, 146);
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
            this.label3.Location = new System.Drawing.Point(373, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointment List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PatientUpdate
            // 
            this.PatientUpdate.Location = new System.Drawing.Point(430, 192);
            this.PatientUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientUpdate.Name = "PatientUpdate";
            this.PatientUpdate.Size = new System.Drawing.Size(82, 22);
            this.PatientUpdate.TabIndex = 6;
            this.PatientUpdate.Text = "Update";
            this.PatientUpdate.UseVisualStyleBackColor = true;
            this.PatientUpdate.Click += new System.EventHandler(this.PatientUpdate_Click);
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
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(919, 134);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PatientId
            // 
            this.PatientId.Text = "ID";
            this.PatientId.Width = 150;
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
            this.Status.Width = 165;
            // 
            // PatientDelete
            // 
            this.PatientDelete.Location = new System.Drawing.Point(859, 192);
            this.PatientDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PatientDelete.Name = "PatientDelete";
            this.PatientDelete.Size = new System.Drawing.Size(82, 22);
            this.PatientDelete.TabIndex = 7;
            this.PatientDelete.Text = "Delete";
            this.PatientDelete.UseVisualStyleBackColor = true;
            this.PatientDelete.Click += new System.EventHandler(this.PatientDelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(389, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saitama";
            // 
            // DoctorExit
            // 
            this.DoctorExit.Location = new System.Drawing.Point(24, 422);
            this.DoctorExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorExit.Name = "DoctorExit";
            this.DoctorExit.Size = new System.Drawing.Size(214, 28);
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
            this.DoctorInfo.Location = new System.Drawing.Point(10, 110);
            this.DoctorInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorInfo.Name = "DoctorInfo";
            this.DoctorInfo.Size = new System.Drawing.Size(252, 31);
            this.DoctorInfo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Position:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Admin";
            // 
            // DoctorEdit
            // 
            this.DoctorEdit.Location = new System.Drawing.Point(42, 192);
            this.DoctorEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoctorEdit.Name = "DoctorEdit";
            this.DoctorEdit.Size = new System.Drawing.Size(176, 34);
            this.DoctorEdit.TabIndex = 11;
            this.DoctorEdit.Text = "See the Doctor List";
            this.DoctorEdit.UseVisualStyleBackColor = true;
            this.DoctorEdit.Click += new System.EventHandler(this.DoctorEdit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(10, 138);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 28);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.DoctorEdit);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.DoctorExit);
            this.panel3.Controls.Add(this.DoctorInfo);
            this.panel3.Controls.Add(this.AdminLabel);
            this.panel3.Location = new System.Drawing.Point(2, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 454);
            this.panel3.TabIndex = 7;
            // 
            // AdminLabel
            // 
            this.AdminLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AdminLabel.Location = new System.Drawing.Point(13, 16);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(248, 66);
            this.AdminLabel.TabIndex = 0;
            this.AdminLabel.Text = "Admin Panel";
            this.AdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 48);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 48);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
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
            this.panel4.Location = new System.Drawing.Point(275, 48);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(956, 454);
            this.panel4.TabIndex = 8;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.DoctorInfo.ResumeLayout(false);
            this.DoctorInfo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PatientId;
        private System.Windows.Forms.ColumnHeader PatientName;
        private System.Windows.Forms.ColumnHeader PatientSurname;
        private System.Windows.Forms.ColumnHeader PatientNumber;
        private System.Windows.Forms.ColumnHeader Status;
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
    }
}