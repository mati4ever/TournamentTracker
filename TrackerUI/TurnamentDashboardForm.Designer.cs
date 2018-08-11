namespace TrackerUI
{
    partial class TurnamentDashboardForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTurnamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.headerLabel.Location = new System.Drawing.Point(120, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(420, 54);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Turnament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(129, 130);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(426, 36);
            this.loadExistingTournamentDropDown.TabIndex = 15;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(169, 86);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(337, 38);
            this.loadExistingTournamentLabel.TabIndex = 14;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadTournamentButton.Location = new System.Drawing.Point(207, 200);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(260, 48);
            this.loadTournamentButton.TabIndex = 16;
            this.loadTournamentButton.TabStop = false;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTurnamentButton
            // 
            this.createTurnamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTurnamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTurnamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTurnamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTurnamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createTurnamentButton.Location = new System.Drawing.Point(206, 282);
            this.createTurnamentButton.Name = "createTurnamentButton";
            this.createTurnamentButton.Size = new System.Drawing.Size(262, 85);
            this.createTurnamentButton.TabIndex = 17;
            this.createTurnamentButton.Text = "Create Tournament";
            this.createTurnamentButton.UseVisualStyleBackColor = true;
            // 
            // TurnamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 414);
            this.Controls.Add(this.createTurnamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TurnamentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Turnament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTurnamentButton;
    }
}