namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.CreateTournamentLabel = new System.Windows.Forms.Label();
            this.TournamentNamValue = new System.Windows.Forms.TextBox();
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.EntryFeeLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayerslabel = new System.Windows.Forms.Label();
            this.DeleteSelectedTeamsButton = new System.Windows.Forms.Button();
            this.DeleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.Prizeslabel = new System.Windows.Forms.Label();
            this.PrizeListBox = new System.Windows.Forms.ListBox();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTournamentLabel
            // 
            this.CreateTournamentLabel.AutoSize = true;
            this.CreateTournamentLabel.Location = new System.Drawing.Point(15, 21);
            this.CreateTournamentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreateTournamentLabel.Name = "CreateTournamentLabel";
            this.CreateTournamentLabel.Size = new System.Drawing.Size(190, 30);
            this.CreateTournamentLabel.TabIndex = 0;
            this.CreateTournamentLabel.Text = "Create Tournament";
            this.CreateTournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentNamValue
            // 
            this.TournamentNamValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentNamValue.Location = new System.Drawing.Point(20, 122);
            this.TournamentNamValue.Name = "TournamentNamValue";
            this.TournamentNamValue.Size = new System.Drawing.Size(298, 27);
            this.TournamentNamValue.TabIndex = 10;
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TournamentLabel.Location = new System.Drawing.Point(16, 79);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(132, 20);
            this.TournamentLabel.TabIndex = 9;
            this.TournamentLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeValue.Location = new System.Drawing.Point(103, 182);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(77, 27);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            this.EntryFeeLabel.AutoSize = true;
            this.EntryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EntryFeeLabel.Location = new System.Drawing.Point(16, 182);
            this.EntryFeeLabel.Name = "EntryFeeLabel";
            this.EntryFeeLabel.Size = new System.Drawing.Size(69, 20);
            this.EntryFeeLabel.TabIndex = 11;
            this.EntryFeeLabel.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(20, 274);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(298, 29);
            this.SelectTeamDropDown.TabIndex = 14;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectTeamLabel.Location = new System.Drawing.Point(16, 242);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(89, 20);
            this.SelectTeamLabel.TabIndex = 13;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewLinkLabel
            // 
            this.CreateNewLinkLabel.AutoSize = true;
            this.CreateNewLinkLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewLinkLabel.Location = new System.Drawing.Point(233, 242);
            this.CreateNewLinkLabel.Name = "CreateNewLinkLabel";
            this.CreateNewLinkLabel.Size = new System.Drawing.Size(85, 20);
            this.CreateNewLinkLabel.TabIndex = 16;
            this.CreateNewLinkLabel.TabStop = true;
            this.CreateNewLinkLabel.Text = "create new ";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Location = new System.Drawing.Point(20, 345);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(138, 43);
            this.AddTeamButton.TabIndex = 17;
            this.AddTeamButton.Text = "AddTeam";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.Location = new System.Drawing.Point(20, 427);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(138, 43);
            this.CreatePrizeButton.TabIndex = 18;
            this.CreatePrizeButton.Text = "CreatePrize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 30;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(412, 120);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(263, 152);
            this.TournamentPlayersListBox.TabIndex = 19;
            // 
            // TournamentPlayerslabel
            // 
            this.TournamentPlayerslabel.AutoSize = true;
            this.TournamentPlayerslabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayerslabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TournamentPlayerslabel.Location = new System.Drawing.Point(408, 79);
            this.TournamentPlayerslabel.Name = "TournamentPlayerslabel";
            this.TournamentPlayerslabel.Size = new System.Drawing.Size(142, 20);
            this.TournamentPlayerslabel.TabIndex = 20;
            this.TournamentPlayerslabel.Text = "Tournament Players ";
            // 
            // DeleteSelectedTeamsButton
            // 
            this.DeleteSelectedTeamsButton.Location = new System.Drawing.Point(701, 173);
            this.DeleteSelectedTeamsButton.Name = "DeleteSelectedTeamsButton";
            this.DeleteSelectedTeamsButton.Size = new System.Drawing.Size(108, 43);
            this.DeleteSelectedTeamsButton.TabIndex = 21;
            this.DeleteSelectedTeamsButton.Text = "Delete";
            this.DeleteSelectedTeamsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            this.DeleteSelectedPrizeButton.Location = new System.Drawing.Point(701, 398);
            this.DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            this.DeleteSelectedPrizeButton.Size = new System.Drawing.Size(108, 43);
            this.DeleteSelectedPrizeButton.TabIndex = 24;
            this.DeleteSelectedPrizeButton.Text = "Delete";
            this.DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // Prizeslabel
            // 
            this.Prizeslabel.AutoSize = true;
            this.Prizeslabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prizeslabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Prizeslabel.Location = new System.Drawing.Point(408, 300);
            this.Prizeslabel.Name = "Prizeslabel";
            this.Prizeslabel.Size = new System.Drawing.Size(130, 20);
            this.Prizeslabel.TabIndex = 23;
            this.Prizeslabel.Text = "Tournament Prizes";
            // 
            // PrizeListBox
            // 
            this.PrizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizeListBox.FormattingEnabled = true;
            this.PrizeListBox.ItemHeight = 30;
            this.PrizeListBox.Location = new System.Drawing.Point(412, 334);
            this.PrizeListBox.Name = "PrizeListBox";
            this.PrizeListBox.Size = new System.Drawing.Size(263, 152);
            this.PrizeListBox.TabIndex = 22;
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.Location = new System.Drawing.Point(596, 21);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(138, 43);
            this.CreateTournamentbutton.TabIndex = 25;
            this.CreateTournamentbutton.Text = "CreateTournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 516);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.DeleteSelectedPrizeButton);
            this.Controls.Add(this.Prizeslabel);
            this.Controls.Add(this.PrizeListBox);
            this.Controls.Add(this.DeleteSelectedTeamsButton);
            this.Controls.Add(this.TournamentPlayerslabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewLinkLabel);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.EntryFeeLabel);
            this.Controls.Add(this.TournamentNamValue);
            this.Controls.Add(this.TournamentLabel);
            this.Controls.Add(this.CreateTournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Tournament Prizes";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreateTournamentLabel;
        private System.Windows.Forms.TextBox TournamentNamValue;
        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label EntryFeeLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewLinkLabel;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayerslabel;
        private System.Windows.Forms.Button DeleteSelectedTeamsButton;
        private System.Windows.Forms.Button DeleteSelectedPrizeButton;
        private System.Windows.Forms.Label Prizeslabel;
        private System.Windows.Forms.ListBox PrizeListBox;
        private System.Windows.Forms.Button CreateTournamentbutton;
    }
}