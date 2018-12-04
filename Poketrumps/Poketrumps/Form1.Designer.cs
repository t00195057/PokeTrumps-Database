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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.grdLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grdCreateAccount.SuspendLayout();
            this.grdLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.grdCreateAccount.Controls.Add(this.txtEmail);
            this.grdCreateAccount.Controls.Add(this.txtPassword);
            this.grdCreateAccount.Controls.Add(this.txtUsername);
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
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 178);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(162, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(162, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // grdLogin
            // 
            this.grdLogin.Controls.Add(this.btnLogin);
            this.grdLogin.Controls.Add(this.label1);
            this.grdLogin.Controls.Add(this.label2);
            this.grdLogin.Controls.Add(this.txtLoginPassword);
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
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(151, 124);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.txtLoginPassword.TabIndex = 7;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(151, 64);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.txtLoginUsername.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(512, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(99, 74);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox grdLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

