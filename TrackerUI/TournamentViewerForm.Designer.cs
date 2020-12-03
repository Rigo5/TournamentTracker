namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.roundeLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.ScoreTeamOneText = new System.Windows.Forms.TextBox();
            this.ScoreTeamTwoTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTeamTwoLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(124, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TournamentName.Location = new System.Drawing.Point(182, 9);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(88, 30);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // roundeLabel
            // 
            this.roundeLabel.AutoSize = true;
            this.roundeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roundeLabel.Location = new System.Drawing.Point(13, 58);
            this.roundeLabel.Name = "roundeLabel";
            this.roundeLabel.Size = new System.Drawing.Size(52, 20);
            this.roundeLabel.TabIndex = 2;
            this.roundeLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(108, 54);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(265, 29);
            this.roundDropDown.TabIndex = 3;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(108, 104);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(159, 34);
            this.UnplayedOnlyCheckBox.TabIndex = 4;
            this.UnplayedOnlyCheckBox.Text = "UnplayedOnly";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListBox
            // 
            this.MatchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListBox.FormattingEnabled = true;
            this.MatchupListBox.ItemHeight = 30;
            this.MatchupListBox.Location = new System.Drawing.Point(17, 167);
            this.MatchupListBox.Name = "MatchupListBox";
            this.MatchupListBox.Size = new System.Drawing.Size(263, 152);
            this.MatchupListBox.TabIndex = 5;
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneNameLabel.Location = new System.Drawing.Point(328, 167);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(72, 20);
            this.teamOneNameLabel.TabIndex = 6;
            this.teamOneNameLabel.Text = "TeamOne";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(328, 209);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(109, 20);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "ScoreTeamOne";
            // 
            // ScoreTeamOneText
            // 
            this.ScoreTeamOneText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeamOneText.Location = new System.Drawing.Point(465, 198);
            this.ScoreTeamOneText.Name = "ScoreTeamOneText";
            this.ScoreTeamOneText.Size = new System.Drawing.Size(139, 27);
            this.ScoreTeamOneText.TabIndex = 8;
            // 
            // ScoreTeamTwoTextBox
            // 
            this.ScoreTeamTwoTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeamTwoTextBox.Location = new System.Drawing.Point(465, 290);
            this.ScoreTeamTwoTextBox.Name = "ScoreTeamTwoTextBox";
            this.ScoreTeamTwoTextBox.Size = new System.Drawing.Size(139, 27);
            this.ScoreTeamTwoTextBox.TabIndex = 11;
            // 
            // ScoreTeamTwoLabel
            // 
            this.ScoreTeamTwoLabel.AutoSize = true;
            this.ScoreTeamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeamTwoLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ScoreTeamTwoLabel.Location = new System.Drawing.Point(328, 297);
            this.ScoreTeamTwoLabel.Name = "ScoreTeamTwoLabel";
            this.ScoreTeamTwoLabel.Size = new System.Drawing.Size(109, 20);
            this.ScoreTeamTwoLabel.TabIndex = 10;
            this.ScoreTeamTwoLabel.Text = "ScoreTeamTwo";
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TeamTwoLabel.Location = new System.Drawing.Point(328, 255);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(72, 20);
            this.TeamTwoLabel.TabIndex = 9;
            this.TeamTwoLabel.Text = "TeamTwo";
            // 
            // Scorebutton
            // 
            this.Scorebutton.Location = new System.Drawing.Point(616, 241);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(138, 43);
            this.Scorebutton.TabIndex = 12;
            this.Scorebutton.Text = "Score";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 383);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.ScoreTeamTwoTextBox);
            this.Controls.Add(this.ScoreTeamTwoLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.ScoreTeamOneText);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.MatchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundeLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label roundeLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchupListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox ScoreTeamOneText;
        private System.Windows.Forms.TextBox ScoreTeamTwoTextBox;
        private System.Windows.Forms.Label ScoreTeamTwoLabel;
        private System.Windows.Forms.Label TeamTwoLabel;
        private System.Windows.Forms.Button Scorebutton;
    }
}

