namespace MechaArchives
{
    partial class d_formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(d_formMain));
            this.d_toolstrip = new System.Windows.Forms.ToolStrip();
            this.d_uploadButton = new System.Windows.Forms.ToolStripButton();
            this.d_toolSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.d_pullButton = new System.Windows.Forms.ToolStripButton();
            this.d_toolSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.d_githubLink = new System.Windows.Forms.ToolStripLabel();
            this.d_teamBox = new System.Windows.Forms.GroupBox();
            this.d_allTeamPanel = new System.Windows.Forms.Panel();
            this.d_filterTeamBox = new System.Windows.Forms.GroupBox();
            this.d_boxRefillsAuto = new System.Windows.Forms.CheckBox();
            this.d_boxShootsAuto = new System.Windows.Forms.CheckBox();
            this.d_boxHasAuto = new System.Windows.Forms.CheckBox();
            this.d_autoAbilityLabel = new System.Windows.Forms.Label();
            this.d_boxHeight = new System.Windows.Forms.CheckBox();
            this.d_maxHeight = new System.Windows.Forms.NumericUpDown();
            this.d_dashLabel = new System.Windows.Forms.Label();
            this.d_heightLabel = new System.Windows.Forms.Label();
            this.d_minHeight = new System.Windows.Forms.NumericUpDown();
            this.d_applyFilterButton = new System.Windows.Forms.Button();
            this.d_filterTeamsPanel = new System.Windows.Forms.Panel();
            this.d_toolstrip.SuspendLayout();
            this.d_teamBox.SuspendLayout();
            this.d_filterTeamBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_maxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_minHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // d_toolstrip
            // 
            this.d_toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.d_uploadButton,
            this.d_toolSeparator1,
            this.d_pullButton,
            this.d_toolSeparator2,
            this.toolStripButton1,
            this.d_githubLink});
            this.d_toolstrip.Location = new System.Drawing.Point(0, 0);
            this.d_toolstrip.Name = "d_toolstrip";
            this.d_toolstrip.Size = new System.Drawing.Size(926, 25);
            this.d_toolstrip.TabIndex = 3;
            this.d_toolstrip.Text = "toolStrip1";
            // 
            // d_uploadButton
            // 
            this.d_uploadButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.d_uploadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.d_uploadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.d_uploadButton.Image = ((System.Drawing.Image)(resources.GetObject("d_uploadButton.Image")));
            this.d_uploadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.d_uploadButton.Name = "d_uploadButton";
            this.d_uploadButton.Size = new System.Drawing.Size(111, 22);
            this.d_uploadButton.Text = "Upload Robot Data";
            this.d_uploadButton.ToolTipText = "Upload data about a team\'s robot";
            this.d_uploadButton.Click += new System.EventHandler(this.AddRobotData);
            // 
            // d_toolSeparator1
            // 
            this.d_toolSeparator1.ForeColor = System.Drawing.SystemColors.Control;
            this.d_toolSeparator1.Name = "d_toolSeparator1";
            this.d_toolSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // d_pullButton
            // 
            this.d_pullButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.d_pullButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.d_pullButton.Image = ((System.Drawing.Image)(resources.GetObject("d_pullButton.Image")));
            this.d_pullButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.d_pullButton.Name = "d_pullButton";
            this.d_pullButton.Size = new System.Drawing.Size(93, 22);
            this.d_pullButton.Text = "Pull Robot Data";
            this.d_pullButton.ToolTipText = "Pull data for a specific team\'s robot";
            this.d_pullButton.Click += new System.EventHandler(this.PullTeamData);
            // 
            // d_toolSeparator2
            // 
            this.d_toolSeparator2.ForeColor = System.Drawing.SystemColors.Control;
            this.d_toolSeparator2.Name = "d_toolSeparator2";
            this.d_toolSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(111, 22);
            this.toolStripButton1.Text = "Update Robot Data";
            this.toolStripButton1.ToolTipText = "Pull data for a specific team\'s robot";
            // 
            // d_githubLink
            // 
            this.d_githubLink.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.d_githubLink.BackColor = System.Drawing.SystemColors.Control;
            this.d_githubLink.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_githubLink.ForeColor = System.Drawing.Color.Blue;
            this.d_githubLink.Name = "d_githubLink";
            this.d_githubLink.Size = new System.Drawing.Size(89, 22);
            this.d_githubLink.Text = "View My Github Page";
            this.d_githubLink.Click += new System.EventHandler(this.openGithubPage);
            // 
            // d_teamBox
            // 
            this.d_teamBox.Controls.Add(this.d_allTeamPanel);
            this.d_teamBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_teamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_teamBox.Location = new System.Drawing.Point(726, 25);
            this.d_teamBox.Name = "d_teamBox";
            this.d_teamBox.Size = new System.Drawing.Size(200, 586);
            this.d_teamBox.TabIndex = 2;
            this.d_teamBox.TabStop = false;
            this.d_teamBox.Text = "Available Teams By Ranking Points";
            // 
            // d_allTeamPanel
            // 
            this.d_allTeamPanel.AutoScroll = true;
            this.d_allTeamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_allTeamPanel.Location = new System.Drawing.Point(3, 16);
            this.d_allTeamPanel.Name = "d_allTeamPanel";
            this.d_allTeamPanel.Size = new System.Drawing.Size(194, 567);
            this.d_allTeamPanel.TabIndex = 0;
            // 
            // d_filterTeamBox
            // 
            this.d_filterTeamBox.Controls.Add(this.d_boxRefillsAuto);
            this.d_filterTeamBox.Controls.Add(this.d_boxShootsAuto);
            this.d_filterTeamBox.Controls.Add(this.d_boxHasAuto);
            this.d_filterTeamBox.Controls.Add(this.d_autoAbilityLabel);
            this.d_filterTeamBox.Controls.Add(this.d_boxHeight);
            this.d_filterTeamBox.Controls.Add(this.d_maxHeight);
            this.d_filterTeamBox.Controls.Add(this.d_dashLabel);
            this.d_filterTeamBox.Controls.Add(this.d_heightLabel);
            this.d_filterTeamBox.Controls.Add(this.d_minHeight);
            this.d_filterTeamBox.Controls.Add(this.d_applyFilterButton);
            this.d_filterTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_filterTeamBox.Location = new System.Drawing.Point(378, 25);
            this.d_filterTeamBox.Name = "d_filterTeamBox";
            this.d_filterTeamBox.Size = new System.Drawing.Size(342, 305);
            this.d_filterTeamBox.TabIndex = 1;
            this.d_filterTeamBox.TabStop = false;
            this.d_filterTeamBox.Text = "Filter Teams";
            // 
            // d_boxRefillsAuto
            // 
            this.d_boxRefillsAuto.AutoSize = true;
            this.d_boxRefillsAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_boxRefillsAuto.Location = new System.Drawing.Point(9, 145);
            this.d_boxRefillsAuto.Name = "d_boxRefillsAuto";
            this.d_boxRefillsAuto.Size = new System.Drawing.Size(91, 17);
            this.d_boxRefillsAuto.TabIndex = 9;
            this.d_boxRefillsAuto.Text = "Refills In Auto";
            this.d_boxRefillsAuto.UseVisualStyleBackColor = true;
            // 
            // d_boxShootsAuto
            // 
            this.d_boxShootsAuto.AutoSize = true;
            this.d_boxShootsAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_boxShootsAuto.Location = new System.Drawing.Point(9, 119);
            this.d_boxShootsAuto.Name = "d_boxShootsAuto";
            this.d_boxShootsAuto.Size = new System.Drawing.Size(96, 17);
            this.d_boxShootsAuto.TabIndex = 8;
            this.d_boxShootsAuto.Text = "Shoots In Auto";
            this.d_boxShootsAuto.UseVisualStyleBackColor = true;
            // 
            // d_boxHasAuto
            // 
            this.d_boxHasAuto.AutoSize = true;
            this.d_boxHasAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_boxHasAuto.Location = new System.Drawing.Point(9, 93);
            this.d_boxHasAuto.Name = "d_boxHasAuto";
            this.d_boxHasAuto.Size = new System.Drawing.Size(107, 17);
            this.d_boxHasAuto.TabIndex = 7;
            this.d_boxHasAuto.Text = "Has Autonomous";
            this.d_boxHasAuto.UseVisualStyleBackColor = true;
            // 
            // d_autoAbilityLabel
            // 
            this.d_autoAbilityLabel.AutoSize = true;
            this.d_autoAbilityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_autoAbilityLabel.Location = new System.Drawing.Point(28, 70);
            this.d_autoAbilityLabel.Name = "d_autoAbilityLabel";
            this.d_autoAbilityLabel.Size = new System.Drawing.Size(122, 13);
            this.d_autoAbilityLabel.TabIndex = 6;
            this.d_autoAbilityLabel.Text = "Autonomous Capabilities";
            // 
            // d_boxHeight
            // 
            this.d_boxHeight.AutoSize = true;
            this.d_boxHeight.Location = new System.Drawing.Point(9, 35);
            this.d_boxHeight.Name = "d_boxHeight";
            this.d_boxHeight.Size = new System.Drawing.Size(15, 14);
            this.d_boxHeight.TabIndex = 5;
            this.d_boxHeight.UseVisualStyleBackColor = true;
            // 
            // d_maxHeight
            // 
            this.d_maxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_maxHeight.Location = new System.Drawing.Point(94, 35);
            this.d_maxHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.d_maxHeight.Name = "d_maxHeight";
            this.d_maxHeight.Size = new System.Drawing.Size(39, 20);
            this.d_maxHeight.TabIndex = 4;
            // 
            // d_dashLabel
            // 
            this.d_dashLabel.AutoSize = true;
            this.d_dashLabel.Location = new System.Drawing.Point(76, 35);
            this.d_dashLabel.Name = "d_dashLabel";
            this.d_dashLabel.Size = new System.Drawing.Size(12, 16);
            this.d_dashLabel.TabIndex = 3;
            this.d_dashLabel.Text = "-";
            // 
            // d_heightLabel
            // 
            this.d_heightLabel.AutoSize = true;
            this.d_heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_heightLabel.Location = new System.Drawing.Point(28, 18);
            this.d_heightLabel.Name = "d_heightLabel";
            this.d_heightLabel.Size = new System.Drawing.Size(110, 13);
            this.d_heightLabel.TabIndex = 2;
            this.d_heightLabel.Text = "Robot Height (inches)";
            // 
            // d_minHeight
            // 
            this.d_minHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_minHeight.Location = new System.Drawing.Point(31, 34);
            this.d_minHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.d_minHeight.Name = "d_minHeight";
            this.d_minHeight.Size = new System.Drawing.Size(39, 20);
            this.d_minHeight.TabIndex = 1;
            // 
            // d_applyFilterButton
            // 
            this.d_applyFilterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_applyFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_applyFilterButton.Location = new System.Drawing.Point(3, 279);
            this.d_applyFilterButton.Name = "d_applyFilterButton";
            this.d_applyFilterButton.Size = new System.Drawing.Size(336, 23);
            this.d_applyFilterButton.TabIndex = 0;
            this.d_applyFilterButton.Text = "Apply Filters";
            this.d_applyFilterButton.UseVisualStyleBackColor = true;
            this.d_applyFilterButton.Click += new System.EventHandler(this.applyFilters);
            // 
            // d_filterTeamsPanel
            // 
            this.d_filterTeamsPanel.AutoScroll = true;
            this.d_filterTeamsPanel.Location = new System.Drawing.Point(378, 336);
            this.d_filterTeamsPanel.Name = "d_filterTeamsPanel";
            this.d_filterTeamsPanel.Size = new System.Drawing.Size(342, 272);
            this.d_filterTeamsPanel.TabIndex = 0;
            // 
            // d_formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(926, 611);
            this.Controls.Add(this.d_filterTeamsPanel);
            this.Controls.Add(this.d_filterTeamBox);
            this.Controls.Add(this.d_teamBox);
            this.Controls.Add(this.d_toolstrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "d_formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MechaArchives";
            this.d_toolstrip.ResumeLayout(false);
            this.d_toolstrip.PerformLayout();
            this.d_teamBox.ResumeLayout(false);
            this.d_filterTeamBox.ResumeLayout(false);
            this.d_filterTeamBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_maxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_minHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip d_toolstrip;
        private System.Windows.Forms.ToolStripButton d_uploadButton;
        private System.Windows.Forms.ToolStripButton d_pullButton;
        private System.Windows.Forms.ToolStripSeparator d_toolSeparator1;
        private System.Windows.Forms.GroupBox d_teamBox;
        private System.Windows.Forms.ToolStripSeparator d_toolSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel d_allTeamPanel;
        private System.Windows.Forms.ToolStripLabel d_githubLink;
        private System.Windows.Forms.GroupBox d_filterTeamBox;
        private System.Windows.Forms.Panel d_filterTeamsPanel;
        private System.Windows.Forms.Button d_applyFilterButton;
        private System.Windows.Forms.NumericUpDown d_minHeight;
        private System.Windows.Forms.CheckBox d_boxHeight;
        private System.Windows.Forms.NumericUpDown d_maxHeight;
        private System.Windows.Forms.Label d_dashLabel;
        private System.Windows.Forms.Label d_heightLabel;
        private System.Windows.Forms.Label d_autoAbilityLabel;
        private System.Windows.Forms.CheckBox d_boxRefillsAuto;
        private System.Windows.Forms.CheckBox d_boxShootsAuto;
        private System.Windows.Forms.CheckBox d_boxHasAuto;
    }
}

