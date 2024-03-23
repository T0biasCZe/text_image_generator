using System.Drawing.Text;
using System.Reflection;

namespace text_image_generator {
	public partial class Form1 : Form {
		public static Font used_font;
		public static Color custom_text_colour = Color.White;
		public static Color custom_background_colour = Color.FromArgb(255, 0, 128, 255);
		public static TextRenderingHint AA = TextRenderingHint.SingleBitPerPixel;
		public Form1() {
			InitializeComponent();

			used_font = new Font("PUBLIC PIXEL", 18, FontStyle.Regular);

			textBox_fonttype.Text = used_font.Name + " " + used_font.SizeInPoints;

			if(Directory.Exists("Z:\\knihovny\\Fotky\\training photos\\text")) {
				textBox_outputfolder.Text = "Z:\\knihovny\\Fotky\\training photos\\text";
			}
			else {
				textBox_outputfolder.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				Directory.CreateDirectory(textBox_outputfolder.Text + "\\generatedtext");
			}
		}

		private void button_filepicker_Click(object sender, EventArgs e) {
			var result = folderBrowserDialog1.ShowDialog();
			if(result == DialogResult.OK) {
				textBox_outputfolder.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void textBox_fonttype_MouseDoubleClick(object sender, MouseEventArgs e) {
			fontDialog1.Font = used_font;
			var result = fontDialog1.ShowDialog();
			if(result == DialogResult.OK) {
				textBox_fonttype.Text = fontDialog1.Font.Name + " " + fontDialog1.Font.SizeInPoints;
				textBox_fonttype.Font = fontDialog1.Font;
				used_font = fontDialog1.Font;
			}
		}

		private void button_textcolour_Click(object sender, EventArgs e) {
			var result = colorDialog1.ShowDialog();
			if(result == DialogResult.OK) {
				button_textcolour.BackColor = colorDialog1.Color;
				button_textcolour.ForeColor = colorDialog1.Color.GetBrightness() < 0.5 ? Color.White : Color.Black;

				string hex = colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");
				button_textcolour.Text = hex;

				custom_text_colour = colorDialog1.Color;
			}
		}

		private void button_bkgcolour_Click(object sender, EventArgs e) {
			var result = colorDialog1.ShowDialog();
			if(result == DialogResult.OK) {
				button_bkgcolour.BackColor = colorDialog1.Color;
				button_bkgcolour.ForeColor = colorDialog1.Color.GetBrightness() < 0.5 ? Color.White : Color.Black;
				string hex = colorDialog1.Color.R.ToString("X2") + colorDialog1.Color.G.ToString("X2") + colorDialog1.Color.B.ToString("X2");
				button_bkgcolour.Text = hex;
				custom_background_colour = colorDialog1.Color;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			if(!Directory.Exists(textBox_outputfolder.Text)) {
				MessageBox.Show("Invalid output folder path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Random rand = new Random();
			Form form2 = new Form();
			form2.Width = (int)numericUpDown_width.Value;
			form2.Height = (int)numericUpDown_height.Value;
			form2.FormBorderStyle = FormBorderStyle.None;
			form2.Show();
			form2.ShowInTaskbar = false;
			form2.TopMost = true;

			//load embedded resource "cz_dict.csv" and split it into array by new line
			string dict = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("text_image_generator.cz_dict.csv")).ReadToEnd();
			string[] lines = dict.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

			//create label with 10-20 random words from dictionary and random position. it should text wrap and be transparent
			Random random = new Random();
			for(int i = 0; i < numericUpDown_imagecount.Value; i++) {
				form2.Controls.Clear();

				Color background_colour, foreground_colour;
				//check if background colour is set to random, randomplus or custom
				if(radioButton_bkgcolour_random.Checked) {
					background_colour = generate_colour(rand.Next(0, 1) == 0);
				}
				else if(radioButton_bkgcolour_randomplus.Checked) {
					if(radioButton_textcolour_custom.Checked) {
						background_colour = generate_colour(custom_text_colour.GetBrightness() > 0.5f);
					}
					else {
						background_colour = generate_colour(rand.Next(0, 1) == 0);
					}
				}
				else {
					background_colour = custom_background_colour;
				}

				if(radioButton_textcolour_random.Checked) {
					foreground_colour = generate_colour(rand.Next(0, 1) == 0);
				}
				else if(radioButton_textcolour_custom.Checked) {
					foreground_colour = custom_text_colour;
				}
				else {
					foreground_colour = generate_colour(background_colour.GetBrightness() > 0.5f);
				}

				form2.BackColor = background_colour;
				form2.ForeColor = background_colour;


				for(int j = 0; j < random.Next(10, 20); j++) {
					LabelEx label = new LabelEx();
					label.AutoSize = true;
					label.Text = lines[random.Next(0, lines.Length)];
					label.Font = used_font;
					label.ForeColor = foreground_colour;
					label.BackColor = Color.Transparent;
					label.Location = new Point(random.Next(0, form2.Width), random.Next(0, form2.Height));
					label.MaximumSize = new Size(form2.Width, 0);
					form2.Controls.Add(label);
				}

				form2.Invalidate();
				form2.Update();

				//take screenshot of form and save it to png with name of current "i" value + numericUpDown_starti.Value
				Bitmap bmp = new Bitmap(form2.Width, form2.Height);
				form2.DrawToBitmap(bmp, new Rectangle(0, 0, form2.Width, form2.Height));
				bmp.Save(textBox_outputfolder.Text + "\\" + (i + (int)numericUpDown_starti.Value).ToString("D4") + ".png");
				//delete all contents of form

				Thread.Sleep((int)numericUpDown_delay.Value);
			}
			form2.Close();
		}
		private Color generate_colour(bool is_dark) {
			Random random = new Random();
			int r = random.Next(0, 255);
			int g = random.Next(0, 255);
			int b = random.Next(0, 255);
			Color colour = Color.FromArgb(r, g, b);
			if(is_dark) {
				while(colour.GetBrightness() > 1 - (float)trackBar1.Value / 100) {
					r = random.Next(0, 255);
					g = random.Next(0, 255);
					b = random.Next(0, 255);
					colour = Color.FromArgb(r, g, b);
				}
			}
			else {
				while(colour.GetBrightness() < (float)trackBar1.Value / 100) {
					r = random.Next(0, 255);
					g = random.Next(0, 255);
					b = random.Next(0, 255);
					colour = Color.FromArgb(r, g, b);
				}
			}
			return colour;
		}

		private void radioButton_text_system_CheckedChanged(object sender, EventArgs e) {
			if(!(sender as RadioButton).Checked) return;

			if(radioButton_text_system.Checked) AA = TextRenderingHint.ClearTypeGridFit;
			else if(radioButton_text_pixelated.Checked) AA = TextRenderingHint.SingleBitPerPixel;
			else if(radioButton_text_grayscale.Checked) AA = TextRenderingHint.AntiAliasGridFit;
			this.Invalidate();
			this.Update();
			this.Refresh();
		}

		private void Form1_Load(object sender, EventArgs e) {

		}

		private void button_batch_Click(object sender, EventArgs e) {
			Form form2 = new Form();
			RichTextWithBanner textBox_batch_command = new RichTextWithBanner();
			Button button_startbatch = new Button();

			form2.Text = "ENTER BATCH INSTRUCTIONS";

			form2.Resize += (sender2, e2) => {
				textBox_batch_command.Size = new Size(form2.Width - 35, form2.Height - 100);
				button_startbatch.Top = form2.Height - 80;
				button_startbatch.Left = form2.Width - 100;
			};
			form2.Size = new Size(420, 300);

			textBox_batch_command.BannerText = "width;height;font name;font size;foreground_type;custom_foreground;\nbackground_type;custom_background;count;starti;AA_type";
			textBox_batch_command.Top = 10;
			textBox_batch_command.Left = 10;
			textBox_batch_command.ForeColor = Color.Black;
			form2.Controls.Add(textBox_batch_command);
			button_startbatch.Text = "START";
			button_startbatch.FlatStyle = FlatStyle.Popup;
			form2.Controls.Add(button_startbatch);
			form2.Show();

			button_startbatch.Click += (sender, e) => {
				MessageBox.Show("Batch started");
				var commands = new List<Command>();
				var lines = textBox_batch_command.Text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

				foreach(var line in lines) {
					var parts = line.Split(';');
					if(parts.Length >= 11) {
						var command = new Command {
							width = int.Parse(parts[0]),
							height = int.Parse(parts[1]),
							font = new Font(parts[2], float.Parse(parts[3])),
							foreground_type = (color_select)int.Parse(parts[4]),
							custom_foreground = ColorTranslator.FromHtml(parts[5]),
							background_type = (color_select)int.Parse(parts[6]),
							custom_background = ColorTranslator.FromHtml(parts[7]),
							count = int.Parse(parts[8]),
							starti = int.Parse(parts[9]),
							AA_type = (TextRenderingHint)int.Parse(parts[10])
						};
						if(command.font == null) {
							var result = MessageBox.Show("Font not found. Continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
							if(result == DialogResult.No) return;
						}
						commands.Add(command);
					}
				}
				foreach(var command in commands) {
					//set all checkboxes etc inside Form1 (this.) to values from the command
					used_font = command.font;
					if(command.AA_type == TextRenderingHint.ClearTypeGridFit) radioButton_text_system.Checked = true;
					else if(command.AA_type == TextRenderingHint.SingleBitPerPixel) radioButton_text_pixelated.Checked = true;
					else if(command.AA_type == TextRenderingHint.AntiAliasGridFit) radioButton_text_grayscale.Checked = true;
					AA = command.AA_type;

					numericUpDown_width.Value = command.width;
					numericUpDown_height.Value = command.height;
					numericUpDown_imagecount.Value = command.count;
					numericUpDown_starti.Value = command.starti;
					//check the correct checkbox based on foreground_type
					if(command.foreground_type == color_select.random) radioButton_textcolour_random.Checked = true;
					else if(command.foreground_type == color_select.randompp) radioButton_textcolour_randomplus.Checked = true;
					else if(command.foreground_type == color_select.custom) {
						radioButton_textcolour_custom.Checked = true;
						button_textcolour.BackColor = command.custom_foreground;
						custom_text_colour = command.custom_foreground;
					}
					if(command.background_type == color_select.random) radioButton_bkgcolour_random.Checked = true;
					else if(command.background_type == color_select.randompp) radioButton_bkgcolour_randomplus.Checked = true;
					else if(command.background_type == color_select.custom) {
						radioButton_bkgcolour_custom.Checked = true;
						button_bkgcolour.BackColor = command.custom_background;
						custom_background_colour = command.custom_background;
					}

					this.Invalidate();
					this.Update();
					this.Refresh();

					button1_Click(null, null);
				}
			};

		}
		private enum color_select { random, randompp, custom }

		private class Command {
			public int width; //width of generated image
			public int height; //height of generated image
			public Font font; //font of text
			public color_select foreground_type; //how pick colour of text
			public Color custom_foreground; //if foreground_type is set to custom this will be used
			public color_select background_type; //how pick colour of background
			public Color custom_background; //if foreground_type is set to custom this will be used
			public int count; //how many images to generate
			public int starti; //start number of images
			public TextRenderingHint AA_type; //how to render text
		}

		private void trackBar1_ValueChanged(object sender, EventArgs e) {
			//move labelEx_trackbar_value horizontally to trackbar1.Value
			labelEx_trackbar_value.Left = trackBar1.Left + trackBar1.Value * (trackBar1.Width - labelEx_trackbar_value.Width) / trackBar1.Maximum;
			labelEx_trackbar_value.Text = ((float)trackBar1.Value / 100).ToString();
		}

		private void trackBar_labelcount_max_ValueChanged(object sender, EventArgs e) {
			if(trackBar_labelcount_max.Value < trackBar_labelcount_min.Value) {
				trackBar_labelcount_max.Value = trackBar_labelcount_min.Value;
			}
			labelEx_trackbar_value_max.Left = trackBar_labelcount_max.Left + trackBar_labelcount_max.Value * (trackBar_labelcount_max.Width - labelEx_trackbar_value_max.Width) / trackBar_labelcount_max.Maximum;
			labelEx_trackbar_value_max.Text = trackBar_labelcount_max.Value.ToString();
		}

		private void trackBar_labelcount_min_ValueChanged(object sender, EventArgs e) {
			if(trackBar_labelcount_min.Value > trackBar_labelcount_max.Value) {
				trackBar_labelcount_min.Value = trackBar_labelcount_max.Value;
			}
			labelEx_trackbar_value_min.Left = trackBar_labelcount_min.Left + trackBar_labelcount_min.Value * (trackBar_labelcount_min.Width - labelEx_trackbar_value_min.Width) / trackBar_labelcount_min.Maximum;
			labelEx_trackbar_value_min.Text = trackBar_labelcount_min.Value.ToString();
		}
	}
	class LabelEx : System.Windows.Forms.Label {
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
			e.Graphics.TextRenderingHint = Form1.AA;
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 0, 0);
		}
	}
	public class TextBoxEx : System.Windows.Forms.TextBox {
		public TextBoxEx() : base() {
			this.SetStyle(ControlStyles.UserPaint, true);
		}
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
			base.OnPaint(e);
			e.Graphics.TextRenderingHint = Form1.AA;
			e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), 0, 0);
		}
	}
	public class RichTextWithBanner : RichTextBox {
		private const int WM_PAINT = 0xF;
		public string BannerText { get; set; } = "";

		protected override void OnTextChanged(EventArgs e) {
			base.OnTextChanged(e);
			this.Invalidate();
		}

		protected override void WndProc(ref Message m) {
			base.WndProc(ref m);
			if(m.Msg == WM_PAINT && this.Text == string.Empty) {
				using(Graphics g = Graphics.FromHwnd(m.HWnd)) {
					TextRenderer.DrawText(g, BannerText, this.Font,
						this.ClientRectangle, Color.DarkGray, Color.Empty,
						TextFormatFlags.Left | TextFormatFlags.Top);
				}
			}
		}
	}
}