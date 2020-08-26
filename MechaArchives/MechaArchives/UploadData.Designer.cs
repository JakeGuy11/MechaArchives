namespace MechaArchives
{
    partial class UploadData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadData));
            this.d_teamNum = new System.Windows.Forms.TextBox();
            this.d_teamNumLabel = new System.Windows.Forms.Label();
            this.d_titleLabel = new System.Windows.Forms.Label();
            this.d_weightLabel = new System.Windows.Forms.Label();
            this.d_robotWeight = new System.Windows.Forms.TextBox();
            this.d_heightLabel = new System.Windows.Forms.Label();
            this.d_robotHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // d_teamNum
            // 
            this.d_teamNum.Location = new System.Drawing.Point(13, 67);
            this.d_teamNum.Margin = new System.Windows.Forms.Padding(4);
            this.d_teamNum.MaxLength = 4;
            this.d_teamNum.Name = "d_teamNum";
            this.d_teamNum.Size = new System.Drawing.Size(95, 22);
            this.d_teamNum.TabIndex = 0;
            this.d_teamNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyCheck);
            // 
            // d_teamNumLabel
            // 
            this.d_teamNumLabel.AutoSize = true;
            this.d_teamNumLabel.Location = new System.Drawing.Point(13, 47);
            this.d_teamNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_teamNumLabel.Name = "d_teamNumLabel";
            this.d_teamNumLabel.Size = new System.Drawing.Size(95, 16);
            this.d_teamNumLabel.TabIndex = 1;
            this.d_teamNumLabel.Text = "Team Number";
            // 
            // d_titleLabel
            // 
            this.d_titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.d_titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_titleLabel.Location = new System.Drawing.Point(0, 0);
            this.d_titleLabel.Name = "d_titleLabel";
            this.d_titleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.d_titleLabel.Size = new System.Drawing.Size(484, 31);
            this.d_titleLabel.TabIndex = 2;
            this.d_titleLabel.Text = "Upload Team Robot Data";
            this.d_titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // d_weightLabel
            // 
            this.d_weightLabel.AutoSize = true;
            this.d_weightLabel.Location = new System.Drawing.Point(13, 197);
            this.d_weightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_weightLabel.Name = "d_weightLabel";
            this.d_weightLabel.Size = new System.Drawing.Size(90, 16);
            this.d_weightLabel.TabIndex = 4;
            this.d_weightLabel.Text = "Robot Weight";
            // 
            // d_robotWeight
            // 
            this.d_robotWeight.Location = new System.Drawing.Point(13, 217);
            this.d_robotWeight.Margin = new System.Windows.Forms.Padding(4);
            this.d_robotWeight.MaxLength = 4;
            this.d_robotWeight.Name = "d_robotWeight";
            this.d_robotWeight.Size = new System.Drawing.Size(95, 22);
            this.d_robotWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyCheck);
            this.d_robotWeight.TabIndex = 3;
            // 
            // d_heightLabel
            // 
            this.d_heightLabel.AutoSize = true;
            this.d_heightLabel.Location = new System.Drawing.Point(13, 122);
            this.d_heightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_heightLabel.Name = "d_heightLabel";
            this.d_heightLabel.Size = new System.Drawing.Size(87, 16);
            this.d_heightLabel.TabIndex = 6;
            this.d_heightLabel.Text = "Robot Height";
            // 
            // d_robotHeight
            // 
            this.d_robotHeight.Location = new System.Drawing.Point(13, 142);
            this.d_robotHeight.Margin = new System.Windows.Forms.Padding(4);
            this.d_robotHeight.MaxLength = 4;
            this.d_robotHeight.Name = "d_robotHeight";
            this.d_robotHeight.Size = new System.Drawing.Size(95, 22);
            this.d_robotHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOnlyCheck);
            this.d_robotHeight.TabIndex = 5;
            // 
            // UploadData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.d_heightLabel);
            this.Controls.Add(this.d_robotHeight);
            this.Controls.Add(this.d_weightLabel);
            this.Controls.Add(this.d_robotWeight);
            this.Controls.Add(this.d_titleLabel);
            this.Controls.Add(this.d_teamNumLabel);
            this.Controls.Add(this.d_teamNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UploadData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Upload Team Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox d_teamNum;
        private System.Windows.Forms.Label d_teamNumLabel;
        private System.Windows.Forms.Label d_titleLabel;
        private System.Windows.Forms.Label d_weightLabel;
        private System.Windows.Forms.TextBox d_robotWeight;
        private System.Windows.Forms.Label d_heightLabel;
        private System.Windows.Forms.TextBox d_robotHeight;
    }
}