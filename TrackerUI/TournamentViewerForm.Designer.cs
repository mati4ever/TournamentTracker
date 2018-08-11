namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentnameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedOnluCheckBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneNameLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.versusLabel = new System.Windows.Forms.Label();
            this.addScoreButton = new System.Windows.Forms.Button();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(12, 31);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(248, 54);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            // 
            // tournamentnameLabel
            // 
            this.tournamentnameLabel.AutoSize = true;
            this.tournamentnameLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tournamentnameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tournamentnameLabel.Location = new System.Drawing.Point(245, 31);
            this.tournamentnameLabel.Name = "tournamentnameLabel";
            this.tournamentnameLabel.Size = new System.Drawing.Size(167, 54);
            this.tournamentnameLabel.TabIndex = 0;
            this.tournamentnameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roundLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.roundLabel.Location = new System.Drawing.Point(14, 109);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(98, 38);
            this.roundLabel.TabIndex = 1;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(118, 109);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(218, 36);
            this.roundDropDown.TabIndex = 2;
            // 
            // unplayedOnluCheckBox
            // 
            this.unplayedOnluCheckBox.AutoSize = true;
            this.unplayedOnluCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnluCheckBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unplayedOnluCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.unplayedOnluCheckBox.Location = new System.Drawing.Point(118, 151);
            this.unplayedOnluCheckBox.Name = "unplayedOnluCheckBox";
            this.unplayedOnluCheckBox.Size = new System.Drawing.Size(218, 42);
            this.unplayedOnluCheckBox.TabIndex = 3;
            this.unplayedOnluCheckBox.Text = "Unplayed Only";
            this.unplayedOnluCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 28;
            this.matchupListBox.Location = new System.Drawing.Point(21, 220);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(315, 394);
            this.matchupListBox.TabIndex = 4;
            // 
            // teamOneNameLabel
            // 
            this.teamOneNameLabel.AutoSize = true;
            this.teamOneNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneNameLabel.Location = new System.Drawing.Point(386, 220);
            this.teamOneNameLabel.Name = "teamOneNameLabel";
            this.teamOneNameLabel.Size = new System.Drawing.Size(172, 38);
            this.teamOneNameLabel.TabIndex = 1;
            this.teamOneNameLabel.Text = "<team one>";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoNameLabel.Location = new System.Drawing.Point(386, 386);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(170, 38);
            this.teamTwoNameLabel.TabIndex = 1;
            this.teamTwoNameLabel.Text = "<team two>";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(386, 437);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamTwoScoreLabel.TabIndex = 1;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoScoreValueTextBox
            // 
            this.teamTwoScoreValueTextBox.Location = new System.Drawing.Point(478, 441);
            this.teamTwoScoreValueTextBox.Name = "teamTwoScoreValueTextBox";
            this.teamTwoScoreValueTextBox.Size = new System.Drawing.Size(100, 34);
            this.teamTwoScoreValueTextBox.TabIndex = 5;
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.versusLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.versusLabel.Location = new System.Drawing.Point(442, 334);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(74, 38);
            this.versusLabel.TabIndex = 1;
            this.versusLabel.Text = "-VS-";
            // 
            // addScoreButton
            // 
            this.addScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addScoreButton.Location = new System.Drawing.Point(414, 516);
            this.addScoreButton.Name = "addScoreButton";
            this.addScoreButton.Size = new System.Drawing.Size(142, 55);
            this.addScoreButton.TabIndex = 6;
            this.addScoreButton.Text = "Add Score";
            this.addScoreButton.UseVisualStyleBackColor = true;
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.teamOneScoreLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(386, 271);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(86, 38);
            this.teamOneScoreLabel.TabIndex = 1;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValueTextBox
            // 
            this.teamOneScoreValueTextBox.Location = new System.Drawing.Point(478, 275);
            this.teamOneScoreValueTextBox.Name = "teamOneScoreValueTextBox";
            this.teamOneScoreValueTextBox.Size = new System.Drawing.Size(100, 34);
            this.teamOneScoreValueTextBox.TabIndex = 5;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 659);
            this.Controls.Add(this.addScoreButton);
            this.Controls.Add(this.teamTwoScoreValueTextBox);
            this.Controls.Add(this.teamOneScoreValueTextBox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnluCheckBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamOneNameLabel);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentnameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentnameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedOnluCheckBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneNameLabel;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamTwoScoreValueTextBox;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button addScoreButton;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValueTextBox;
    }
}

