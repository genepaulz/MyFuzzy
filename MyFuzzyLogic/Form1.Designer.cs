namespace MyFuzzyLogic
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
            this.DispenseHottrackBar = new System.Windows.Forms.TrackBar();
            this.DispenseWarmtrackBar = new System.Windows.Forms.TrackBar();
            this.DispenseColdtrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTanktextBox = new System.Windows.Forms.TextBox();
            this.TMainTanktextBox = new System.Windows.Forms.TextBox();
            this.HotTanktextBox = new System.Windows.Forms.TextBox();
            this.THotTanktextBox = new System.Windows.Forms.TextBox();
            this.ColdTanktextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TColdTanktextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TankRefilSpeedtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeatertextBox = new System.Windows.Forms.TextBox();
            this.CoolertextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CreateFuzzyLogic = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseHottrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseWarmtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseColdtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DispenseHottrackBar
            // 
            this.DispenseHottrackBar.Location = new System.Drawing.Point(96, 234);
            this.DispenseHottrackBar.Maximum = 15;
            this.DispenseHottrackBar.Name = "DispenseHottrackBar";
            this.DispenseHottrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DispenseHottrackBar.Size = new System.Drawing.Size(45, 104);
            this.DispenseHottrackBar.SmallChange = 5;
            this.DispenseHottrackBar.TabIndex = 9;
            this.DispenseHottrackBar.TickFrequency = 5;
            this.DispenseHottrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.DispenseHottrackBar.Value = 15;
            this.DispenseHottrackBar.ValueChanged += new System.EventHandler(this.DispenseHottrackBar_ValueChanged);
            // 
            // DispenseWarmtrackBar
            // 
            this.DispenseWarmtrackBar.Location = new System.Drawing.Point(184, 234);
            this.DispenseWarmtrackBar.Maximum = 15;
            this.DispenseWarmtrackBar.Name = "DispenseWarmtrackBar";
            this.DispenseWarmtrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DispenseWarmtrackBar.Size = new System.Drawing.Size(45, 104);
            this.DispenseWarmtrackBar.SmallChange = 5;
            this.DispenseWarmtrackBar.TabIndex = 10;
            this.DispenseWarmtrackBar.TickFrequency = 5;
            this.DispenseWarmtrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.DispenseWarmtrackBar.Value = 15;
            // 
            // DispenseColdtrackBar
            // 
            this.DispenseColdtrackBar.Location = new System.Drawing.Point(272, 234);
            this.DispenseColdtrackBar.Maximum = 15;
            this.DispenseColdtrackBar.Name = "DispenseColdtrackBar";
            this.DispenseColdtrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DispenseColdtrackBar.Size = new System.Drawing.Size(45, 104);
            this.DispenseColdtrackBar.SmallChange = 5;
            this.DispenseColdtrackBar.TabIndex = 11;
            this.DispenseColdtrackBar.TickFrequency = 5;
            this.DispenseColdtrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.DispenseColdtrackBar.Value = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "WARM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "COLD";
            // 
            // MainTanktextBox
            // 
            this.MainTanktextBox.Location = new System.Drawing.Point(95, 44);
            this.MainTanktextBox.Name = "MainTanktextBox";
            this.MainTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.MainTanktextBox.TabIndex = 0;
            this.MainTanktextBox.Text = "18927.1";
            // 
            // TMainTanktextBox
            // 
            this.TMainTanktextBox.Location = new System.Drawing.Point(95, 70);
            this.TMainTanktextBox.Name = "TMainTanktextBox";
            this.TMainTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.TMainTanktextBox.TabIndex = 2;
            this.TMainTanktextBox.Text = "26.6";
            // 
            // HotTanktextBox
            // 
            this.HotTanktextBox.Location = new System.Drawing.Point(95, 116);
            this.HotTanktextBox.Name = "HotTanktextBox";
            this.HotTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.HotTanktextBox.TabIndex = 3;
            this.HotTanktextBox.Text = "500";
            // 
            // THotTanktextBox
            // 
            this.THotTanktextBox.Location = new System.Drawing.Point(95, 142);
            this.THotTanktextBox.Name = "THotTanktextBox";
            this.THotTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.THotTanktextBox.TabIndex = 4;
            this.THotTanktextBox.Text = "94";
            // 
            // ColdTanktextBox
            // 
            this.ColdTanktextBox.Location = new System.Drawing.Point(292, 116);
            this.ColdTanktextBox.Name = "ColdTanktextBox";
            this.ColdTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.ColdTanktextBox.TabIndex = 6;
            this.ColdTanktextBox.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Main Tank (ml)";
            // 
            // TColdTanktextBox
            // 
            this.TColdTanktextBox.Location = new System.Drawing.Point(292, 142);
            this.TColdTanktextBox.Name = "TColdTanktextBox";
            this.TColdTanktextBox.Size = new System.Drawing.Size(100, 20);
            this.TColdTanktextBox.TabIndex = 7;
            this.TColdTanktextBox.Text = "13";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hot Tank (ml)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Temperature";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cold Tank (ml)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Temperature";
            // 
            // TankRefilSpeedtextBox
            // 
            this.TankRefilSpeedtextBox.Location = new System.Drawing.Point(326, 44);
            this.TankRefilSpeedtextBox.Name = "TankRefilSpeedtextBox";
            this.TankRefilSpeedtextBox.Size = new System.Drawing.Size(100, 20);
            this.TankRefilSpeedtextBox.TabIndex = 1;
            this.TankRefilSpeedtextBox.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tank Refil Speed (ml)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFuzzyLogic.Properties.Resources.pullthelever;
            this.pictureBox1.Location = new System.Drawing.Point(411, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // HeatertextBox
            // 
            this.HeatertextBox.Location = new System.Drawing.Point(95, 168);
            this.HeatertextBox.Name = "HeatertextBox";
            this.HeatertextBox.Size = new System.Drawing.Size(100, 20);
            this.HeatertextBox.TabIndex = 5;
            // 
            // CoolertextBox
            // 
            this.CoolertextBox.Location = new System.Drawing.Point(292, 168);
            this.CoolertextBox.Name = "CoolertextBox";
            this.CoolertextBox.Size = new System.Drawing.Size(100, 20);
            this.CoolertextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Heater Output";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Cooler Output";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFuzzyLogic});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CreateFuzzyLogic
            // 
            this.CreateFuzzyLogic.Name = "CreateFuzzyLogic";
            this.CreateFuzzyLogic.Size = new System.Drawing.Size(117, 20);
            this.CreateFuzzyLogic.Text = "Create Fuzzy Logic";
            this.CreateFuzzyLogic.Click += new System.EventHandler(this.CreateFuzzyLogic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 356);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CoolertextBox);
            this.Controls.Add(this.HeatertextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TankRefilSpeedtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TColdTanktextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColdTanktextBox);
            this.Controls.Add(this.THotTanktextBox);
            this.Controls.Add(this.HotTanktextBox);
            this.Controls.Add(this.TMainTanktextBox);
            this.Controls.Add(this.MainTanktextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DispenseColdtrackBar);
            this.Controls.Add(this.DispenseWarmtrackBar);
            this.Controls.Add(this.DispenseHottrackBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Zafra Tamad Water Dispenser Simulator w/ Fuzzy Logic controls";
            ((System.ComponentModel.ISupportInitialize)(this.DispenseHottrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseWarmtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseColdtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar DispenseHottrackBar;
        private System.Windows.Forms.TrackBar DispenseWarmtrackBar;
        private System.Windows.Forms.TrackBar DispenseColdtrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MainTanktextBox;
        private System.Windows.Forms.TextBox TMainTanktextBox;
        private System.Windows.Forms.TextBox HotTanktextBox;
        private System.Windows.Forms.TextBox THotTanktextBox;
        private System.Windows.Forms.TextBox ColdTanktextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TColdTanktextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TankRefilSpeedtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox HeatertextBox;
        private System.Windows.Forms.TextBox CoolertextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateFuzzyLogic;
    }
}

