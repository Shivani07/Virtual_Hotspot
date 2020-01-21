namespace Virtual_Hotspot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play_Stop_b1 = new System.Windows.Forms.Button();
            this.SSID_tb1 = new System.Windows.Forms.TextBox();
            this.Pass_tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secs_lbl3 = new System.Windows.Forms.Label();
            this.mins_lbl2 = new System.Windows.Forms.Label();
            this.hours_lbl1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.process_ProgressB1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play_Stop_b1
            // 
            this.Play_Stop_b1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Play_Stop_b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Play_Stop_b1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Stop_b1.ForeColor = System.Drawing.Color.Black;
            this.Play_Stop_b1.Location = new System.Drawing.Point(167, 121);
            this.Play_Stop_b1.Name = "Play_Stop_b1";
            this.Play_Stop_b1.Size = new System.Drawing.Size(108, 38);
            this.Play_Stop_b1.TabIndex = 0;
            this.Play_Stop_b1.Text = "Start";
            this.Play_Stop_b1.UseVisualStyleBackColor = true;
            this.Play_Stop_b1.Click += new System.EventHandler(this.Play_Stop_b1_Click);
            // 
            // SSID_tb1
            // 
            this.SSID_tb1.BackColor = System.Drawing.Color.Black;
            this.SSID_tb1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSID_tb1.ForeColor = System.Drawing.Color.White;
            this.SSID_tb1.Location = new System.Drawing.Point(144, 32);
            this.SSID_tb1.Name = "SSID_tb1";
            this.SSID_tb1.Size = new System.Drawing.Size(220, 25);
            this.SSID_tb1.TabIndex = 1;
            // 
            // Pass_tb2
            // 
            this.Pass_tb2.BackColor = System.Drawing.Color.Black;
            this.Pass_tb2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_tb2.ForeColor = System.Drawing.Color.White;
            this.Pass_tb2.Location = new System.Drawing.Point(145, 68);
            this.Pass_tb2.Name = "Pass_tb2";
            this.Pass_tb2.Size = new System.Drawing.Size(219, 25);
            this.Pass_tb2.TabIndex = 2;
            this.Pass_tb2.TextChanged += new System.EventHandler(this.Pass_tb2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(74, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SSID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.secs_lbl3);
            this.panel1.Controls.Add(this.mins_lbl2);
            this.panel1.Controls.Add(this.hours_lbl1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pass_tb2);
            this.panel1.Controls.Add(this.SSID_tb1);
            this.panel1.Controls.Add(this.Play_Stop_b1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 226);
            this.panel1.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(147, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(348, 1);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(194, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(164, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // secs_lbl3
            // 
            this.secs_lbl3.AutoSize = true;
            this.secs_lbl3.BackColor = System.Drawing.Color.Transparent;
            this.secs_lbl3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secs_lbl3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.secs_lbl3.Location = new System.Drawing.Point(204, 190);
            this.secs_lbl3.Name = "secs_lbl3";
            this.secs_lbl3.Size = new System.Drawing.Size(26, 17);
            this.secs_lbl3.TabIndex = 7;
            this.secs_lbl3.Text = "00";
            // 
            // mins_lbl2
            // 
            this.mins_lbl2.AutoSize = true;
            this.mins_lbl2.BackColor = System.Drawing.Color.Transparent;
            this.mins_lbl2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mins_lbl2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mins_lbl2.Location = new System.Drawing.Point(174, 190);
            this.mins_lbl2.Name = "mins_lbl2";
            this.mins_lbl2.Size = new System.Drawing.Size(26, 17);
            this.mins_lbl2.TabIndex = 6;
            this.mins_lbl2.Text = "00";
            // 
            // hours_lbl1
            // 
            this.hours_lbl1.AutoSize = true;
            this.hours_lbl1.BackColor = System.Drawing.Color.Transparent;
            this.hours_lbl1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_lbl1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.hours_lbl1.Location = new System.Drawing.Point(143, 190);
            this.hours_lbl1.Name = "hours_lbl1";
            this.hours_lbl1.Size = new System.Drawing.Size(34, 17);
            this.hours_lbl1.TabIndex = 5;
            this.hours_lbl1.Text = "00  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(13, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Connected Time :";
            // 
            // process_ProgressB1
            // 
            this.process_ProgressB1.Location = new System.Drawing.Point(64, 93);
            this.process_ProgressB1.Name = "process_ProgressB1";
            this.process_ProgressB1.Size = new System.Drawing.Size(296, 25);
            this.process_ProgressB1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(318, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 226);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.process_ProgressB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotspot";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play_Stop_b1;
        private System.Windows.Forms.TextBox SSID_tb1;
        private System.Windows.Forms.TextBox Pass_tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar process_ProgressB1;
        private System.Windows.Forms.Label hours_lbl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label secs_lbl3;
        private System.Windows.Forms.Label mins_lbl2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}

