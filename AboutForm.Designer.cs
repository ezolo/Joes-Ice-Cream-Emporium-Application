namespace Lab_5
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.singleIceCreamPictureBox = new System.Windows.Forms.PictureBox();
            this.singleIceCreamLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.singleIceCreamPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // singleIceCreamPictureBox
            // 
            this.singleIceCreamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("singleIceCreamPictureBox.Image")));
            this.singleIceCreamPictureBox.Location = new System.Drawing.Point(102, 12);
            this.singleIceCreamPictureBox.Name = "singleIceCreamPictureBox";
            this.singleIceCreamPictureBox.Size = new System.Drawing.Size(140, 210);
            this.singleIceCreamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.singleIceCreamPictureBox.TabIndex = 0;
            this.singleIceCreamPictureBox.TabStop = false;
            // 
            // singleIceCreamLabel
            // 
            this.singleIceCreamLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleIceCreamLabel.Location = new System.Drawing.Point(381, 50);
            this.singleIceCreamLabel.Name = "singleIceCreamLabel";
            this.singleIceCreamLabel.Size = new System.Drawing.Size(281, 109);
            this.singleIceCreamLabel.TabIndex = 1;
            this.singleIceCreamLabel.Text = "Joe\'s Ice Cream Emporium Copyright 2020 by Eva Zolotarev";
            this.singleIceCreamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(470, 162);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 35);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.singleIceCreamLabel);
            this.Controls.Add(this.singleIceCreamPictureBox);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            ((System.ComponentModel.ISupportInitialize)(this.singleIceCreamPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox singleIceCreamPictureBox;
        private System.Windows.Forms.Label singleIceCreamLabel;
        private System.Windows.Forms.Button closeButton;
    }
}