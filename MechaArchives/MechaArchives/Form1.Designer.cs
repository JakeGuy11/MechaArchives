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
            this.d_climbEnabled = new System.Windows.Forms.CheckBox();
            this.d_panelEnabled = new System.Windows.Forms.CheckBox();
            this.d_cellEnabled = new System.Windows.Forms.CheckBox();
            this.d_autoEnabled = new System.Windows.Forms.CheckBox();
            this.d_canLift = new System.Windows.Forms.CheckBox();
            this.d_canBalance = new System.Windows.Forms.CheckBox();
            this.d_canClimb = new System.Windows.Forms.CheckBox();
            this.d_underPanel = new System.Windows.Forms.CheckBox();
            this.d_colorPanel = new System.Windows.Forms.CheckBox();
            this.d_spinPanel = new System.Windows.Forms.CheckBox();
            this.d_cell3 = new System.Windows.Forms.CheckBox();
            this.d_cell2 = new System.Windows.Forms.CheckBox();
            this.d_cell1 = new System.Windows.Forms.CheckBox();
            this.d_refillsAuto = new System.Windows.Forms.CheckBox();
            this.d_shootsAuto = new System.Windows.Forms.CheckBox();
            this.d_hasAuto = new System.Windows.Forms.CheckBox();
            this.d_robotLanguage = new System.Windows.Forms.ComboBox();
            this.d_boxLanguage = new System.Windows.Forms.CheckBox();
            this.d_langLabel = new System.Windows.Forms.Label();
            this.d_boxTotalRank = new System.Windows.Forms.CheckBox();
            this.d_totalRankLabel = new System.Windows.Forms.Label();
            this.d_totalRank = new System.Windows.Forms.NumericUpDown();
            this.d_boxAvgRank = new System.Windows.Forms.CheckBox();
            this.d_rankpointsLabel = new System.Windows.Forms.Label();
            this.d_avgRankPoints = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.d_totalRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_avgRankPoints)).BeginInit();
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
            this.toolStripButton1.Size = new System.Drawing.Size(173, 22);
            this.toolStripButton1.Text = "Update Robot Data From Local";
            this.toolStripButton1.ToolTipText = "Pull data for a specific team\'s robot";
            this.toolStripButton1.Click += new System.EventHandler(this.updateFromLocal);
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
            this.d_filterTeamBox.Controls.Add(this.d_climbEnabled);
            this.d_filterTeamBox.Controls.Add(this.d_panelEnabled);
            this.d_filterTeamBox.Controls.Add(this.d_cellEnabled);
            this.d_filterTeamBox.Controls.Add(this.d_autoEnabled);
            this.d_filterTeamBox.Controls.Add(this.d_canLift);
            this.d_filterTeamBox.Controls.Add(this.d_canBalance);
            this.d_filterTeamBox.Controls.Add(this.d_canClimb);
            this.d_filterTeamBox.Controls.Add(this.d_underPanel);
            this.d_filterTeamBox.Controls.Add(this.d_colorPanel);
            this.d_filterTeamBox.Controls.Add(this.d_spinPanel);
            this.d_filterTeamBox.Controls.Add(this.d_cell3);
            this.d_filterTeamBox.Controls.Add(this.d_cell2);
            this.d_filterTeamBox.Controls.Add(this.d_cell1);
            this.d_filterTeamBox.Controls.Add(this.d_refillsAuto);
            this.d_filterTeamBox.Controls.Add(this.d_shootsAuto);
            this.d_filterTeamBox.Controls.Add(this.d_hasAuto);
            this.d_filterTeamBox.Controls.Add(this.d_robotLanguage);
            this.d_filterTeamBox.Controls.Add(this.d_boxLanguage);
            this.d_filterTeamBox.Controls.Add(this.d_langLabel);
            this.d_filterTeamBox.Controls.Add(this.d_boxTotalRank);
            this.d_filterTeamBox.Controls.Add(this.d_totalRankLabel);
            this.d_filterTeamBox.Controls.Add(this.d_totalRank);
            this.d_filterTeamBox.Controls.Add(this.d_boxAvgRank);
            this.d_filterTeamBox.Controls.Add(this.d_rankpointsLabel);
            this.d_filterTeamBox.Controls.Add(this.d_avgRankPoints);
            this.d_filterTeamBox.Controls.Add(this.d_boxHeight);
            this.d_filterTeamBox.Controls.Add(this.d_maxHeight);
            this.d_filterTeamBox.Controls.Add(this.d_dashLabel);
            this.d_filterTeamBox.Controls.Add(this.d_heightLabel);
            this.d_filterTeamBox.Controls.Add(this.d_minHeight);
            this.d_filterTeamBox.Controls.Add(this.d_applyFilterButton);
            this.d_filterTeamBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.d_filterTeamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_filterTeamBox.Location = new System.Drawing.Point(0, 25);
            this.d_filterTeamBox.Name = "d_filterTeamBox";
            this.d_filterTeamBox.Size = new System.Drawing.Size(472, 586);
            this.d_filterTeamBox.TabIndex = 1;
            this.d_filterTeamBox.TabStop = false;
            this.d_filterTeamBox.Text = "Filter Teams";
            // 
            // d_climbEnabled
            // 
            this.d_climbEnabled.AutoSize = true;
            this.d_climbEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_climbEnabled.Location = new System.Drawing.Point(242, 390);
            this.d_climbEnabled.Name = "d_climbEnabled";
            this.d_climbEnabled.Size = new System.Drawing.Size(142, 19);
            this.d_climbEnabled.TabIndex = 0;
            this.d_climbEnabled.TabStop = false;
            this.d_climbEnabled.Text = "Climbing Capabilities";
            this.d_climbEnabled.UseVisualStyleBackColor = true;
            this.d_climbEnabled.CheckedChanged += new System.EventHandler(this.d_climbEnabled_CheckedChanged);
            // 
            // d_panelEnabled
            // 
            this.d_panelEnabled.AutoSize = true;
            this.d_panelEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_panelEnabled.Location = new System.Drawing.Point(242, 266);
            this.d_panelEnabled.Name = "d_panelEnabled";
            this.d_panelEnabled.Size = new System.Drawing.Size(167, 19);
            this.d_panelEnabled.TabIndex = 1;
            this.d_panelEnabled.TabStop = false;
            this.d_panelEnabled.Text = "Control Panel Capabilities";
            this.d_panelEnabled.UseVisualStyleBackColor = true;
            this.d_panelEnabled.CheckedChanged += new System.EventHandler(this.d_panelEnabled_CheckedChanged);
            // 
            // d_cellEnabled
            // 
            this.d_cellEnabled.AutoSize = true;
            this.d_cellEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_cellEnabled.Location = new System.Drawing.Point(242, 145);
            this.d_cellEnabled.Name = "d_cellEnabled";
            this.d_cellEnabled.Size = new System.Drawing.Size(155, 19);
            this.d_cellEnabled.TabIndex = 2;
            this.d_cellEnabled.TabStop = false;
            this.d_cellEnabled.Text = "Energy Cell Capabilities";
            this.d_cellEnabled.UseVisualStyleBackColor = true;
            this.d_cellEnabled.CheckedChanged += new System.EventHandler(this.d_cellEnabled_CheckedChanged);
            // 
            // d_autoEnabled
            // 
            this.d_autoEnabled.AutoSize = true;
            this.d_autoEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_autoEnabled.Location = new System.Drawing.Point(242, 24);
            this.d_autoEnabled.Name = "d_autoEnabled";
            this.d_autoEnabled.Size = new System.Drawing.Size(162, 19);
            this.d_autoEnabled.TabIndex = 3;
            this.d_autoEnabled.TabStop = false;
            this.d_autoEnabled.Text = "Autonomous Capabilities";
            this.d_autoEnabled.UseVisualStyleBackColor = true;
            this.d_autoEnabled.CheckedChanged += new System.EventHandler(this.d_autoEnabled_CheckedChanged);
            // 
            // d_canLift
            // 
            this.d_canLift.AutoSize = true;
            this.d_canLift.Enabled = false;
            this.d_canLift.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_canLift.Location = new System.Drawing.Point(266, 454);
            this.d_canLift.Name = "d_canLift";
            this.d_canLift.Size = new System.Drawing.Size(128, 17);
            this.d_canLift.TabIndex = 4;
            this.d_canLift.TabStop = false;
            this.d_canLift.Text = "Can Lift Other Robots";
            this.d_canLift.UseVisualStyleBackColor = true;
            // 
            // d_canBalance
            // 
            this.d_canBalance.AutoSize = true;
            this.d_canBalance.Enabled = false;
            this.d_canBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_canBalance.Location = new System.Drawing.Point(266, 431);
            this.d_canBalance.Name = "d_canBalance";
            this.d_canBalance.Size = new System.Drawing.Size(87, 17);
            this.d_canBalance.TabIndex = 5;
            this.d_canBalance.TabStop = false;
            this.d_canBalance.Text = "Can Balance";
            this.d_canBalance.UseVisualStyleBackColor = true;
            // 
            // d_canClimb
            // 
            this.d_canClimb.AutoSize = true;
            this.d_canClimb.Enabled = false;
            this.d_canClimb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_canClimb.Location = new System.Drawing.Point(266, 408);
            this.d_canClimb.Name = "d_canClimb";
            this.d_canClimb.Size = new System.Drawing.Size(73, 17);
            this.d_canClimb.TabIndex = 6;
            this.d_canClimb.TabStop = false;
            this.d_canClimb.Text = "Can Climb";
            this.d_canClimb.UseVisualStyleBackColor = true;
            // 
            // d_underPanel
            // 
            this.d_underPanel.AutoSize = true;
            this.d_underPanel.Enabled = false;
            this.d_underPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_underPanel.Location = new System.Drawing.Point(266, 334);
            this.d_underPanel.Name = "d_underPanel";
            this.d_underPanel.Size = new System.Drawing.Size(149, 17);
            this.d_underPanel.TabIndex = 7;
            this.d_underPanel.TabStop = false;
            this.d_underPanel.Text = "Drive Under Control Panel";
            this.d_underPanel.UseVisualStyleBackColor = true;
            // 
            // d_colorPanel
            // 
            this.d_colorPanel.AutoSize = true;
            this.d_colorPanel.Enabled = false;
            this.d_colorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_colorPanel.Location = new System.Drawing.Point(266, 311);
            this.d_colorPanel.Name = "d_colorPanel";
            this.d_colorPanel.Size = new System.Drawing.Size(88, 17);
            this.d_colorPanel.TabIndex = 8;
            this.d_colorPanel.TabStop = false;
            this.d_colorPanel.Text = "Adjust Colour";
            this.d_colorPanel.UseVisualStyleBackColor = true;
            // 
            // d_spinPanel
            // 
            this.d_spinPanel.AutoSize = true;
            this.d_spinPanel.Enabled = false;
            this.d_spinPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_spinPanel.Location = new System.Drawing.Point(266, 288);
            this.d_spinPanel.Name = "d_spinPanel";
            this.d_spinPanel.Size = new System.Drawing.Size(113, 17);
            this.d_spinPanel.TabIndex = 9;
            this.d_spinPanel.TabStop = false;
            this.d_spinPanel.Text = "Spin Control Panel";
            this.d_spinPanel.UseVisualStyleBackColor = true;
            // 
            // d_cell3
            // 
            this.d_cell3.AutoSize = true;
            this.d_cell3.Enabled = false;
            this.d_cell3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_cell3.Location = new System.Drawing.Point(266, 209);
            this.d_cell3.Name = "d_cell3";
            this.d_cell3.Size = new System.Drawing.Size(61, 17);
            this.d_cell3.TabIndex = 10;
            this.d_cell3.TabStop = false;
            this.d_cell3.Text = "Level 3";
            this.d_cell3.UseVisualStyleBackColor = true;
            // 
            // d_cell2
            // 
            this.d_cell2.AutoSize = true;
            this.d_cell2.Enabled = false;
            this.d_cell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_cell2.Location = new System.Drawing.Point(266, 186);
            this.d_cell2.Name = "d_cell2";
            this.d_cell2.Size = new System.Drawing.Size(61, 17);
            this.d_cell2.TabIndex = 11;
            this.d_cell2.TabStop = false;
            this.d_cell2.Text = "Level 2";
            this.d_cell2.UseVisualStyleBackColor = true;
            // 
            // d_cell1
            // 
            this.d_cell1.AutoSize = true;
            this.d_cell1.Enabled = false;
            this.d_cell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_cell1.Location = new System.Drawing.Point(266, 163);
            this.d_cell1.Name = "d_cell1";
            this.d_cell1.Size = new System.Drawing.Size(61, 17);
            this.d_cell1.TabIndex = 12;
            this.d_cell1.TabStop = false;
            this.d_cell1.Text = "Level 1";
            this.d_cell1.UseVisualStyleBackColor = true;
            // 
            // d_refillsAuto
            // 
            this.d_refillsAuto.AutoSize = true;
            this.d_refillsAuto.Enabled = false;
            this.d_refillsAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_refillsAuto.Location = new System.Drawing.Point(266, 89);
            this.d_refillsAuto.Name = "d_refillsAuto";
            this.d_refillsAuto.Size = new System.Drawing.Size(128, 17);
            this.d_refillsAuto.TabIndex = 13;
            this.d_refillsAuto.TabStop = false;
            this.d_refillsAuto.Text = "Refills In Autonomous";
            this.d_refillsAuto.UseVisualStyleBackColor = true;
            this.d_refillsAuto.CheckedChanged += new System.EventHandler(this.autoBoxChanged);
            // 
            // d_shootsAuto
            // 
            this.d_shootsAuto.AutoSize = true;
            this.d_shootsAuto.Enabled = false;
            this.d_shootsAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_shootsAuto.Location = new System.Drawing.Point(266, 66);
            this.d_shootsAuto.Name = "d_shootsAuto";
            this.d_shootsAuto.Size = new System.Drawing.Size(133, 17);
            this.d_shootsAuto.TabIndex = 14;
            this.d_shootsAuto.TabStop = false;
            this.d_shootsAuto.Text = "Shoots In Autonomous";
            this.d_shootsAuto.UseVisualStyleBackColor = true;
            this.d_shootsAuto.CheckedChanged += new System.EventHandler(this.autoBoxChanged);
            // 
            // d_hasAuto
            // 
            this.d_hasAuto.AutoSize = true;
            this.d_hasAuto.Enabled = false;
            this.d_hasAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_hasAuto.Location = new System.Drawing.Point(266, 43);
            this.d_hasAuto.Name = "d_hasAuto";
            this.d_hasAuto.Size = new System.Drawing.Size(107, 17);
            this.d_hasAuto.TabIndex = 15;
            this.d_hasAuto.TabStop = false;
            this.d_hasAuto.Text = "Has Autonomous";
            this.d_hasAuto.UseVisualStyleBackColor = true;
            this.d_hasAuto.CheckedChanged += new System.EventHandler(this.autoBoxChanged);
            // 
            // d_robotLanguage
            // 
            this.d_robotLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.d_robotLanguage.Enabled = false;
            this.d_robotLanguage.FormattingEnabled = true;
            this.d_robotLanguage.Items.AddRange(new object[] {
            "C++",
            "Java",
            "Python",
            "JAKE CHANGE ME (Scratch-based)",
            "Other"});
            this.d_robotLanguage.Location = new System.Drawing.Point(31, 98);
            this.d_robotLanguage.Name = "d_robotLanguage";
            this.d_robotLanguage.Size = new System.Drawing.Size(126, 24);
            this.d_robotLanguage.TabIndex = 16;
            this.d_robotLanguage.TabStop = false;
            // 
            // d_boxLanguage
            // 
            this.d_boxLanguage.AutoSize = true;
            this.d_boxLanguage.Location = new System.Drawing.Point(9, 98);
            this.d_boxLanguage.Name = "d_boxLanguage";
            this.d_boxLanguage.Size = new System.Drawing.Size(15, 14);
            this.d_boxLanguage.TabIndex = 17;
            this.d_boxLanguage.TabStop = false;
            this.d_boxLanguage.UseVisualStyleBackColor = true;
            this.d_boxLanguage.CheckedChanged += new System.EventHandler(this.d_boxLanguage_CheckedChanged);
            // 
            // d_langLabel
            // 
            this.d_langLabel.AutoSize = true;
            this.d_langLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_langLabel.Location = new System.Drawing.Point(28, 81);
            this.d_langLabel.Name = "d_langLabel";
            this.d_langLabel.Size = new System.Drawing.Size(87, 13);
            this.d_langLabel.TabIndex = 18;
            this.d_langLabel.Text = "Robot Language";
            // 
            // d_boxTotalRank
            // 
            this.d_boxTotalRank.AutoSize = true;
            this.d_boxTotalRank.Location = new System.Drawing.Point(9, 220);
            this.d_boxTotalRank.Name = "d_boxTotalRank";
            this.d_boxTotalRank.Size = new System.Drawing.Size(15, 14);
            this.d_boxTotalRank.TabIndex = 19;
            this.d_boxTotalRank.TabStop = false;
            this.d_boxTotalRank.UseVisualStyleBackColor = true;
            this.d_boxTotalRank.CheckedChanged += new System.EventHandler(this.d_boxTotalRank_CheckedChanged);
            // 
            // d_totalRankLabel
            // 
            this.d_totalRankLabel.AutoSize = true;
            this.d_totalRankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_totalRankLabel.Location = new System.Drawing.Point(28, 203);
            this.d_totalRankLabel.Name = "d_totalRankLabel";
            this.d_totalRankLabel.Size = new System.Drawing.Size(142, 13);
            this.d_totalRankLabel.TabIndex = 20;
            this.d_totalRankLabel.Text = "Total Ranking Points (> or =)";
            // 
            // d_totalRank
            // 
            this.d_totalRank.Enabled = false;
            this.d_totalRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_totalRank.Location = new System.Drawing.Point(31, 219);
            this.d_totalRank.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.d_totalRank.Name = "d_totalRank";
            this.d_totalRank.Size = new System.Drawing.Size(52, 20);
            this.d_totalRank.TabIndex = 21;
            this.d_totalRank.TabStop = false;
            // 
            // d_boxAvgRank
            // 
            this.d_boxAvgRank.AutoSize = true;
            this.d_boxAvgRank.Location = new System.Drawing.Point(9, 156);
            this.d_boxAvgRank.Name = "d_boxAvgRank";
            this.d_boxAvgRank.Size = new System.Drawing.Size(15, 14);
            this.d_boxAvgRank.TabIndex = 22;
            this.d_boxAvgRank.TabStop = false;
            this.d_boxAvgRank.UseVisualStyleBackColor = true;
            this.d_boxAvgRank.CheckedChanged += new System.EventHandler(this.d_boxAvgRank_CheckedChanged);
            // 
            // d_rankpointsLabel
            // 
            this.d_rankpointsLabel.AutoSize = true;
            this.d_rankpointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_rankpointsLabel.Location = new System.Drawing.Point(28, 139);
            this.d_rankpointsLabel.Name = "d_rankpointsLabel";
            this.d_rankpointsLabel.Size = new System.Drawing.Size(158, 13);
            this.d_rankpointsLabel.TabIndex = 23;
            this.d_rankpointsLabel.Text = "Average Ranking Points (> or =)";
            // 
            // d_avgRankPoints
            // 
            this.d_avgRankPoints.DecimalPlaces = 1;
            this.d_avgRankPoints.Enabled = false;
            this.d_avgRankPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_avgRankPoints.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.d_avgRankPoints.Location = new System.Drawing.Point(31, 155);
            this.d_avgRankPoints.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.d_avgRankPoints.Name = "d_avgRankPoints";
            this.d_avgRankPoints.Size = new System.Drawing.Size(52, 20);
            this.d_avgRankPoints.TabIndex = 24;
            this.d_avgRankPoints.TabStop = false;
            // 
            // d_boxHeight
            // 
            this.d_boxHeight.AutoSize = true;
            this.d_boxHeight.Location = new System.Drawing.Point(9, 42);
            this.d_boxHeight.Name = "d_boxHeight";
            this.d_boxHeight.Size = new System.Drawing.Size(15, 14);
            this.d_boxHeight.TabIndex = 25;
            this.d_boxHeight.TabStop = false;
            this.d_boxHeight.UseVisualStyleBackColor = true;
            this.d_boxHeight.CheckedChanged += new System.EventHandler(this.d_boxHeight_CheckedChanged);
            // 
            // d_maxHeight
            // 
            this.d_maxHeight.Enabled = false;
            this.d_maxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_maxHeight.Location = new System.Drawing.Point(84, 41);
            this.d_maxHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.d_maxHeight.Name = "d_maxHeight";
            this.d_maxHeight.Size = new System.Drawing.Size(39, 20);
            this.d_maxHeight.TabIndex = 26;
            this.d_maxHeight.TabStop = false;
            // 
            // d_dashLabel
            // 
            this.d_dashLabel.AutoSize = true;
            this.d_dashLabel.Location = new System.Drawing.Point(71, 42);
            this.d_dashLabel.Name = "d_dashLabel";
            this.d_dashLabel.Size = new System.Drawing.Size(12, 16);
            this.d_dashLabel.TabIndex = 27;
            this.d_dashLabel.Text = "-";
            // 
            // d_heightLabel
            // 
            this.d_heightLabel.AutoSize = true;
            this.d_heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_heightLabel.Location = new System.Drawing.Point(28, 25);
            this.d_heightLabel.Name = "d_heightLabel";
            this.d_heightLabel.Size = new System.Drawing.Size(110, 13);
            this.d_heightLabel.TabIndex = 28;
            this.d_heightLabel.Text = "Robot Height (inches)";
            // 
            // d_minHeight
            // 
            this.d_minHeight.Enabled = false;
            this.d_minHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_minHeight.Location = new System.Drawing.Point(31, 41);
            this.d_minHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.d_minHeight.Name = "d_minHeight";
            this.d_minHeight.Size = new System.Drawing.Size(39, 20);
            this.d_minHeight.TabIndex = 29;
            this.d_minHeight.TabStop = false;
            // 
            // d_applyFilterButton
            // 
            this.d_applyFilterButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.d_applyFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_applyFilterButton.Location = new System.Drawing.Point(3, 560);
            this.d_applyFilterButton.Name = "d_applyFilterButton";
            this.d_applyFilterButton.Size = new System.Drawing.Size(466, 23);
            this.d_applyFilterButton.TabIndex = 30;
            this.d_applyFilterButton.TabStop = false;
            this.d_applyFilterButton.Text = "Apply Filters";
            this.d_applyFilterButton.UseVisualStyleBackColor = true;
            this.d_applyFilterButton.Click += new System.EventHandler(this.applyFilters);
            // 
            // d_filterTeamsPanel
            // 
            this.d_filterTeamsPanel.AutoScroll = true;
            this.d_filterTeamsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_filterTeamsPanel.Location = new System.Drawing.Point(472, 25);
            this.d_filterTeamsPanel.Name = "d_filterTeamsPanel";
            this.d_filterTeamsPanel.Size = new System.Drawing.Size(254, 586);
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
            this.Text = "MechaArchives+";
            this.d_toolstrip.ResumeLayout(false);
            this.d_toolstrip.PerformLayout();
            this.d_teamBox.ResumeLayout(false);
            this.d_filterTeamBox.ResumeLayout(false);
            this.d_filterTeamBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_totalRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_avgRankPoints)).EndInit();
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
        private System.Windows.Forms.CheckBox d_boxAvgRank;
        private System.Windows.Forms.Label d_rankpointsLabel;
        private System.Windows.Forms.NumericUpDown d_avgRankPoints;
        private System.Windows.Forms.CheckBox d_boxTotalRank;
        private System.Windows.Forms.Label d_totalRankLabel;
        private System.Windows.Forms.NumericUpDown d_totalRank;
        private System.Windows.Forms.CheckBox d_boxLanguage;
        private System.Windows.Forms.Label d_langLabel;
        private System.Windows.Forms.ComboBox d_robotLanguage;
        private System.Windows.Forms.CheckBox d_canLift;
        private System.Windows.Forms.CheckBox d_canBalance;
        private System.Windows.Forms.CheckBox d_canClimb;
        private System.Windows.Forms.CheckBox d_underPanel;
        private System.Windows.Forms.CheckBox d_colorPanel;
        private System.Windows.Forms.CheckBox d_spinPanel;
        private System.Windows.Forms.CheckBox d_cell3;
        private System.Windows.Forms.CheckBox d_cell2;
        private System.Windows.Forms.CheckBox d_cell1;
        private System.Windows.Forms.CheckBox d_refillsAuto;
        private System.Windows.Forms.CheckBox d_shootsAuto;
        private System.Windows.Forms.CheckBox d_hasAuto;
        private System.Windows.Forms.CheckBox d_climbEnabled;
        private System.Windows.Forms.CheckBox d_panelEnabled;
        private System.Windows.Forms.CheckBox d_cellEnabled;
        private System.Windows.Forms.CheckBox d_autoEnabled;
    }
}

