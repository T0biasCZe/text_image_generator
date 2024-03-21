using System.Drawing.Text;
using System.Reflection;

namespace text_image_generator {
	public partial class Form1 : Form {
		public static Font used_font;
		public static Color custom_text_colour = Color.White;
		public static Color custom_background_colour = Color.FromArgb(255, 0, 128, 255);
		public static bool AA = false;
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
			form2.Width = (int)resolution_width.Value;
			form2.Height = (int)resolution_height.Value;
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
				bmp.Save(textBox_outputfolder.Text + "\\" + (i + (int)numericUpDown_starti.Value) + ".png");
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
				while(colour.GetBrightness() > 0.4) {
					r = random.Next(0, 255);
					g = random.Next(0, 255);
					b = random.Next(0, 255);
					colour = Color.FromArgb(r, g, b);
				}
			}
			else {
				while(colour.GetBrightness() < 0.6) {
					r = random.Next(0, 255);
					g = random.Next(0, 255);
					b = random.Next(0, 255);
					colour = Color.FromArgb(r, g, b);
				}
			}
			return colour;
		}

		private void radioButton_text_system_CheckedChanged(object sender, EventArgs e) {
			AA = radioButton_text_system.Checked;
		}
	}
	class LabelEx : System.Windows.Forms.Label {
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) {
			if(!Form1.AA) e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;
			base.OnPaint(e);
		}
	}
}