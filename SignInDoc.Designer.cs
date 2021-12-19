
namespace HospitalManagementSystem
{
    partial class SignInDoc
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
            this.showPass = new System.Windows.Forms.CheckBox();
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.exitLink = new System.Windows.Forms.LinkLabel();
            this.signinButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 64);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // showPass
            // 
            this.showPass.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.Location = new System.Drawing.Point(77, 291);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(133, 23);
            this.showPass.TabIndex = 19;
            this.showPass.Text = "Show Password";
            this.showPass.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // forgotPass
            // 
            this.forgotPass.BackColor = System.Drawing.Color.SkyBlue;
            this.forgotPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPass.LinkColor = System.Drawing.Color.Black;
            this.forgotPass.Location = new System.Drawing.Point(65, 341);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(168, 29);
            this.forgotPass.TabIndex = 18;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Forgotten Password?";
            this.forgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPass_LinkClicked);
            // 
            // exitLink
            // 
            this.exitLink.AutoSize = true;
            this.exitLink.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitLink.LinkColor = System.Drawing.Color.Black;
            this.exitLink.Location = new System.Drawing.Point(260, 440);
            this.exitLink.Name = "exitLink";
            this.exitLink.Size = new System.Drawing.Size(37, 23);
            this.exitLink.TabIndex = 17;
            this.exitLink.TabStop = true;
            this.exitLink.Text = "Exit";
            this.exitLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLink_LinkClicked);
            // 
            // signinButton
            // 
            this.signinButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinButton.Location = new System.Drawing.Point(65, 389);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(177, 45);
            this.signinButton.TabIndex = 16;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(48, 256);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(195, 29);
            this.Password.TabIndex = 15;
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(48, 179);
            this.uName.Multiline = true;
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(195, 29);
            this.uName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(96, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(96, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 61);
            this.label1.TabIndex = 11;
            this.label1.Text = "Get Started";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 64);
            this.panel2.TabIndex = 2;
            // 
            // SignInDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.forgotPass);
            this.Controls.Add(this.exitLink);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInDoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.LinkLabel exitLink;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}