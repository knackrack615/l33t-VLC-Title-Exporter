namespace l33t_VLC_Title_Exporter
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
            this.settings_box = new System.Windows.Forms.GroupBox();
            this.check_interval_slider = new System.Windows.Forms.TrackBar();
            this.interval_box = new System.Windows.Forms.TextBox();
            this.check_interval = new System.Windows.Forms.Timer(this.components);
            this.console_box = new System.Windows.Forms.GroupBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.save_inverval = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filepath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.settings_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_interval_slider)).BeginInit();
            this.console_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settings_box
            // 
            this.settings_box.Controls.Add(this.label1);
            this.settings_box.Controls.Add(this.filepath);
            this.settings_box.Controls.Add(this.save_inverval);
            this.settings_box.Controls.Add(this.interval_box);
            this.settings_box.Controls.Add(this.check_interval_slider);
            this.settings_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.settings_box.Location = new System.Drawing.Point(12, 12);
            this.settings_box.Name = "settings_box";
            this.settings_box.Size = new System.Drawing.Size(237, 166);
            this.settings_box.TabIndex = 0;
            this.settings_box.TabStop = false;
            this.settings_box.Text = "Settings";
            // 
            // check_interval_slider
            // 
            this.check_interval_slider.Location = new System.Drawing.Point(6, 67);
            this.check_interval_slider.Maximum = 5000;
            this.check_interval_slider.Minimum = 150;
            this.check_interval_slider.Name = "check_interval_slider";
            this.check_interval_slider.Size = new System.Drawing.Size(226, 45);
            this.check_interval_slider.TabIndex = 1;
            this.check_interval_slider.Value = 1000;
            this.check_interval_slider.Scroll += new System.EventHandler(this.check_interval_slider_Scroll);
            // 
            // interval_box
            // 
            this.interval_box.Location = new System.Drawing.Point(6, 32);
            this.interval_box.Name = "interval_box";
            this.interval_box.ReadOnly = true;
            this.interval_box.Size = new System.Drawing.Size(117, 20);
            this.interval_box.TabIndex = 2;
            this.interval_box.Text = "1000   ms";
            // 
            // check_interval
            // 
            this.check_interval.Tick += new System.EventHandler(this.check_interval_Tick);
            // 
            // console_box
            // 
            this.console_box.Controls.Add(this.console);
            this.console_box.Location = new System.Drawing.Point(12, 198);
            this.console_box.Name = "console_box";
            this.console_box.Size = new System.Drawing.Size(443, 172);
            this.console_box.TabIndex = 1;
            this.console_box.TabStop = false;
            this.console_box.Text = "Console";
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.White;
            this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.console.Location = new System.Drawing.Point(6, 19);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(431, 147);
            this.console.TabIndex = 0;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // save_inverval
            // 
            this.save_inverval.Location = new System.Drawing.Point(138, 30);
            this.save_inverval.Name = "save_inverval";
            this.save_inverval.Size = new System.Drawing.Size(93, 23);
            this.save_inverval.TabIndex = 3;
            this.save_inverval.Text = "Save";
            this.save_inverval.UseVisualStyleBackColor = true;
            this.save_inverval.Click += new System.EventHandler(this.save_inverval_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(305, 108);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(96, 38);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::l33t_VLC_Title_Exporter.Properties.Resources.VLC_Icon_svg;
            this.pictureBox1.Location = new System.Drawing.Point(305, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(6, 128);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(225, 20);
            this.filepath.TabIndex = 4;
            this.filepath.Text = "VLCTitle.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Save to file path";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(305, 152);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(96, 23);
            this.reset.TabIndex = 4;
            this.reset.Text = "Reset file";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 387);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.console_box);
            this.Controls.Add(this.settings_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximumSize = new System.Drawing.Size(483, 426);
            this.MinimumSize = new System.Drawing.Size(483, 426);
            this.Name = "Form1";
            this.Text = "l33t VLC Title Exporter";
            this.settings_box.ResumeLayout(false);
            this.settings_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_interval_slider)).EndInit();
            this.console_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settings_box;
        private System.Windows.Forms.TextBox interval_box;
        private System.Windows.Forms.TrackBar check_interval_slider;
        private System.Windows.Forms.Timer check_interval;
        private System.Windows.Forms.GroupBox console_box;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Button save_inverval;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button reset;
    }
}

