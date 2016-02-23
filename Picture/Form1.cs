using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
	public partial class FormPicture : Form

	{
		Bitmap bmp;
		public FormPicture()
		{
			InitializeComponent();
			Loadpicture("IMG_20150908_155756.jpg");
		}

		private void OpenPicture_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
		DialogResult result=openFileDialog1.ShowDialog();
			Loadpicture(openFileDialog1.FileName);

		}

		public void Loadpicture (string filename)
		{
			try
			{
				bmp = new Bitmap(Image.FromFile(filename));

				textBoxFileName.Text = filename;
				picture.Image = bmp;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				textBoxFileName.Text = "";
			}


		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			ChangePicture();
		}

		public void ChangePicture ()
		{
			Bitmap res = new Bitmap(bmp);
			for (int y = 0; y < bmp.Height; y++)
			for (int x=0; x<bmp.Width;x++) 
			{
					Color pixel = bmp.GetPixel(x, y);
					if (checkBoxB_W.Checked)
					{
						pixel = ChangeGrayScale( pixel);
					}


					res.SetPixel(x, y, pixel);

			}

			picture.Image = res;

		}

		private Color ChangeGrayScale( Color pixel)
		{
			int avgColor = (pixel.R + pixel.G + pixel.B + 1) / 3;
			return Color.FromArgb(avgColor, avgColor, avgColor);
		}
	}
}
