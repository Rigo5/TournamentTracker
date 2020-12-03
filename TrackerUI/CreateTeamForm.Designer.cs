namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.AddTeamMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmailAddressValue = new System.Windows.Forms.TextBox();
            this.PhoneNumberValue = new System.Windows.Forms.TextBox();
            this.TeamMebersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameValue.Location = new System.Drawing.Point(20, 125);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(298, 27);
            this.TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TeamNameLabel.Location = new System.Drawing.Point(16, 82);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(89, 20);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamLabel.Location = new System.Drawing.Point(15, 24);
            this.CreateTeamLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(128, 30);
            this.CreateTeamLabel.TabIndex = 11;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // AddTeamMemberButton
            // 
            this.AddTeamMemberButton.Location = new System.Drawing.Point(22, 265);
            this.AddTeamMemberButton.Name = "AddTeamMemberButton";
            this.AddTeamMemberButton.Size = new System.Drawing.Size(145, 43);
            this.AddTeamMemberButton.TabIndex = 20;
            this.AddTeamMemberButton.Text = "Add Team Member";
            this.AddTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(22, 207);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(298, 29);
            this.SelectTeamDropDown.TabIndex = 19;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(18, 175);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(149, 20);
            this.SelectTeamMemberLabel.TabIndex = 18;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.PhoneNumberValue);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailAddressValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.AddPersonButton);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.PhoneNumberLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailAddressLabel);
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(20, 335);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(568, 269);
            this.AddNewMemberGroupBox.TabIndex = 21;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(408, 106);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(138, 43);
            this.AddPersonButton.TabIndex = 28;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.Location = new System.Drawing.Point(136, 106);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(213, 27);
            this.LastNameValue.TabIndex = 27;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(14, 207);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.PhoneNumberLabel.TabIndex = 26;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EmailAddressLabel.Location = new System.Drawing.Point(13, 155);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(103, 20);
            this.EmailAddressLabel.TabIndex = 25;
            this.EmailAddressLabel.Text = "Email Address";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.Location = new System.Drawing.Point(136, 54);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(213, 27);
            this.FirstNameValue.TabIndex = 24;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LastNameLabel.Location = new System.Drawing.Point(14, 106);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.LastNameLabel.TabIndex = 23;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 54);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.FirstNameLabel.TabIndex = 22;
            this.FirstNameLabel.Text = "First Name";
            // 
            // EmailAddressValue
            // 
            this.EmailAddressValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressValue.Location = new System.Drawing.Point(136, 155);
            this.EmailAddressValue.Name = "EmailAddressValue";
            this.EmailAddressValue.Size = new System.Drawing.Size(213, 27);
            this.EmailAddressValue.TabIndex = 29;
            // 
            // PhoneNumberValue
            // 
            this.PhoneNumberValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberValue.Location = new System.Drawing.Point(136, 204);
            this.PhoneNumberValue.Name = "PhoneNumberValue";
            this.PhoneNumberValue.Size = new System.Drawing.Size(213, 27);
            this.PhoneNumberValue.TabIndex = 30;
            // 
            // TeamMebersListBox
            // 
            this.TeamMebersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMebersListBox.FormattingEnabled = true;
            this.TeamMebersListBox.ItemHeight = 20;
            this.TeamMebersListBox.Location = new System.Drawing.Point(352, 82);
            this.TeamMebersListBox.Name = "TeamMebersListBox";
            this.TeamMebersListBox.Size = new System.Drawing.Size(263, 242);
            this.TeamMebersListBox.TabIndex = 23;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(189, 265);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(129, 43);
            this.DeleteSelectedMemberButton.TabIndex = 24;
            this.DeleteSelectedMemberButton.Text = "Delete Selected ";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(387, 21);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(228, 43);
            this.CreateTeamButton.TabIndex = 25;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 630);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMebersListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.AddTeamMemberButton);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.Button AddTeamMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.TextBox PhoneNumberValue;
        private System.Windows.Forms.TextBox EmailAddressValue;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.ListBox TeamMebersListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}