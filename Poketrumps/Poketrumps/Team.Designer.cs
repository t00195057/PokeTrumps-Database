namespace Poketrumps
{
    partial class Team
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
            this.grdCollection = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grdTeam = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCollection
            // 
            this.grdCollection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grdCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCollection.Location = new System.Drawing.Point(23, 218);
            this.grdCollection.Name = "grdCollection";
            this.grdCollection.RowTemplate.Height = 50;
            this.grdCollection.Size = new System.Drawing.Size(921, 161);
            this.grdCollection.TabIndex = 1;

            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(897, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // grdTeam
            // 
            this.grdTeam.BackgroundColor = System.Drawing.Color.Red;
            this.grdTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTeam.Location = new System.Drawing.Point(23, 43);
            this.grdTeam.Name = "grdTeam";
            this.grdTeam.RowTemplate.Height = 50;
            this.grdTeam.Size = new System.Drawing.Size(921, 150);
            this.grdTeam.TabIndex = 3;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdTeam);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.grdCollection);
            this.Name = "Team";
            this.Text = "Team";
            ((System.ComponentModel.ISupportInitialize)(this.grdCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCollection;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView grdTeam;
        private System.Windows.Forms.Button button1;
    }
}