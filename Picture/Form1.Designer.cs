namespace Picture
{
	partial class FormPicture
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPicture));
			this.picture = new System.Windows.Forms.PictureBox();
			this.OpenPicture = new System.Windows.Forms.Button();
			this.textBoxFileName = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.FiltresTitle = new System.Windows.Forms.TextBox();
			this.buttonApply = new System.Windows.Forms.Button();
			this.checkBoxB_W = new System.Windows.Forms.CheckBox();
			this.trackBarBrightness = new System.Windows.Forms.TrackBar();
			this.labelBrightness = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
			this.SuspendLayout();
			// 
			// picture
			// 
			this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picture.Location = new System.Drawing.Point(12, 3);
			this.picture.Name = "picture";
			this.picture.Size = new System.Drawing.Size(777, 650);
			this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picture.TabIndex = 0;
			this.picture.TabStop = false;
			// 
			// OpenPicture
			// 
			this.OpenPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenPicture.Location = new System.Drawing.Point(795, 3);
			this.OpenPicture.Name = "OpenPicture";
			this.OpenPicture.Size = new System.Drawing.Size(213, 60);
			this.OpenPicture.TabIndex = 1;
			this.OpenPicture.Text = "Open Picture";
			this.OpenPicture.UseVisualStyleBackColor = true;
			this.OpenPicture.Click += new System.EventHandler(this.OpenPicture_Click);
			// 
			// textBoxFileName
			// 
			this.textBoxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFileName.Location = new System.Drawing.Point(796, 70);
			this.textBoxFileName.Name = "textBoxFileName";
			this.textBoxFileName.ReadOnly = true;
			this.textBoxFileName.Size = new System.Drawing.Size(212, 20);
			this.textBoxFileName.TabIndex = 2;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// FiltresTitle
			// 
			this.FiltresTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FiltresTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FiltresTitle.Location = new System.Drawing.Point(796, 154);
			this.FiltresTitle.Name = "FiltresTitle";
			this.FiltresTitle.ReadOnly = true;
			this.FiltresTitle.Size = new System.Drawing.Size(212, 20);
			this.FiltresTitle.TabIndex = 3;
			this.FiltresTitle.Text = " FILTERS";
			this.FiltresTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonApply.Location = new System.Drawing.Point(849, 551);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(147, 92);
			this.buttonApply.TabIndex = 4;
			this.buttonApply.Text = "APPLY";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// checkBoxB_W
			// 
			this.checkBoxB_W.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxB_W.AutoSize = true;
			this.checkBoxB_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxB_W.Location = new System.Drawing.Point(796, 190);
			this.checkBoxB_W.Name = "checkBoxB_W";
			this.checkBoxB_W.Size = new System.Drawing.Size(128, 17);
			this.checkBoxB_W.TabIndex = 5;
			this.checkBoxB_W.Text = "Black  and  White";
			this.checkBoxB_W.UseVisualStyleBackColor = true;
			// 
			// trackBarBrightness
			// 
			this.trackBarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBarBrightness.LargeChange = 10;
			this.trackBarBrightness.Location = new System.Drawing.Point(796, 253);
			this.trackBarBrightness.Maximum = 50;
			this.trackBarBrightness.Minimum = -50;
			this.trackBarBrightness.Name = "trackBarBrightness";
			this.trackBarBrightness.Size = new System.Drawing.Size(212, 45);
			this.trackBarBrightness.TabIndex = 6;
			this.trackBarBrightness.TickFrequency = 10;
			this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
			// 
			// labelBrightness
			// 
			this.labelBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBrightness.Location = new System.Drawing.Point(796, 227);
			this.labelBrightness.Name = "labelBrightness";
			this.labelBrightness.Size = new System.Drawing.Size(212, 23);
			this.labelBrightness.TabIndex = 7;
			this.labelBrightness.Text = "CHANGE BRIGHTNESS";
			this.labelBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormPicture
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 665);
			this.Controls.Add(this.labelBrightness);
			this.Controls.Add(this.trackBarBrightness);
			this.Controls.Add(this.checkBoxB_W);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.FiltresTitle);
			this.Controls.Add(this.textBoxFileName);
			this.Controls.Add(this.OpenPicture);
			this.Controls.Add(this.picture);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPicture";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pixel  transformation";
			((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picture;
		private System.Windows.Forms.Button OpenPicture;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox FiltresTitle;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.CheckBox checkBoxB_W;
		private System.Windows.Forms.TrackBar trackBarBrightness;
		private System.Windows.Forms.Label labelBrightness;
	}
}

