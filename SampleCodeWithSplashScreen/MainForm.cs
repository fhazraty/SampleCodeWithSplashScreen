using BusinessLayer;
using Model;

namespace SampleCodeWithSplashScreen
{
	public partial class MainForm : Form
	{
		List<string> majorList = new List<string>();
		List<Student> students = new List<Student>();
		public MainForm()
		{
			InitializeComponent();
			InitializeGenderCmb();
			InitializeMajorCmb();
		}
		private void InitializeGenderCmb()
		{
			cmbGender.DataSource = null;
			cmbGender.DataSource = Enum.GetValues(typeof(Gender));
		}
		private void InitializeMajorCmb()
		{
			cmbMajor.DataSource = null;
			majorList.Add("مهندسی نرم افزار");
			majorList.Add("فناوری اطلاعات");
			majorList.Add("مهندسی سیستم های نرم افزاری");
			cmbMajor.DataSource = majorList;
		}
		private void refereshGrid()
		{
			this.gridViewDisplay.DataSource = null;
			this.gridViewDisplay.DataSource = students;

			if (students.Count != 0)
			{
				this.gridViewDisplay.Columns[0].HeaderCell.Value = "نام";
				this.gridViewDisplay.Columns[1].HeaderCell.Value = "نام خانوادگی";
				this.gridViewDisplay.Columns[2].HeaderCell.Value = "سن";
				this.gridViewDisplay.Columns[3].HeaderCell.Value = "شماره دانشجویی";
				this.gridViewDisplay.Columns[4].HeaderCell.Value = "جنسیت";
				this.gridViewDisplay.Columns[5].HeaderCell.Value = "رشته";
			}
		}
		private void clearInputs()
		{
			this.txtFirstname.Text = "";
			this.txtLastname.Text = "";
			this.txtAge.Text = "";
			this.txtStudentNumber.Text = "";
		}
		private void checkTxtFirstnameValid()
		{
			if (string.IsNullOrWhiteSpace(txtFirstname.Text))
			{
				txtFirstname.BackColor = Color.FromArgb(255, 153, 153);
			}
		}
		private void ClearFirstnameValid()
		{
			if (string.IsNullOrWhiteSpace(txtFirstname.Text))
			{
				txtFirstname.BackColor = Color.White;
			}
		}
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				string path = saveDialog.FileName;

