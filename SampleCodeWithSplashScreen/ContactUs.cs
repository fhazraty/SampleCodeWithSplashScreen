using System.Diagnostics;

namespace SampleCodeWithSplashScreen
{
	public partial class ContactUs : Form
	{
		private PictureBox logoPictureBox;
		private Label phoneLabel;
		private Label emailLabel;
		private Label addressLabel;
		public ContactUs()
		{
			InitializeComponent();

			// تنظیمات فرم
			this.Text = "تماس با ما";
			this.Size = new Size(400, 400);
			this.StartPosition = FormStartPosition.CenterScreen;
			this.RightToLeft = RightToLeft.Yes;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;

			// ساخت PictureBox برای لوگوی شرکت
			logoPictureBox = new PictureBox();
			logoPictureBox.Size = new Size(150, 150);
			logoPictureBox.Location = new Point((this.ClientSize.Width - logoPictureBox.Width) / 2, 20);
			logoPictureBox.Image = Image.FromFile("../../../logo.png"); // مسیر تصویر لوگوی شرکت
			logoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

			// ساخت Label برای شماره تلفن
			phoneLabel = new Label();

			phoneLabel.Text = "Phone: +123456789";
			phoneLabel.Font = new Font("Arial", 10, FontStyle.Regular);
			phoneLabel.Location = new Point(50, 200);
			phoneLabel.AutoSize = true;

			// ساخت Label برای ایمیل
			emailLabel = new LinkLabel();
			emailLabel.Text = "Email: contact@company.com";
			emailLabel.Font = new Font("Arial", 10, FontStyle.Regular);
			emailLabel.Location = new Point(50, 230);
			emailLabel.AutoSize = true;
			emailLabel.Click += EmailLabel_Click;

			// ساخت Label برای آدرس
			addressLabel = new Label();
			addressLabel.Text = "Address: 1234 Company St, City, Country";
			addressLabel.Font = new Font("Arial", 10, FontStyle.Regular);
			addressLabel.Location = new Point(50, 260);
			addressLabel.AutoSize = true;

			// اضافه کردن کنترل‌ها به فرم
			this.Controls.Add(logoPictureBox);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(emailLabel);
			this.Controls.Add(addressLabel);
		}

		private void EmailLabel_Click(object? sender, EventArgs e)
		{
			// استفاده از mailto: برای باز کردن برنامه ایمیل پیش‌فرض
			try
			{
				Process.Start(new ProcessStartInfo("mailto:contact@company.com")
				{
					UseShellExecute = true // برای باز کردن لینک با برنامه پیش‌فرض سیستم
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}
