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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashBoard));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExcistingTournamentLabel = new System.Windows.Forms.Label();
            this.loadExcistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.BackColor = System.Drawing.Color.White;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(44, 37);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(385, 50);
            this.tournamentDashboardLabel.TabIndex = 6;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExcistingTournamentLabel
            // 
            this.loadExcistingTournamentLabel.AutoSize = true;
            this.loadExcistingTournamentLabel.BackColor = System.Drawing.Color.White;
            this.loadExcistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExcistingTournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadExcistingTournamentLabel.Location = new System.Drawing.Point(105, 144);
            this.loadExcistingTournamentLabel.Name = "loadExcistingTournamentLabel";
            this.loadExcistingTournamentLabel.Size = new System.Drawing.Size(262, 30);
            this.loadExcistingTournamentLabel.TabIndex = 9;
            this.loadExcistingTournamentLabel.Text = "Load Excisting Tournament";
            // 
            // loadExcistingTournamentDropDown
            // 
            this.loadExcistingTournamentDropDown.FormattingEnabled = true;
            this.loadExcistingTournamentDropDown.Location = new System.Drawing.Point(114, 177);
            this.loadExcistingTournamentDropDown.Name = "loadExcistingTournamentDropDown";
            this.loadExcistingTournamentDropDown.Size = new System.Drawing.Size(244, 38);
            this.loadExcistingTournamentDropDown.TabIndex = 10;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.loadTournamentButton.Location = new System.Drawing.Point(153, 235);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(166, 32);
            this.loadTournamentButton.TabIndex = 21;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournament
            // 
            this.createTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournament.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.createTournament.Location = new System.Drawing.Point(121, 273);
            this.createTournament.Name = "createTournament";
            this.createTournament.Size = new System.Drawing.Size(231, 56);
            this.createTournament.TabIndex = 22;
            this.createTournament.Text = "Create Tournament";
            this.createTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 352);
            this.Controls.Add(this.createTournament);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExcistingTournamentDropDown);
            this.Controls.Add(this.loadExcistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashBoard";
            this.Text = "Tournament Dash Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Label loadExcistingTournamentLabel;
        private System.Windows.Forms.ComboBox loadExcistingTournamentDropDown;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournament;
    }
}