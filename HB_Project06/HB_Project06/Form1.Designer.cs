namespace HB_Project06
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboShipMeth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelTextBoxCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.grpBoxSurcharge = new System.Windows.Forms.GroupBox();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textShippingCost = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpBoxSurcharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red Fern On-Line Electronics";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shipping Calculator\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shipping Method";
            // 
            // comboShipMeth
            // 
            this.comboShipMeth.DisplayMember = "(none)";
            this.comboShipMeth.FormattingEnabled = true;
            this.comboShipMeth.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same Day"});
            this.comboShipMeth.Location = new System.Drawing.Point(59, 129);
            this.comboShipMeth.Name = "comboShipMeth";
            this.comboShipMeth.Size = new System.Drawing.Size(121, 21);
            this.comboShipMeth.TabIndex = 0;
            this.comboShipMeth.Text = "Select One";
            this.comboShipMeth.SelectedIndexChanged += new System.EventHandler(this.comboShipMeth_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "(none)";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "By Weight",
            "By Item"});
            this.comboBox1.Location = new System.Drawing.Point(240, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select One";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelTextBoxCategory
            // 
            this.labelTextBoxCategory.AutoSize = true;
            this.labelTextBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBoxCategory.Location = new System.Drawing.Point(62, 162);
            this.labelTextBoxCategory.Name = "labelTextBoxCategory";
            this.labelTextBoxCategory.Size = new System.Drawing.Size(105, 16);
            this.labelTextBoxCategory.TabIndex = 3;
            this.labelTextBoxCategory.Text = "Number of Items";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(59, 183);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(121, 20);
            this.textBoxCategory.TabIndex = 2;
            // 
            // grpBoxSurcharge
            // 
            this.grpBoxSurcharge.Controls.Add(this.radioNo);
            this.grpBoxSurcharge.Controls.Add(this.radioYes);
            this.grpBoxSurcharge.Location = new System.Drawing.Point(240, 179);
            this.grpBoxSurcharge.Name = "grpBoxSurcharge";
            this.grpBoxSurcharge.Size = new System.Drawing.Size(134, 84);
            this.grpBoxSurcharge.TabIndex = 4;
            this.grpBoxSurcharge.TabStop = false;
            this.grpBoxSurcharge.Text = "Surcharge (HA or AK)";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(6, 46);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 1;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            this.radioNo.CheckedChanged += new System.EventHandler(this.radioNo_CheckedChanged);
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(7, 23);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(43, 17);
            this.radioYes.TabIndex = 0;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            this.radioYes.CheckedChanged += new System.EventHandler(this.radioYes_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(65, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate\r\nShipping";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Shipping Cost";
            // 
            // textShippingCost
            // 
            this.textShippingCost.BackColor = System.Drawing.SystemColors.Control;
            this.textShippingCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textShippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textShippingCost.Location = new System.Drawing.Point(267, 303);
            this.textShippingCost.Name = "textShippingCost";
            this.textShippingCost.Size = new System.Drawing.Size(102, 19);
            this.textShippingCost.TabIndex = 9;
            this.textShippingCost.Text = "$0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 365);
            this.Controls.Add(this.textShippingCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpBoxSurcharge);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboShipMeth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTextBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CS1400 Project 6";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxSurcharge.ResumeLayout(false);
            this.grpBoxSurcharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboShipMeth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTextBoxCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.GroupBox grpBoxSurcharge;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textShippingCost;
    }
}

