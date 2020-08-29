namespace Lab_5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iceCreamPictureBox = new System.Windows.Forms.PictureBox();
            this.coneTypeLabel = new System.Windows.Forms.Label();
            this.sugarConeButton = new System.Windows.Forms.RadioButton();
            this.waflleConeButton = new System.Windows.Forms.RadioButton();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.flavorBox = new System.Windows.Forms.ComboBox();
            this.toppingsListBox = new System.Windows.Forms.ListBox();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iceCreamPictureBox
            // 
            this.iceCreamPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iceCreamPictureBox.Image")));
            this.iceCreamPictureBox.Location = new System.Drawing.Point(160, 66);
            this.iceCreamPictureBox.Name = "iceCreamPictureBox";
            this.iceCreamPictureBox.Size = new System.Drawing.Size(326, 189);
            this.iceCreamPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iceCreamPictureBox.TabIndex = 0;
            this.iceCreamPictureBox.TabStop = false;
            // 
            // coneTypeLabel
            // 
            this.coneTypeLabel.AutoSize = true;
            this.coneTypeLabel.Location = new System.Drawing.Point(127, 318);
            this.coneTypeLabel.Name = "coneTypeLabel";
            this.coneTypeLabel.Size = new System.Drawing.Size(89, 20);
            this.coneTypeLabel.TabIndex = 1;
            this.coneTypeLabel.Text = "Cone Type:";
            // 
            // sugarConeButton
            // 
            this.sugarConeButton.AutoSize = true;
            this.sugarConeButton.Checked = true;
            this.sugarConeButton.Location = new System.Drawing.Point(231, 318);
            this.sugarConeButton.Name = "sugarConeButton";
            this.sugarConeButton.Size = new System.Drawing.Size(119, 24);
            this.sugarConeButton.TabIndex = 2;
            this.sugarConeButton.TabStop = true;
            this.sugarConeButton.Text = "Sugar Cone";
            this.sugarConeButton.UseVisualStyleBackColor = true;
            // 
            // waflleConeButton
            // 
            this.waflleConeButton.AutoSize = true;
            this.waflleConeButton.Location = new System.Drawing.Point(379, 316);
            this.waflleConeButton.Name = "waflleConeButton";
            this.waflleConeButton.Size = new System.Drawing.Size(122, 24);
            this.waflleConeButton.TabIndex = 3;
            this.waflleConeButton.Text = "Waffle Cone";
            this.waflleConeButton.UseVisualStyleBackColor = true;
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.Location = new System.Drawing.Point(174, 378);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(133, 20);
            this.flavorLabel.TabIndex = 4;
            this.flavorLabel.Text = "Ice Cream Flavor:";
            // 
            // flavorBox
            // 
            this.flavorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flavorBox.FormattingEnabled = true;
            this.flavorBox.Location = new System.Drawing.Point(313, 375);
            this.flavorBox.Name = "flavorBox";
            this.flavorBox.Size = new System.Drawing.Size(121, 28);
            this.flavorBox.TabIndex = 5;
            // 
            // toppingsListBox
            // 
            this.toppingsListBox.FormattingEnabled = true;
            this.toppingsListBox.ItemHeight = 20;
            this.toppingsListBox.Location = new System.Drawing.Point(295, 429);
            this.toppingsListBox.Name = "toppingsListBox";
            this.toppingsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.toppingsListBox.Size = new System.Drawing.Size(138, 124);
            this.toppingsListBox.TabIndex = 6;
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Location = new System.Drawing.Point(191, 429);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(78, 20);
            this.toppingsLabel.TabIndex = 7;
            this.toppingsLabel.Text = "Toppings:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuButton,
            this.helpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuButton
            // 
            this.fileMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenuButton.Name = "fileMenuButton";
            this.fileMenuButton.Size = new System.Drawing.Size(54, 29);
            this.fileMenuButton.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 578);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.toppingsListBox);
            this.Controls.Add(this.flavorBox);
            this.Controls.Add(this.flavorLabel);
            this.Controls.Add(this.waflleConeButton);
            this.Controls.Add(this.sugarConeButton);
            this.Controls.Add(this.coneTypeLabel);
            this.Controls.Add(this.iceCreamPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Joe\'s Ice Cream Emporium";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iceCreamPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iceCreamPictureBox;
        private System.Windows.Forms.Label coneTypeLabel;
        private System.Windows.Forms.RadioButton sugarConeButton;
        private System.Windows.Forms.RadioButton waflleConeButton;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.ComboBox flavorBox;
        private System.Windows.Forms.ListBox toppingsListBox;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuButton;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

