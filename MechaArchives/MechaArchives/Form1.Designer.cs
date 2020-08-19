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
            this.d_teamBox = new System.Windows.Forms.GroupBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.d_toolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // d_toolstrip
            // 
            this.d_toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.d_uploadButton,
            this.d_toolSeparator1,
            this.d_pullButton,
            this.d_toolSeparator2,
            this.toolStripButton1});
            this.d_toolstrip.Location = new System.Drawing.Point(0, 0);
            this.d_toolstrip.Name = "d_toolstrip";
            this.d_toolstrip.Size = new System.Drawing.Size(670, 25);
            this.d_toolstrip.TabIndex = 1;
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
            this.d_pullButton.Click += new System.EventHandler(this.d_pullButton_Click);
            // 
            // d_toolSeparator2
            // 
            this.d_toolSeparator2.ForeColor = System.Drawing.SystemColors.Control;
            this.d_toolSeparator2.Name = "d_toolSeparator2";
            this.d_toolSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // d_teamBox
            // 
            this.d_teamBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.d_teamBox.Location = new System.Drawing.Point(520, 25);
            this.d_teamBox.Name = "d_teamBox";
            this.d_teamBox.Size = new System.Drawing.Size(150, 509);
            this.d_teamBox.TabIndex = 0;
            this.d_teamBox.TabStop = false;
            this.d_teamBox.Text = "Available Team Info";
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
            // d_formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 534);
            this.Controls.Add(this.d_teamBox);
            this.Controls.Add(this.d_toolstrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "d_formMain";
            this.Text = " MechaArchives";
            this.d_toolstrip.ResumeLayout(false);
            this.d_toolstrip.PerformLayout();
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
    }
}

