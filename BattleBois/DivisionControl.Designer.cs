namespace BattleBois
{
    partial class DivisionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.AtkIcon = new System.Windows.Forms.PictureBox();
            this.DefIcon = new System.Windows.Forms.PictureBox();
            this.NumIcon = new System.Windows.Forms.PictureBox();
            this.MrlIcon = new System.Windows.Forms.PictureBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AtkLabel = new System.Windows.Forms.Label();
            this.DefLabel = new System.Windows.Forms.Label();
            this.MoraleLabel = new System.Windows.Forms.Label();
            this.TroopsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AtkIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrlIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(3, 2);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(96, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Division Name";
            // 
            // AtkIcon
            // 
            this.AtkIcon.Image = global::BattleBois.Properties.Resources.atk_sword;
            this.AtkIcon.Location = new System.Drawing.Point(6, 23);
            this.AtkIcon.Name = "AtkIcon";
            this.AtkIcon.Size = new System.Drawing.Size(16, 16);
            this.AtkIcon.TabIndex = 1;
            this.AtkIcon.TabStop = false;
            // 
            // DefIcon
            // 
            this.DefIcon.Image = global::BattleBois.Properties.Resources.def_shield;
            this.DefIcon.Location = new System.Drawing.Point(95, 23);
            this.DefIcon.Name = "DefIcon";
            this.DefIcon.Size = new System.Drawing.Size(16, 16);
            this.DefIcon.TabIndex = 2;
            this.DefIcon.TabStop = false;
            // 
            // NumIcon
            // 
            this.NumIcon.Image = global::BattleBois.Properties.Resources.num_soldier;
            this.NumIcon.Location = new System.Drawing.Point(144, 4);
            this.NumIcon.Name = "NumIcon";
            this.NumIcon.Size = new System.Drawing.Size(16, 16);
            this.NumIcon.TabIndex = 3;
            this.NumIcon.TabStop = false;
            // 
            // MrlIcon
            // 
            this.MrlIcon.Image = global::BattleBois.Properties.Resources.mrl_neutral;
            this.MrlIcon.Location = new System.Drawing.Point(144, 23);
            this.MrlIcon.Name = "MrlIcon";
            this.MrlIcon.Size = new System.Drawing.Size(16, 16);
            this.MrlIcon.TabIndex = 4;
            this.MrlIcon.TabStop = false;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(216, 2);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(22, 13);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "HC";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AtkLabel
            // 
            this.AtkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtkLabel.AutoSize = true;
            this.AtkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtkLabel.Location = new System.Drawing.Point(24, 24);
            this.AtkLabel.Name = "AtkLabel";
            this.AtkLabel.Size = new System.Drawing.Size(66, 13);
            this.AtkLabel.TabIndex = 6;
            this.AtkLabel.Text = "100 / 2d6+2";
            // 
            // DefLabel
            // 
            this.DefLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DefLabel.AutoSize = true;
            this.DefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefLabel.Location = new System.Drawing.Point(113, 24);
            this.DefLabel.Name = "DefLabel";
            this.DefLabel.Size = new System.Drawing.Size(25, 13);
            this.DefLabel.TabIndex = 7;
            this.DefLabel.Text = "120";
            // 
            // MoraleLabel
            // 
            this.MoraleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoraleLabel.AutoSize = true;
            this.MoraleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoraleLabel.Location = new System.Drawing.Point(162, 24);
            this.MoraleLabel.Name = "MoraleLabel";
            this.MoraleLabel.Size = new System.Drawing.Size(42, 13);
            this.MoraleLabel.TabIndex = 8;
            this.MoraleLabel.Text = "0 / 2d8";
            // 
            // TroopsLabel
            // 
            this.TroopsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TroopsLabel.AutoSize = true;
            this.TroopsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TroopsLabel.Location = new System.Drawing.Point(162, 5);
            this.TroopsLabel.Name = "TroopsLabel";
            this.TroopsLabel.Size = new System.Drawing.Size(43, 13);
            this.TroopsLabel.TabIndex = 9;
            this.TroopsLabel.Text = "100000";
            // 
            // DivisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TroopsLabel);
            this.Controls.Add(this.MoraleLabel);
            this.Controls.Add(this.DefLabel);
            this.Controls.Add(this.AtkLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.MrlIcon);
            this.Controls.Add(this.NumIcon);
            this.Controls.Add(this.DefIcon);
            this.Controls.Add(this.AtkIcon);
            this.Controls.Add(this.NameLabel);
            this.Name = "DivisionControl";
            this.Size = new System.Drawing.Size(240, 46);
            ((System.ComponentModel.ISupportInitialize)(this.AtkIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MrlIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox AtkIcon;
        private System.Windows.Forms.PictureBox DefIcon;
        private System.Windows.Forms.PictureBox NumIcon;
        private System.Windows.Forms.PictureBox MrlIcon;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label AtkLabel;
        private System.Windows.Forms.Label DefLabel;
        private System.Windows.Forms.Label MoraleLabel;
        private System.Windows.Forms.Label TroopsLabel;
    }
}
