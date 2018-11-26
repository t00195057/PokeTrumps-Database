namespace Poketrumps
{
    partial class Form1
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
            this.btnDisplayCreateAccount = new System.Windows.Forms.Button();
            this.btnDisplayLogin = new System.Windows.Forms.Button();
            this.grdCreateAccount = new System.Windows.Forms.GroupBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.grdLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernamePassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.grdCreateAccount.SuspendLayout();
            this.grdLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplayCreateAccount
            // 
            this.btnDisplayCreateAccount.Location = new System.Drawing.Point(51, 101);
            this.btnDisplayCreateAccount.Name = "btnDisplayCreateAccount";
            this.btnDisplayCreateAccount.Size = new System.Drawing.Size(127, 23);
            this.btnDisplayCreateAccount.TabIndex = 0;
            this.btnDisplayCreateAccount.Text = "Create Account";
            this.btnDisplayCreateAccount.UseVisualStyleBackColor = true;
            this.btnDisplayCreateAccount.Click += new System.EventHandler(this.btnDisplayCreateAccount_Click);
            // 
            // btnDisplayLogin
            // 
            this.btnDisplayLogin.Location = new System.Drawing.Point(391, 101);
            this.btnDisplayLogin.Name = "btnDisplayLogin";
            this.btnDisplayLogin.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayLogin.TabIndex = 1;
            this.btnDisplayLogin.Text = "Login";
            this.btnDisplayLogin.UseVisualStyleBackColor = true;
            this.btnDisplayLogin.Click += new System.EventHandler(this.btnDisplayLogin_Click);
            // 
            // grdCreateAccount
            // 
            this.grdCreateAccount.Controls.Add(this.btnCreateAccount);
            this.grdCreateAccount.Controls.Add(this.lblEmail);
            this.grdCreateAccount.Controls.Add(this.lblPassword);
            this.grdCreateAccount.Controls.Add(this.lblUsername);
            this.grdCreateAccount.Controls.Add(this.textBox2);
            this.grdCreateAccount.Controls.Add(this.textBox1);
            this.grdCreateAccount.Controls.Add(this.txt);
            this.grdCreateAccount.Location = new System.Drawing.Point(51, 147);
            this.grdCreateAccount.Name = "grdCreateAccount";
            this.grdCreateAccount.Size = new System.Drawing.Size(296, 269);
            this.grdCreateAccount.TabIndex = 2;
            this.grdCreateAccount.TabStop = false;
            this.grdCreateAccount.Text = "Create Account";
            this.grdCreateAccount.Visible = false;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(87, 227);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(94, 23);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 64);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(162, 64);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 0;
            // 
            // grdLogin
            // 
            this.grdLogin.Controls.Add(this.btnLogin);
            this.grdLogin.Controls.Add(this.label1);
            this.grdLogin.Controls.Add(this.label2);
            this.grdLogin.Controls.Add(this.txtUsernamePassword);
            this.grdLogin.Controls.Add(this.txtLoginUsername);
            this.grdLogin.Location = new System.Drawing.Point(391, 147);
            this.grdLogin.Name = "grdLogin";
            this.grdLogin.Size = new System.Drawing.Size(296, 269);
            this.grdLogin.TabIndex = 3;
            this.grdLogin.TabStop = false;
            this.grdLogin.Text = "Login";
            this.grdLogin.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(83, 227);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // txtUsernamePassword
            // 
            this.txtUsernamePassword.Location = new System.Drawing.Point(151, 124);
            this.txtUsernamePassword.Name = "txtUsernamePassword";
            this.txtUsernamePassword.Size = new System.Drawing.Size(100, 20);
            this.txtUsernamePassword.TabIndex = 7;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(151, 64);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.grdLogin);
            this.Controls.Add(this.grdCreateAccount);
            this.Controls.Add(this.btnDisplayLogin);
            this.Controls.Add(this.btnDisplayCreateAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grdCreateAccount.ResumeLayout(false);
            this.grdCreateAccount.PerformLayout();
            this.grdLogin.ResumeLayout(false);
            this.grdLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayCreateAccount;
        private System.Windows.Forms.Button btnDisplayLogin;
        private System.Windows.Forms.GroupBox grdCreateAccount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.GroupBox grdLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernamePassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
    }
}

