namespace TournamentTrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TorunamentLabel = new System.Windows.Forms.Label();
            this.TournamentValueLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundcomboBox = new System.Windows.Forms.ComboBox();
            this.UnplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchUpListBox = new System.Windows.Forms.ListBox();
            this.TeamOneLabel = new System.Windows.Forms.Label();
            this.TeamTwoLabel = new System.Windows.Forms.Label();
            this.ScoreTeamTwoLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.MatchUpVersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TorunamentLabel
            // 
            this.TorunamentLabel.AutoSize = true;
            this.TorunamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TorunamentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TorunamentLabel.Location = new System.Drawing.Point(15, 18);
            this.TorunamentLabel.Name = "TorunamentLabel";
            this.TorunamentLabel.Size = new System.Drawing.Size(139, 32);
            this.TorunamentLabel.TabIndex = 1;
            this.TorunamentLabel.Text = "Tournament:";
            // 
            // TournamentValueLabel
            // 
            this.TournamentValueLabel.AutoSize = true;
            this.TournamentValueLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentValueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TournamentValueLabel.Location = new System.Drawing.Point(148, 18);
            this.TournamentValueLabel.Name = "TournamentValueLabel";
            this.TournamentValueLabel.Size = new System.Drawing.Size(98, 32);
            this.TournamentValueLabel.TabIndex = 2;
            this.TournamentValueLabel.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoundLabel.Location = new System.Drawing.Point(25, 64);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(89, 32);
            this.RoundLabel.TabIndex = 3;
            this.RoundLabel.Text = "Round:";
            // 
            // RoundcomboBox
            // 
            this.RoundcomboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundcomboBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RoundcomboBox.FormattingEnabled = true;
            this.RoundcomboBox.Location = new System.Drawing.Point(143, 63);
            this.RoundcomboBox.Name = "RoundcomboBox";
            this.RoundcomboBox.Size = new System.Drawing.Size(181, 33);
            this.RoundcomboBox.TabIndex = 4;
            // 
            // UnplayedOnlyCheckBox
            // 
            this.UnplayedOnlyCheckBox.AutoSize = true;
            this.UnplayedOnlyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UnplayedOnlyCheckBox.Location = new System.Drawing.Point(143, 105);
            this.UnplayedOnlyCheckBox.Name = "UnplayedOnlyCheckBox";
            this.UnplayedOnlyCheckBox.Size = new System.Drawing.Size(152, 29);
            this.UnplayedOnlyCheckBox.TabIndex = 6;
            this.UnplayedOnlyCheckBox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchUpListBox
            // 
            this.MatchUpListBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchUpListBox.FormattingEnabled = true;
            this.MatchUpListBox.ItemHeight = 25;
            this.MatchUpListBox.Location = new System.Drawing.Point(20, 145);
            this.MatchUpListBox.Name = "MatchUpListBox";
            this.MatchUpListBox.Size = new System.Drawing.Size(304, 254);
            this.MatchUpListBox.TabIndex = 7;
            // 
            // TeamOneLabel
            // 
            this.TeamOneLabel.AutoSize = true;
            this.TeamOneLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamOneLabel.Location = new System.Drawing.Point(349, 177);
            this.TeamOneLabel.Name = "TeamOneLabel";
            this.TeamOneLabel.Size = new System.Drawing.Size(122, 25);
            this.TeamOneLabel.TabIndex = 8;
            this.TeamOneLabel.Text = "<Team One>";
            // 
            // TeamTwoLabel
            // 
            this.TeamTwoLabel.AutoSize = true;
            this.TeamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamTwoLabel.Location = new System.Drawing.Point(349, 315);
            this.TeamTwoLabel.Name = "TeamTwoLabel";
            this.TeamTwoLabel.Size = new System.Drawing.Size(121, 25);
            this.TeamTwoLabel.TabIndex = 12;
            this.TeamTwoLabel.Text = "<Team Two>";
            // 
            // ScoreTeamTwoLabel
            // 
            this.ScoreTeamTwoLabel.AutoSize = true;
            this.ScoreTeamTwoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeamTwoLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ScoreTeamTwoLabel.Location = new System.Drawing.Point(349, 343);
            this.ScoreTeamTwoLabel.Name = "ScoreTeamTwoLabel";
            this.ScoreTeamTwoLabel.Size = new System.Drawing.Size(59, 25);
            this.ScoreTeamTwoLabel.TabIndex = 14;
            this.ScoreTeamTwoLabel.Text = "Score";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(349, 209);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(59, 25);
            this.TeamOneScoreLabel.TabIndex = 15;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(418, 205);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(90, 35);
            this.TeamOneScoreTextBox.TabIndex = 16;
            // 
            // TeamTwoScoreTextBox
            // 
            this.TeamTwoScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreTextBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TeamTwoScoreTextBox.Location = new System.Drawing.Point(418, 343);
            this.TeamTwoScoreTextBox.Name = "TeamTwoScoreTextBox";
            this.TeamTwoScoreTextBox.Size = new System.Drawing.Size(90, 33);
            this.TeamTwoScoreTextBox.TabIndex = 17;
            // 
            // MatchUpVersusLabel
            // 
            this.MatchUpVersusLabel.AutoSize = true;
            this.MatchUpVersusLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchUpVersusLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MatchUpVersusLabel.Location = new System.Drawing.Point(413, 267);
            this.MatchUpVersusLabel.Name = "MatchUpVersusLabel";
            this.MatchUpVersusLabel.Size = new System.Drawing.Size(50, 25);
            this.MatchUpVersusLabel.TabIndex = 18;
            this.MatchUpVersusLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ScoreButton.Location = new System.Drawing.Point(535, 267);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(88, 38);
            this.ScoreButton.TabIndex = 19;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 417);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.MatchUpVersusLabel);
            this.Controls.Add(this.TeamTwoScoreTextBox);
            this.Controls.Add(this.TeamOneScoreTextBox);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.ScoreTeamTwoLabel);
            this.Controls.Add(this.TeamTwoLabel);
            this.Controls.Add(this.TeamOneLabel);
            this.Controls.Add(this.MatchUpListBox);
            this.Controls.Add(this.UnplayedOnlyCheckBox);
            this.Controls.Add(this.RoundcomboBox);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentValueLabel);
            this.Controls.Add(this.TorunamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TorunamentLabel;
        private System.Windows.Forms.Label TournamentValueLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundcomboBox;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckBox;
        private System.Windows.Forms.ListBox MatchUpListBox;
        private System.Windows.Forms.Label TeamOneLabel;
        private System.Windows.Forms.Label TeamTwoLabel;
        private System.Windows.Forms.Label ScoreTeamTwoLabel;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreTextBox;
        private System.Windows.Forms.TextBox TeamTwoScoreTextBox;
        private System.Windows.Forms.Label MatchUpVersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

