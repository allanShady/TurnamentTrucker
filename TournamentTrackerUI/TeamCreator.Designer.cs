namespace TournamentTrackerUI
{
    partial class TeamCreator
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
            this.TeamNameTextBox = new System.Windows.Forms.TextBox();
            this.CreateTeamLabel = new System.Windows.Forms.Label();
            this.SelectMemberComboBox = new System.Windows.Forms.ComboBox();
            this.SelectMemberLabel = new System.Windows.Forms.Label();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.CellPhoneTextBox = new System.Windows.Forms.TextBox();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMemberListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameTextBox
            // 
            this.TeamNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameTextBox.Location = new System.Drawing.Point(18, 86);
            this.TeamNameTextBox.Multiline = true;
            this.TeamNameTextBox.Name = "TeamNameTextBox";
            this.TeamNameTextBox.Size = new System.Drawing.Size(292, 29);
            this.TeamNameTextBox.TabIndex = 9;
            // 
            // CreateTeamLabel
            // 
            this.CreateTeamLabel.AutoSize = true;
            this.CreateTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTeamLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateTeamLabel.Name = "CreateTeamLabel";
            this.CreateTeamLabel.Size = new System.Drawing.Size(140, 32);
            this.CreateTeamLabel.TabIndex = 8;
            this.CreateTeamLabel.Text = "Create Team";
            // 
            // SelectMemberComboBox
            // 
            this.SelectMemberComboBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMemberComboBox.FormattingEnabled = true;
            this.SelectMemberComboBox.Location = new System.Drawing.Point(17, 147);
            this.SelectMemberComboBox.Name = "SelectMemberComboBox";
            this.SelectMemberComboBox.Size = new System.Drawing.Size(292, 33);
            this.SelectMemberComboBox.TabIndex = 11;
            // 
            // SelectMemberLabel
            // 
            this.SelectMemberLabel.AutoSize = true;
            this.SelectMemberLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMemberLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SelectMemberLabel.Location = new System.Drawing.Point(12, 118);
            this.SelectMemberLabel.Name = "SelectMemberLabel";
            this.SelectMemberLabel.Size = new System.Drawing.Size(138, 25);
            this.SelectMemberLabel.TabIndex = 10;
            this.SelectMemberLabel.Text = "Select Member";
            this.SelectMemberLabel.UseWaitCursor = true;
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddMemberButton.Location = new System.Drawing.Point(89, 186);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(124, 28);
            this.AddMemberButton.TabIndex = 21;
            this.AddMemberButton.Text = "Add Member";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            this.AddMemberButton.Click += new System.EventHandler(this.AddMemberButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateMemberButton);
            this.groupBox1.Controls.Add(this.CellPhoneTextBox);
            this.groupBox1.Controls.Add(this.CellPhoneLabel);
            this.groupBox1.Controls.Add(this.EmailTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.LastNameLabel);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Controls.Add(this.FirstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(17, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 250);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateMemberButton.Location = new System.Drawing.Point(71, 209);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(147, 28);
            this.CreateMemberButton.TabIndex = 29;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // CellPhoneTextBox
            // 
            this.CellPhoneTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellPhoneTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CellPhoneTextBox.Location = new System.Drawing.Point(114, 160);
            this.CellPhoneTextBox.Name = "CellPhoneTextBox";
            this.CellPhoneTextBox.Size = new System.Drawing.Size(163, 33);
            this.CellPhoneTextBox.TabIndex = 28;
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CellPhoneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CellPhoneLabel.Location = new System.Drawing.Point(8, 160);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(98, 25);
            this.CellPhoneLabel.TabIndex = 27;
            this.CellPhoneLabel.Text = "Cellphone";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EmailTextBox.Location = new System.Drawing.Point(114, 114);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(163, 33);
            this.EmailTextBox.TabIndex = 26;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LastNameTextBox.Location = new System.Drawing.Point(114, 74);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(163, 33);
            this.LastNameTextBox.TabIndex = 25;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EmailLabel.Location = new System.Drawing.Point(8, 114);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(58, 25);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LastNameLabel.Location = new System.Drawing.Point(8, 77);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(100, 25);
            this.LastNameLabel.TabIndex = 19;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FirstNameTextBox.Location = new System.Drawing.Point(114, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(163, 33);
            this.FirstNameTextBox.TabIndex = 18;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 38);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(102, 25);
            this.FirstNameLabel.TabIndex = 17;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMemberListBox
            // 
            this.TeamMemberListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMemberListBox.FormattingEnabled = true;
            this.TeamMemberListBox.ItemHeight = 30;
            this.TeamMemberListBox.Location = new System.Drawing.Point(337, 86);
            this.TeamMemberListBox.Name = "TeamMemberListBox";
            this.TeamMemberListBox.Size = new System.Drawing.Size(260, 394);
            this.TeamMemberListBox.TabIndex = 24;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(603, 268);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(84, 54);
            this.DeleteSelectedMemberButton.TabIndex = 26;
            this.DeleteSelectedMemberButton.Text = "Remove Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedMemberButton.Click += new System.EventHandler(this.DeleteSelectedMemberButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTeamButton.Location = new System.Drawing.Point(256, 503);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(147, 32);
            this.CreateTeamButton.TabIndex = 30;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamNameLabel.Location = new System.Drawing.Point(13, 57);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(108, 25);
            this.TeamNameLabel.TabIndex = 31;
            this.TeamNameLabel.Text = "Team name";
            // 
            // TeamCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 50F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 547);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMemberListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddMemberButton);
            this.Controls.Add(this.SelectMemberComboBox);
            this.Controls.Add(this.SelectMemberLabel);
            this.Controls.Add(this.TeamNameTextBox);
            this.Controls.Add(this.CreateTeamLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.Name = "TeamCreator";
            this.Text = "TeamCreator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameTextBox;
        private System.Windows.Forms.Label CreateTeamLabel;
        private System.Windows.Forms.ComboBox SelectMemberComboBox;
        private System.Windows.Forms.Label SelectMemberLabel;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox CellPhoneTextBox;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox TeamMemberListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.Label TeamNameLabel;
    }
}