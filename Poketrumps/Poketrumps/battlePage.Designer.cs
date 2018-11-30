namespace Poketrumps
{
    partial class battlePage
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
            this.grdAiTeam = new System.Windows.Forms.DataGridView();
            this.grdTrainerTeam = new System.Windows.Forms.DataGridView();
            this.txtAI = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnChoosePokemon = new System.Windows.Forms.Button();
            this.txtBattleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAiTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainerTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAiTeam
            // 
            this.grdAiTeam.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.grdAiTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAiTeam.Location = new System.Drawing.Point(81, 50);
            this.grdAiTeam.Name = "grdAiTeam";
            this.grdAiTeam.RowTemplate.Height = 50;
            this.grdAiTeam.Size = new System.Drawing.Size(921, 266);
            this.grdAiTeam.TabIndex = 2;
            // 
            // grdTrainerTeam
            // 
            this.grdTrainerTeam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grdTrainerTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrainerTeam.Location = new System.Drawing.Point(81, 387);
            this.grdTrainerTeam.Name = "grdTrainerTeam";
            this.grdTrainerTeam.RowTemplate.Height = 50;
            this.grdTrainerTeam.Size = new System.Drawing.Size(921, 266);
            this.grdTrainerTeam.TabIndex = 3;
            // 
            // txtAI
            // 
            this.txtAI.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtAI.Location = new System.Drawing.Point(1008, 185);
            this.txtAI.Name = "txtAI";
            this.txtAI.ReadOnly = true;
            this.txtAI.Size = new System.Drawing.Size(100, 20);
            this.txtAI.TabIndex = 4;
            this.txtAI.Text = "AI";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(1008, 506);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 5;
            // 
            // btnChoosePokemon
            // 
            this.btnChoosePokemon.Location = new System.Drawing.Point(491, 718);
            this.btnChoosePokemon.Name = "btnChoosePokemon";
            this.btnChoosePokemon.Size = new System.Drawing.Size(118, 23);
            this.btnChoosePokemon.TabIndex = 6;
            this.btnChoosePokemon.Text = "Select Pokemon";
            this.btnChoosePokemon.UseVisualStyleBackColor = true;
            this.btnChoosePokemon.Click += new System.EventHandler(this.btnChoosePokemon_Click);
            // 
            // txtBattleID
            // 
            this.txtBattleID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtBattleID.Location = new System.Drawing.Point(491, 24);
            this.txtBattleID.Name = "txtBattleID";
            this.txtBattleID.ReadOnly = true;
            this.txtBattleID.Size = new System.Drawing.Size(100, 20);
            this.txtBattleID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "battle ID";
            // 
            // battlePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBattleID);
            this.Controls.Add(this.btnChoosePokemon);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtAI);
            this.Controls.Add(this.grdTrainerTeam);
            this.Controls.Add(this.grdAiTeam);
            this.Name = "battlePage";
            this.Text = "battlePage";
            ((System.ComponentModel.ISupportInitialize)(this.grdAiTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrainerTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAI;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnChoosePokemon;
        private System.Windows.Forms.TextBox txtBattleID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView grdAiTeam;
        public System.Windows.Forms.DataGridView grdTrainerTeam;
    }
}