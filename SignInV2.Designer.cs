
namespace HospitalManagementSystem
{
    partial class SignInV2
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
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.exitLink = new System.Windows.Forms.LinkLabel();
            this.signinButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // showPass
            // 
            this.showPass.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.Location = new System.Drawing.Point(72, 219);
            this.showPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(116, 17);
            this.showPass.TabIndex = 21;
            this.showPass.Text = "Show Password";
            this.showPass.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showPass.UseVisualStyleBackColor = true;
            // 
            // forgotPass
            // 
            this.forgotPass.BackColor = System.Drawing.Color.OldLace;
            this.forgotPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.forgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgotPass.LinkColor = System.Drawing.Color.Black;
            this.forgotPass.Location = new System.Drawing.Point(61, 257);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(147, 22);
            this.forgotPass.TabIndex = 20;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Forgotten Password?";
            this.forgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLink
            // 
            this.exitLink.AutoSize = true;
            this.exitLink.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.exitLink.LinkColor = System.Drawing.Color.Black;
            this.exitLink.Location = new System.Drawing.Point(232, 331);
            this.exitLink.Name = "exitLink";
            this.exitLink.Size = new System.Drawing.Size(30, 19);
            this.exitLink.TabIndex = 19;
            this.exitLink.TabStop = true;
            this.exitLink.Text = "Exit";
            this.exitLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitLink_LinkClicked);
            // 
            // signinButton
            // 
            this.signinButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signinButton.Location = new System.Drawing.Point(61, 293);
            this.signinButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signinButton.Name = "signinButton";
            this.signinButton.Size = new System.Drawing.Size(155, 34);
            this.signinButton.TabIndex = 18;
            this.signinButton.Text = "Sign In";
            this.signinButton.UseVisualStyleBackColor = true;
            this.signinButton.Click += new System.EventHandler(this.signinButton_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(46, 193);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(171, 23);
            this.Password.TabIndex = 17;
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(46, 135);
            this.uName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uName.Multiline = true;
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(171, 23);
            this.uName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Username:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(88, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Get Started";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 48);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 48);
            this.panel1.TabIndex = 11;
            // 
            // SignInV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(262, 398);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.forgotPass);
            this.Controls.Add(this.exitLink);
            this.Controls.Add(this.signinButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.LinkLabel exitLink;
        private System.Windows.Forms.Button signinButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}