namespace TrackerUI
{
    partial class TournamentDashBoard
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
            this.TournamentDashLabel = new System.Windows.Forms.Label();
            this.SelectTournamentDown = new System.Windows.Forms.ComboBox();
            this.SelectTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashLabel
            // 
            this.TournamentDashLabel.AutoSize = true;
            this.TournamentDashLabel.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.TournamentDashLabel.Location = new System.Drawing.Point(102, 9);
            this.TournamentDashLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TournamentDashLabel.Name = "TournamentDashLabel";
            this.TournamentDashLabel.Size = new System.Drawing.Size(235, 38);
            this.TournamentDashLabel.TabIndex = 13;
            this.TournamentDashLabel.Text = "Tournament Dash";
            // 
            // SelectTournamentDown
            // 
            this.SelectTournamentDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTournamentDown.FormattingEnabled = true;
            this.SelectTournamentDown.Location = new System.Drawing.Point(65, 98);
            this.SelectTournamentDown.Name = "SelectTournamentDown";
            this.SelectTournamentDown.Size = new System.Drawing.Size(298, 29);
            this.SelectTournamentDown.TabIndex = 21;
            // 
            // SelectTournamentLabel
            // 
            this.SelectTournamentLabel.AutoSize = true;
            this.SelectTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.SelectTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectTournamentLabel.Location = new System.Drawing.Point(119, 65);
            this.SelectTournamentLabel.Name = "SelectTournamentLabel";
            this.SelectTournamentLabel.Size = new System.Drawing.Size(193, 30);
            this.SelectTournamentLabel.TabIndex = 20;
            this.SelectTournamentLabel.Text = "Select Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.Location = new System.Drawing.Point(139, 154);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(145, 43);
            this.LoadTournamentButton.TabIndex = 22;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.Location = new System.Drawing.Point(109, 231);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(206, 67);
            this.CreateTournamentButton.TabIndex = 23;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 347);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.SelectTournamentDown);
            this.Controls.Add(this.SelectTournamentLabel);
            this.Controls.Add(this.TournamentDashLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentDashBoard";
            this.Text = "Tournament DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashLabel;
        private System.Windows.Forms.ComboBox SelectTournamentDown;
        private System.Windows.Forms.Label SelectTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}