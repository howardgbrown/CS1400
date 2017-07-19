namespace HB_Project04
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSideA = new System.Windows.Forms.TextBox();
            this.textBoxSideB = new System.Windows.Forms.TextBox();
            this.textBoxAngleC = new System.Windows.Forms.TextBox();
            this.textBoxSideC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSideA2 = new System.Windows.Forms.TextBox();
            this.textBoxSideC2 = new System.Windows.Forms.TextBox();
            this.textBoxAngleB2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCalc2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSideB2 = new System.Windows.Forms.TextBox();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HB_Project04.Properties.Resources.triangleProject4;
            this.pictureBox1.Location = new System.Drawing.Point(235, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 106);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSideA
            // 
            this.textBoxSideA.Location = new System.Drawing.Point(69, 89);
            this.textBoxSideA.Name = "textBoxSideA";
            this.textBoxSideA.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideA.TabIndex = 2;
            // 
            // textBoxSideB
            // 
            this.textBoxSideB.Location = new System.Drawing.Point(69, 125);
            this.textBoxSideB.Name = "textBoxSideB";
            this.textBoxSideB.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideB.TabIndex = 3;
            // 
            // textBoxAngleC
            // 
            this.textBoxAngleC.Location = new System.Drawing.Point(69, 160);
            this.textBoxAngleC.Name = "textBoxAngleC";
            this.textBoxAngleC.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngleC.TabIndex = 4;
            // 
            // textBoxSideC
            // 
            this.textBoxSideC.Location = new System.Drawing.Point(69, 291);
            this.textBoxSideC.Name = "textBoxSideC";
            this.textBoxSideC.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideC.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Given two sides and the angle between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "side a:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "side b:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Angle C:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calculate the value of\r\nthe opposite side";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "side c:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(84, 253);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 12;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(84, 329);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Give the sides and the angle between\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "side a:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "side c:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Angle B:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxSideA2
            // 
            this.textBoxSideA2.Location = new System.Drawing.Point(487, 89);
            this.textBoxSideA2.Name = "textBoxSideA2";
            this.textBoxSideA2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideA2.TabIndex = 18;
            // 
            // textBoxSideC2
            // 
            this.textBoxSideC2.Location = new System.Drawing.Point(487, 125);
            this.textBoxSideC2.Name = "textBoxSideC2";
            this.textBoxSideC2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideC2.TabIndex = 19;
            // 
            // textBoxAngleB2
            // 
            this.textBoxAngleB2.Location = new System.Drawing.Point(487, 160);
            this.textBoxAngleB2.Name = "textBoxAngleB2";
            this.textBoxAngleB2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAngleB2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "Calculate the value of\r\nthe opposite side";
            // 
            // buttonCalc2
            // 
            this.buttonCalc2.Location = new System.Drawing.Point(494, 253);
            this.buttonCalc2.Name = "buttonCalc2";
            this.buttonCalc2.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc2.TabIndex = 22;
            this.buttonCalc2.Text = "Calulate";
            this.buttonCalc2.UseVisualStyleBackColor = true;
            this.buttonCalc2.Click += new System.EventHandler(this.buttonCalc2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "side b:";
            // 
            // textBoxSideB2
            // 
            this.textBoxSideB2.Location = new System.Drawing.Point(487, 295);
            this.textBoxSideB2.Name = "textBoxSideB2";
            this.textBoxSideB2.Size = new System.Drawing.Size(100, 20);
            this.textBoxSideB2.TabIndex = 24;
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(507, 328);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(75, 23);
            this.buttonClear2.TabIndex = 25;
            this.buttonClear2.Text = "Clear";
            this.buttonClear2.UseVisualStyleBackColor = true;
            this.buttonClear2.Click += new System.EventHandler(this.buttonClear2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(446, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "EXTRA CREDIT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 404);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonClear2);
            this.Controls.Add(this.textBoxSideB2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonCalc2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxAngleB2);
            this.Controls.Add(this.textBoxSideC2);
            this.Controls.Add(this.textBoxSideA2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSideC);
            this.Controls.Add(this.textBoxAngleC);
            this.Controls.Add(this.textBoxSideB);
            this.Controls.Add(this.textBoxSideA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CS1400 Project 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSideA;
        private System.Windows.Forms.TextBox textBoxSideB;
        private System.Windows.Forms.TextBox textBoxAngleC;
        private System.Windows.Forms.TextBox textBoxSideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSideA2;
        private System.Windows.Forms.TextBox textBoxSideC2;
        private System.Windows.Forms.TextBox textBoxAngleB2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCalc2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSideB2;
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Label label13;
    }
}

