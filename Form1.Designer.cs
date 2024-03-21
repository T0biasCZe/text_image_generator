namespace text_image_generator {
	partial class Form1 {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			button1 = new Button();
			label6 = new Label();
			label7 = new Label();
			panel1 = new Panel();
			radioButton7 = new RadioButton();
			panel_textcolour = new Panel();
			button_textcolour = new Button();
			radioButton_textcolour_custom = new RadioButton();
			radioButton_textcolour_randomplus = new RadioButton();
			radioButton_textcolour_random = new RadioButton();
			resolution_width = new NumericUpDown();
			resolution_height = new NumericUpDown();
			fontDialog1 = new FontDialog();
			textBox_fonttype = new TextBox();
			panel_bkgcolour = new Panel();
			button_bkgcolour = new Button();
			radioButton_bkgcolour_custom = new RadioButton();
			radioButton_bkgcolour_randomplus = new RadioButton();
			radioButton_bkgcolour_random = new RadioButton();
			label8 = new Label();
			colorDialog1 = new ColorDialog();
			numericUpDown_imagecount = new NumericUpDown();
			textBox_outputfolder = new TextBox();
			button_filepicker = new Button();
			numericUpDown_starti = new NumericUpDown();
			label9 = new Label();
			numericUpDown_delay = new NumericUpDown();
			label10 = new Label();
			folderBrowserDialog1 = new FolderBrowserDialog();
			panel2 = new Panel();
			radioButton_text_pixelated = new RadioButton();
			radioButton_text_system = new RadioButton();
			label11 = new Label();
			panel1.SuspendLayout();
			panel_textcolour.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)resolution_width).BeginInit();
			((System.ComponentModel.ISupportInitialize)resolution_height).BeginInit();
			panel_bkgcolour.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_imagecount).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_starti).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_delay).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Public Pixel", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
			label1.ForeColor = Color.White;
			label1.Location = new Point(16, 8);
			label1.Margin = new Padding(8, 0, 8, 0);
			label1.Name = "label1";
			label1.Size = new Size(765, 20);
			label1.TabIndex = 0;
			label1.Text = "Text in image dataset generator 3000";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label2.ForeColor = Color.White;
			label2.Location = new Point(24, 48);
			label2.Name = "label2";
			label2.Size = new Size(150, 13);
			label2.TabIndex = 1;
			label2.Text = "resolution:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label3.ForeColor = Color.White;
			label3.Location = new Point(24, 88);
			label3.Name = "label3";
			label3.Size = new Size(72, 13);
			label3.TabIndex = 2;
			label3.Text = "font:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label4.ForeColor = Color.White;
			label4.Location = new Point(24, 128);
			label4.Name = "label4";
			label4.Size = new Size(163, 13);
			label4.TabIndex = 3;
			label4.Text = "text colour:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label5.ForeColor = Color.White;
			label5.Location = new Point(24, 208);
			label5.Name = "label5";
			label5.Size = new Size(228, 13);
			label5.TabIndex = 4;
			label5.Text = "number of images:";
			// 
			// button1
			// 
			button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
			button1.FlatAppearance.BorderSize = 3;
			button1.FlatStyle = FlatStyle.Popup;
			button1.ForeColor = Color.White;
			button1.Location = new Point(32, 416);
			button1.Name = "button1";
			button1.Size = new Size(128, 32);
			button1.TabIndex = 5;
			button1.Text = "START";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label6.ForeColor = Color.White;
			label6.Location = new Point(24, 248);
			label6.Name = "label6";
			label6.Size = new Size(189, 13);
			label6.TabIndex = 6;
			label6.Text = "output folder:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label7.ForeColor = Color.White;
			label7.Location = new Point(24, 288);
			label7.Name = "label7";
			label7.Size = new Size(137, 13);
			label7.TabIndex = 7;
			label7.Text = "used text:";
			// 
			// panel1
			// 
			panel1.Controls.Add(radioButton7);
			panel1.Location = new Point(176, 280);
			panel1.Name = "panel1";
			panel1.Size = new Size(328, 40);
			panel1.TabIndex = 8;
			// 
			// radioButton7
			// 
			radioButton7.AutoSize = true;
			radioButton7.Checked = true;
			radioButton7.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton7.ForeColor = Color.White;
			radioButton7.Location = new Point(8, 8);
			radioButton7.Name = "radioButton7";
			radioButton7.Size = new Size(143, 16);
			radioButton7.TabIndex = 16;
			radioButton7.TabStop = true;
			radioButton7.Text = "czech dict";
			radioButton7.UseVisualStyleBackColor = true;
			// 
			// panel_textcolour
			// 
			panel_textcolour.Controls.Add(button_textcolour);
			panel_textcolour.Controls.Add(radioButton_textcolour_custom);
			panel_textcolour.Controls.Add(radioButton_textcolour_randomplus);
			panel_textcolour.Controls.Add(radioButton_textcolour_random);
			panel_textcolour.Location = new Point(184, 120);
			panel_textcolour.Name = "panel_textcolour";
			panel_textcolour.Size = new Size(432, 32);
			panel_textcolour.TabIndex = 9;
			// 
			// button_textcolour
			// 
			button_textcolour.BackColor = Color.White;
			button_textcolour.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			button_textcolour.Location = new Point(328, 4);
			button_textcolour.Name = "button_textcolour";
			button_textcolour.Size = new Size(88, 23);
			button_textcolour.TabIndex = 14;
			button_textcolour.Text = "FFFFFF";
			button_textcolour.UseVisualStyleBackColor = false;
			button_textcolour.Click += button_textcolour_Click;
			// 
			// radioButton_textcolour_custom
			// 
			radioButton_textcolour_custom.AutoSize = true;
			radioButton_textcolour_custom.Checked = true;
			radioButton_textcolour_custom.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_textcolour_custom.ForeColor = Color.White;
			radioButton_textcolour_custom.Location = new Point(224, 8);
			radioButton_textcolour_custom.Name = "radioButton_textcolour_custom";
			radioButton_textcolour_custom.Size = new Size(107, 16);
			radioButton_textcolour_custom.TabIndex = 2;
			radioButton_textcolour_custom.TabStop = true;
			radioButton_textcolour_custom.Text = "custom:";
			radioButton_textcolour_custom.UseVisualStyleBackColor = true;
			// 
			// radioButton_textcolour_randomplus
			// 
			radioButton_textcolour_randomplus.AutoSize = true;
			radioButton_textcolour_randomplus.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_textcolour_randomplus.ForeColor = Color.White;
			radioButton_textcolour_randomplus.Location = new Point(104, 8);
			radioButton_textcolour_randomplus.Name = "radioButton_textcolour_randomplus";
			radioButton_textcolour_randomplus.Size = new Size(119, 16);
			radioButton_textcolour_randomplus.TabIndex = 1;
			radioButton_textcolour_randomplus.TabStop = true;
			radioButton_textcolour_randomplus.Text = "random++";
			radioButton_textcolour_randomplus.UseVisualStyleBackColor = true;
			// 
			// radioButton_textcolour_random
			// 
			radioButton_textcolour_random.AutoSize = true;
			radioButton_textcolour_random.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_textcolour_random.ForeColor = Color.White;
			radioButton_textcolour_random.Location = new Point(8, 8);
			radioButton_textcolour_random.Name = "radioButton_textcolour_random";
			radioButton_textcolour_random.Size = new Size(95, 16);
			radioButton_textcolour_random.TabIndex = 0;
			radioButton_textcolour_random.TabStop = true;
			radioButton_textcolour_random.Text = "random";
			radioButton_textcolour_random.UseVisualStyleBackColor = true;
			// 
			// resolution_width
			// 
			resolution_width.Location = new Point(176, 40);
			resolution_width.Margin = new Padding(8, 4, 8, 4);
			resolution_width.Maximum = new decimal(new int[] { 3840, 0, 0, 0 });
			resolution_width.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
			resolution_width.Name = "resolution_width";
			resolution_width.Size = new Size(96, 26);
			resolution_width.TabIndex = 0;
			resolution_width.ThousandsSeparator = true;
			resolution_width.Value = new decimal(new int[] { 928, 0, 0, 0 });
			// 
			// resolution_height
			// 
			resolution_height.Location = new Point(288, 40);
			resolution_height.Margin = new Padding(8, 4, 8, 4);
			resolution_height.Maximum = new decimal(new int[] { 2160, 0, 0, 0 });
			resolution_height.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
			resolution_height.Name = "resolution_height";
			resolution_height.Size = new Size(96, 26);
			resolution_height.TabIndex = 10;
			resolution_height.ThousandsSeparator = true;
			resolution_height.Value = new decimal(new int[] { 576, 0, 0, 0 });
			// 
			// textBox_fonttype
			// 
			textBox_fonttype.Location = new Point(96, 80);
			textBox_fonttype.Name = "textBox_fonttype";
			textBox_fonttype.ReadOnly = true;
			textBox_fonttype.Size = new Size(512, 26);
			textBox_fonttype.TabIndex = 11;
			textBox_fonttype.MouseDoubleClick += textBox_fonttype_MouseDoubleClick;
			// 
			// panel_bkgcolour
			// 
			panel_bkgcolour.Controls.Add(button_bkgcolour);
			panel_bkgcolour.Controls.Add(radioButton_bkgcolour_custom);
			panel_bkgcolour.Controls.Add(radioButton_bkgcolour_randomplus);
			panel_bkgcolour.Controls.Add(radioButton_bkgcolour_random);
			panel_bkgcolour.Location = new Point(184, 160);
			panel_bkgcolour.Name = "panel_bkgcolour";
			panel_bkgcolour.Size = new Size(432, 32);
			panel_bkgcolour.TabIndex = 13;
			// 
			// button_bkgcolour
			// 
			button_bkgcolour.BackColor = Color.FromArgb(0, 128, 255);
			button_bkgcolour.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			button_bkgcolour.ForeColor = Color.White;
			button_bkgcolour.Location = new Point(328, 4);
			button_bkgcolour.Name = "button_bkgcolour";
			button_bkgcolour.Size = new Size(88, 23);
			button_bkgcolour.TabIndex = 15;
			button_bkgcolour.Text = "0080FF";
			button_bkgcolour.UseVisualStyleBackColor = false;
			button_bkgcolour.Click += button_bkgcolour_Click;
			// 
			// radioButton_bkgcolour_custom
			// 
			radioButton_bkgcolour_custom.AutoSize = true;
			radioButton_bkgcolour_custom.Checked = true;
			radioButton_bkgcolour_custom.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_bkgcolour_custom.ForeColor = Color.White;
			radioButton_bkgcolour_custom.Location = new Point(224, 8);
			radioButton_bkgcolour_custom.Name = "radioButton_bkgcolour_custom";
			radioButton_bkgcolour_custom.Size = new Size(107, 16);
			radioButton_bkgcolour_custom.TabIndex = 2;
			radioButton_bkgcolour_custom.TabStop = true;
			radioButton_bkgcolour_custom.Text = "custom:";
			radioButton_bkgcolour_custom.UseVisualStyleBackColor = true;
			// 
			// radioButton_bkgcolour_randomplus
			// 
			radioButton_bkgcolour_randomplus.AutoSize = true;
			radioButton_bkgcolour_randomplus.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_bkgcolour_randomplus.ForeColor = Color.White;
			radioButton_bkgcolour_randomplus.Location = new Point(104, 8);
			radioButton_bkgcolour_randomplus.Name = "radioButton_bkgcolour_randomplus";
			radioButton_bkgcolour_randomplus.Size = new Size(119, 16);
			radioButton_bkgcolour_randomplus.TabIndex = 1;
			radioButton_bkgcolour_randomplus.TabStop = true;
			radioButton_bkgcolour_randomplus.Text = "random++";
			radioButton_bkgcolour_randomplus.UseVisualStyleBackColor = true;
			// 
			// radioButton_bkgcolour_random
			// 
			radioButton_bkgcolour_random.AutoSize = true;
			radioButton_bkgcolour_random.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_bkgcolour_random.ForeColor = Color.White;
			radioButton_bkgcolour_random.Location = new Point(8, 8);
			radioButton_bkgcolour_random.Name = "radioButton_bkgcolour_random";
			radioButton_bkgcolour_random.Size = new Size(95, 16);
			radioButton_bkgcolour_random.TabIndex = 0;
			radioButton_bkgcolour_random.TabStop = true;
			radioButton_bkgcolour_random.Text = "random";
			radioButton_bkgcolour_random.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label8.ForeColor = Color.White;
			label8.Location = new Point(24, 168);
			label8.Name = "label8";
			label8.Size = new Size(150, 13);
			label8.TabIndex = 12;
			label8.Text = "bkg colour:";
			// 
			// numericUpDown_imagecount
			// 
			numericUpDown_imagecount.Location = new Point(256, 202);
			numericUpDown_imagecount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDown_imagecount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown_imagecount.Name = "numericUpDown_imagecount";
			numericUpDown_imagecount.Size = new Size(120, 26);
			numericUpDown_imagecount.TabIndex = 14;
			numericUpDown_imagecount.Value = new decimal(new int[] { 10, 0, 0, 0 });
			// 
			// textBox_outputfolder
			// 
			textBox_outputfolder.Font = new Font("Public Pixel", 8F, FontStyle.Regular, GraphicsUnit.Pixel);
			textBox_outputfolder.Location = new Point(216, 240);
			textBox_outputfolder.MinimumSize = new Size(0, 26);
			textBox_outputfolder.Name = "textBox_outputfolder";
			textBox_outputfolder.Size = new Size(392, 26);
			textBox_outputfolder.TabIndex = 15;
			// 
			// button_filepicker
			// 
			button_filepicker.FlatStyle = FlatStyle.Popup;
			button_filepicker.Location = new Point(608, 240);
			button_filepicker.Name = "button_filepicker";
			button_filepicker.Size = new Size(8, 26);
			button_filepicker.TabIndex = 16;
			button_filepicker.UseVisualStyleBackColor = true;
			button_filepicker.Click += button_filepicker_Click;
			// 
			// numericUpDown_starti
			// 
			numericUpDown_starti.Location = new Point(496, 202);
			numericUpDown_starti.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDown_starti.Name = "numericUpDown_starti";
			numericUpDown_starti.Size = new Size(120, 26);
			numericUpDown_starti.TabIndex = 18;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label9.ForeColor = Color.White;
			label9.Location = new Point(384, 208);
			label9.Name = "label9";
			label9.Size = new Size(111, 13);
			label9.TabIndex = 17;
			label9.Text = "start i:";
			// 
			// numericUpDown_delay
			// 
			numericUpDown_delay.Location = new Point(112, 320);
			numericUpDown_delay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			numericUpDown_delay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDown_delay.Name = "numericUpDown_delay";
			numericUpDown_delay.Size = new Size(120, 26);
			numericUpDown_delay.TabIndex = 20;
			numericUpDown_delay.Value = new decimal(new int[] { 34, 0, 0, 0 });
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label10.ForeColor = Color.White;
			label10.Location = new Point(24, 328);
			label10.Name = "label10";
			label10.Size = new Size(85, 13);
			label10.TabIndex = 19;
			label10.Text = "delay:";
			// 
			// panel2
			// 
			panel2.Controls.Add(radioButton_text_pixelated);
			panel2.Controls.Add(radioButton_text_system);
			panel2.Location = new Point(184, 360);
			panel2.Name = "panel2";
			panel2.Size = new Size(432, 32);
			panel2.TabIndex = 22;
			// 
			// radioButton_text_pixelated
			// 
			radioButton_text_pixelated.AutoSize = true;
			radioButton_text_pixelated.Checked = true;
			radioButton_text_pixelated.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_text_pixelated.ForeColor = Color.White;
			radioButton_text_pixelated.Location = new Point(208, 8);
			radioButton_text_pixelated.Name = "radioButton_text_pixelated";
			radioButton_text_pixelated.Size = new Size(83, 16);
			radioButton_text_pixelated.TabIndex = 1;
			radioButton_text_pixelated.TabStop = true;
			radioButton_text_pixelated.Text = "pixel";
			radioButton_text_pixelated.UseVisualStyleBackColor = true;
			// 
			// radioButton_text_system
			// 
			radioButton_text_system.AutoSize = true;
			radioButton_text_system.Font = new Font("Public Pixel", 9F, FontStyle.Regular, GraphicsUnit.Point);
			radioButton_text_system.ForeColor = Color.White;
			radioButton_text_system.Location = new Point(8, 8);
			radioButton_text_system.Name = "radioButton_text_system";
			radioButton_text_system.Size = new Size(191, 16);
			radioButton_text_system.TabIndex = 0;
			radioButton_text_system.Text = "system default";
			radioButton_text_system.UseVisualStyleBackColor = true;
			radioButton_text_system.CheckedChanged += radioButton_text_system_CheckedChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Public Pixel", 13F, FontStyle.Regular, GraphicsUnit.Pixel);
			label11.ForeColor = Color.White;
			label11.Location = new Point(24, 368);
			label11.Name = "label11";
			label11.Size = new Size(163, 13);
			label11.TabIndex = 21;
			label11.Text = "text render:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(19F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(128, 128, 255);
			ClientSize = new Size(799, 476);
			Controls.Add(panel2);
			Controls.Add(label11);
			Controls.Add(numericUpDown_delay);
			Controls.Add(label10);
			Controls.Add(numericUpDown_starti);
			Controls.Add(label9);
			Controls.Add(button_filepicker);
			Controls.Add(textBox_outputfolder);
			Controls.Add(numericUpDown_imagecount);
			Controls.Add(panel_bkgcolour);
			Controls.Add(label8);
			Controls.Add(textBox_fonttype);
			Controls.Add(resolution_height);
			Controls.Add(resolution_width);
			Controls.Add(panel_textcolour);
			Controls.Add(panel1);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Public Pixel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(8, 4, 8, 4);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel_textcolour.ResumeLayout(false);
			panel_textcolour.PerformLayout();
			((System.ComponentModel.ISupportInitialize)resolution_width).EndInit();
			((System.ComponentModel.ISupportInitialize)resolution_height).EndInit();
			panel_bkgcolour.ResumeLayout(false);
			panel_bkgcolour.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numericUpDown_imagecount).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_starti).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDown_delay).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button button1;
		private Label label6;
		private Label label7;
		private Panel panel1;
		private Panel panel_textcolour;
		private NumericUpDown resolution_width;
		private NumericUpDown resolution_height;
		private FontDialog fontDialog1;
		private TextBox textBox_fonttype;
		private Button button_textcolour;
		private RadioButton radioButton_textcolour_custom;
		private RadioButton radioButton2;
		private RadioButton radioButton_textcolour_random;
		private Panel panel_bkgcolour;
		private Button button_bkgcolour;
		private RadioButton radioButton_bkgcolour_custom;
		private RadioButton radioButton_bkgcolour_randomplus;
		private RadioButton radioButton_bkgcolour_random;
		private Label label8;
		private ColorDialog colorDialog1;
		private NumericUpDown numericUpDown_imagecount;
		private TextBox textBox_outputfolder;
		private Button button_filepicker;
		private RadioButton radioButton7;
		private NumericUpDown numericUpDown_starti;
		private Label label9;
		private RadioButton radioButton_textcolour_randomplus;
		private NumericUpDown numericUpDown_delay;
		private Label label10;
		private FolderBrowserDialog folderBrowserDialog1;
		private Panel panel2;
		private RadioButton radioButton_text_pixelated;
		private RadioButton radioButton_text_system;
		private Label label11;
	}
}