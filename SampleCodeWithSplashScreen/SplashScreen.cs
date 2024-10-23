using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCodeWithSplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

			SetRoundedCorners(30);
		}
		private void SetRoundedCorners(int radius)
		{
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
			path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
			path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
			path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
			path.CloseFigure();

			this.Region = new Region(path);
		}
		private void SplashScreen_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(displayNewForm));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            Thread thread2 = new Thread(new ThreadStart(moveProgressBar));
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
        }

        bool programStarted = false;

        private void moveProgressBar()
        {
            while (!programStarted)
            {
                Thread.Sleep(100);

                if (this.InvokeRequired)
                {
                    this.Invoke(delegate
                    {
                        progressBar1.Value += 2;
                        if (progressBar1.Value == 100)
                        {
                            progressBar1.Value = 0;
                        }
                    });
                }
                else
                {
                    progressBar1.Value += 1;
                    if (progressBar1.Value == 100)
                    {
                        progressBar1.Value = 0;
                    }
                }
            }
        }

        private void displayNewForm()
        {
            Thread.Sleep(5000);
            if (this.InvokeRequired)
            {
                this.Invoke(delegate
                {
                    programStarted = true;
                    this.Close();
                });
            }
            else
            {
                this.Close();
            }
            
            MainForm form = new MainForm();
            form.ShowDialog();
        }
    }
}
