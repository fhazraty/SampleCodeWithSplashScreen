namespace SampleCodeWithSplashScreen
{
    partial class SplashScreen
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
			pictureBox1 = new PictureBox();
			progressBar1 = new ProgressBar();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = Properties.Resources.b35341f9ae18564b1315c83945c3bd08;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(799, 596);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// progressBar1
			// 
			progressBar1.Location = new Point(12, 561);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(100, 23);
			progressBar1.TabIndex = 1;
			// 
			// SplashScreen
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(799, 596);
			Controls.Add(progressBar1);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "SplashScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SplashScreen";
			Load += SplashScreen_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pictureBox1;
        private ProgressBar progressBar1;
    }
}