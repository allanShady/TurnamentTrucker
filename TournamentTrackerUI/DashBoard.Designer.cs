namespace TournamentTrackerUI
{
    partial class DashBoard
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
            this.TournamentDashBoardLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.LoadExistingTournamentComboBox = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashBoardLabel
            // 
            this.TournamentDashBoardLabel.AutoSize = true;
            this.TournamentDashBoardLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentDashBoardLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentDashBoardLabel.Location = new System.Drawing.Point(47, 32);
            this.TournamentDashBoardLabel.Name = "TournamentDashBoardLabel";
            this.TournamentDashBoardLabel.Size = new System.Drawing.Size(250, 32);
            this.TournamentDashBoardLabel.TabIndex = 31;
            this.TournamentDashBoardLabel.Text = "Tournament DashBoard";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadTournamentButton.Location = new System.Drawing.Point(77, 169);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(171, 32);
            this.LoadTournamentButton.TabIndex = 34;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // LoadExistingTournamentComboBox
            // 
            this.LoadExistingTournamentComboBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentComboBox.FormattingEnabled = true;
            this.LoadExistingTournamentComboBox.Location = new System.Drawing.Point(37, 120);
            this.LoadExistingTournamentComboBox.Name = "LoadExistingTournamentComboBox";
            this.LoadExistingTournamentComboBox.Size = new System.Drawing.Size(250, 33);
            this.LoadExistingTournamentComboBox.TabIndex = 33;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(48, 91);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(229, 25);
            this.LoadExistingTournamentLabel.TabIndex = 32;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.LoadExistingTournamentLabel.UseWaitCursor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateTournamentButton.Location = new System.Drawing.Point(53, 218);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(208, 49);
            this.CreateTournamentButton.TabIndex = 35;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournantsDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 287);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingTournamentComboBox);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.TournamentDashBoardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "TournantsDashBoard";
            this.Text = "TournantsDashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashBoardLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.ComboBox LoadExistingTournamentComboBox;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}