				if (Path.GetExtension(path) == ".csv")
				{
					StudentHelper.SaveAsCsv(path, students);

					MessageBox.Show(
						"ذخیره با موفقیت انجام شد!",
						"موفق",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
				else if (Path.GetExtension(path) == ".json")
				{
					StudentHelper.SaveAsJson(path, students);

					MessageBox.Show(
						"ذخیره با موفقیت انجام شد!",
						"موفق",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(
						"فرمت درخواستی پشتیبانی نمی گردد!",
						"خطا",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}
		private void txt_Leave(object sender, EventArgs e)
		{
			if (!inputStringIsValid(((TextBox)sender).Text))
			{
				((TextBox)sender).BackColor = Color.FromArgb(255, 153, 153);
			}
		}
		private void txt_Enter(object sender, EventArgs e)
		{
			((TextBox)sender).BackColor = Color.White;
		}
		private void تماسباماToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ContactUs contactUsForm = new ContactUs();
			contactUsForm.ShowDialog();
		}
		private bool inputStringIsValid(string inputValue)
		{
			if (string.IsNullOrWhiteSpace(inputValue))
			{
				return false;
			}
			return true;
		}
		private bool inputStringIsNumber(string inputValue)
		{
			if (int.TryParse(inputValue, out int tmp))
			{
				return true;
			}
			return false;
		}
		private bool inputStringIsInRange(string inputValue)
		{
			if (inputStringIsNumber(inputValue))
			{
				if ((int.Parse(inputValue)).ToString().Length == 5)
				{
					return true;
				}
				return false;
			}
			return false;
		}
		private bool checkInputIsValid()
		{
			bool isValid = true;

			if (!inputStringIsValid(txtFirstname.Text))
			{
				txt_Leave(txtFirstname, new EventArgs());
				isValid = false;
			}
			if (!inputStringIsValid(txtLastname.Text))
			{
				txt_Leave(txtLastname, new EventArgs());
				isValid = false;
			}
			if (!inputStringIsValid(txtAge.Text))
			{
				txt_Leave(txtAge, new EventArgs());
				isValid = false;
			}
			if (!inputStringIsNumber(txtAge.Text))
			{
				txt_Leave(txtAge, new EventArgs());
				isValid = false;
			}
			if (!inputStringIsInRange(txtStudentNumber.Text))
			{
				txt_Leave(txtStudentNumber, new EventArgs());
				isValid = false;
			}
			return isValid;
		}
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!checkInputIsValid())
			{

				MessageBox.Show("مقادیر وارد شده صحیح نیست. لطفا مجددا بررسی نمایید!",
					"خطا",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return;
			}

			students.Add(new Student()
			{
				Firstname = txtFirstname.Text,
				Lastname = txtLastname.Text,
				Age = int.Parse(txtAge.Text),
				StudentNo = txtStudentNumber.Text,
				Gender = (Gender)cmbGender.SelectedIndex,
				Major = majorList[cmbMajor.SelectedIndex]
			});

			clearInputs();
			refereshGrid();
		}
		private void gridViewDisplay_DoubleClick(object sender, EventArgs e)
		{
			if (this.gridViewDisplay.SelectedRows.Count == 0) return;

			var selectedStudent = students[this.gridViewDisplay.SelectedRows[0].Index];

			txtFirstname.Text = selectedStudent.Firstname;
			txtLastname.Text = selectedStudent.Lastname;
			txtAge.Text = selectedStudent.Age.ToString();
			txtStudentNumber.Text = selectedStudent.StudentNo;
			cmbGender.SelectedItem = selectedStudent.Gender;
			cmbMajor.SelectedItem = selectedStudent.Major;
		}
		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (!checkInputIsValid())
			{

				MessageBox.Show("مقادیر وارد شده صحیح نیست. لطفا مجددا بررسی نمایید!",
					"خطا",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				return;
			}

			var selectedStudent = students[this.gridViewDisplay.SelectedRows[0].Index];

			selectedStudent.Firstname = txtFirstname.Text;
			selectedStudent.Lastname = txtLastname.Text;
			selectedStudent.Age = int.Parse(txtAge.Text);
			selectedStudent.StudentNo = txtStudentNumber.Text;
			selectedStudent.Gender = (Gender)cmbGender.SelectedItem;
			selectedStudent.Major = cmbMajor.SelectedItem.ToString();

			clearInputs();
			refereshGrid();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (this.gridViewDisplay.SelectedRows.Count == 0) return;

			int index = this.gridViewDisplay.SelectedRows[0].Index;

			students.RemoveAt(index);

			refereshGrid();
		}
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openDialog.ShowDialog() == DialogResult.OK)
			{
				string path = openDialog.FileName;

				if (Path.GetExtension(path) == ".csv")
				{
					students = StudentHelper.LoadFromCsv(path);

					refereshGrid();
				}
				else if (Path.GetExtension(path) == ".json")
				{
					students = StudentHelper.LoadFromJson(path);

					refereshGrid();
				}
				else
				{
					MessageBox.Show(
						"فرمت درخواستی پشتیبانی نمی گردد!",
						"خطا",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}

		private void Number_KeyDown(object sender, KeyEventArgs e)
		{
			// جلوگیری از Ctrl+V برای Paste
			if (e.Control && e.KeyCode == Keys.V)
			{
				e.SuppressKeyPress = true; // جلوگیری از عمل Paste
			}

			// بررسی اعداد (0-9) در ردیف اصلی صفحه‌کلید
			if ((e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9) &&
				(e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) && // بررسی اعداد در صفحه‌کلید عددی (Numeric Keypad)
				e.KeyCode != Keys.Back &&  // اجازه به کلید Backspace
				e.KeyCode != Keys.Tab &&   // اجازه به کلید Tab
				e.KeyCode != Keys.Left &&  // اجازه به کلید Left Arrow
				e.KeyCode != Keys.Right && // اجازه به کلید Right Arrow
				e.KeyCode != Keys.Delete)  // اجازه به کلید Delete
			{
				e.SuppressKeyPress = true; // جلوگیری از ورود کاراکترهای غیر عددی
			}
		}
		private void Number_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				// غیرفعال کردن منوی کلیک راست با اختصاص دادن یک ContextMenuStrip خالی
				((TextBox)sender).ContextMenuStrip = new ContextMenuStrip();
			}
		}
	}
}
