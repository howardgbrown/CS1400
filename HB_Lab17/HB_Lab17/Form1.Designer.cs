namespace HB_Lab17
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupShipMethBox = new System.Windows.Forms.GroupBox();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.radioExpress = new System.Windows.Forms.RadioButton();
            this.radioSameDay = new System.Windows.Forms.RadioButton();
            this.selectButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.groupShipMethBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(308, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "fileMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupShipMethBox
            // 
            this.groupShipMethBox.Controls.Add(this.radioStandard);
            this.groupShipMethBox.Controls.Add(this.radioExpress);
            this.groupShipMethBox.Controls.Add(this.radioSameDay);
            this.groupShipMethBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupShipMethBox.Location = new System.Drawing.Point(35, 48);
            this.groupShipMethBox.Name = "groupShipMethBox";
            this.groupShipMethBox.Size = new System.Drawing.Size(125, 100);
            this.groupShipMethBox.TabIndex = 2;
            this.groupShipMethBox.TabStop = false;
            this.groupShipMethBox.Text = "Shipping Method";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(6, 65);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(75, 19);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            this.radioStandard.CheckedChanged += new System.EventHandler(this.radioStandard_CheckedChanged);
            // 
            // radioExpress
            // 
            this.radioExpress.AutoSize = true;
            this.radioExpress.Location = new System.Drawing.Point(6, 42);
            this.radioExpress.Name = "radioExpress";
            this.radioExpress.Size = new System.Drawing.Size(69, 19);
            this.radioExpress.TabIndex = 0;
            this.radioExpress.TabStop = true;
            this.radioExpress.Text = "Express";
            this.radioExpress.UseVisualStyleBackColor = true;
            this.radioExpress.CheckedChanged += new System.EventHandler(this.radioExpress_CheckedChanged);
            // 
            // radioSameDay
            // 
            this.radioSameDay.AutoSize = true;
            this.radioSameDay.Checked = true;
            this.radioSameDay.Location = new System.Drawing.Point(6, 19);
            this.radioSameDay.Name = "radioSameDay";
            this.radioSameDay.Size = new System.Drawing.Size(82, 19);
            this.radioSameDay.TabIndex = 0;
            this.radioSameDay.TabStop = true;
            this.radioSameDay.Text = "Same Day";
            this.radioSameDay.UseVisualStyleBackColor = true;
            this.radioSameDay.CheckedChanged += new System.EventHandler(this.radioSameDay_CheckedChanged);
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(190, 88);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 3;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 199);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.groupShipMethBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Lab 17 Shipping Methods";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupShipMethBox.ResumeLayout(false);
            this.groupShipMethBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupShipMethBox;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.RadioButton radioExpress;
        private System.Windows.Forms.RadioButton radioSameDay;
        private System.Windows.Forms.Button selectButton;
    }
}

