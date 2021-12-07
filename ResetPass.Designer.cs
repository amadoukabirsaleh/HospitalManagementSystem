
namespace HospitalManagementSystem
{
    partial class ResetPass
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
            this.showPass = new System.Windows.Forms.CheckBox();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.resetButton = new System.Windows.Forms.Button();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.PatientId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.Location = new System.Drawing.Point(89, 331);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(133, 23);
            this.showPass.TabIndex = 21;
            this.showPass.Text = "Show Password";
            this.showPass.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.BackColor = System.Drawing.Color.SkyBlue;
            this.backLink.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.backLink.LinkColor = System.Drawing.Color.Black;
            this.backLink.Location = new System.Drawing.Point(183, 441);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(114, 23);
            this.backLink.TabIndex = 19;
            this.backLink.TabStop = true;
            this.backLink.Text = "Back To Login";
            this.backLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetButton.Location = new System.Drawing.Point(51, 370);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(196, 45);
            this.resetButton.TabIndex = 18;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(50, 218);
            this.NewPass.Multiline = true;
            this.NewPass.Name = "NewPass";
            this.NewPass.PasswordChar = '•';
            this.NewPass.Size = new System.Drawing.Size(195, 29);
            this.NewPass.TabIndex = 17;
            this.NewPass.TextChanged += new System.EventHandler(this.NewPass_TextChanged);
            // 
            // PatientId
            // 
            this.PatientId.Location = new System.Drawing.Point(50, 150);
            this.PatientId.Multiline = true;
            this.PatientId.Name = "PatientId";
            this.PatientId.Size = new System.Drawing.Size(195, 29);
            this.PatientId.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(98, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "PatientID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "New Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 62);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reset Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 467);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 64);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 64);
            this.panel1.TabIndex = 11;
            // 
            // ConfPass
            // 
            this.ConfPass.Location = new System.Drawing.Point(51, 289);
            this.ConfPass.Multiline = true;
            this.ConfPass.Name = "ConfPass";
            this.ConfPass.PasswordChar = '•';
            this.ConfPass.Size = new System.Drawing.Size(195, 36);
            this.ConfPass.TabIndex = 23;
            this.ConfPass.TextChanged += new System.EventHandler(this.ConfPass_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(75, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Confirm Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(300, 530);
            this.Controls.Add(this.ConfPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.PatientId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.LinkLabel backLink;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox PatientId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ConfPass;
        private System.Windows.Forms.Label label4;
    }
}