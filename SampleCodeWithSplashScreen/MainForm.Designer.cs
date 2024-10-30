namespace SampleCodeWithSplashScreen
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			پایگاهدادهToolStripMenuItem = new ToolStripMenuItem();
			ذخیرهToolStripMenuItem = new ToolStripMenuItem();
			بازیابیToolStripMenuItem = new ToolStripMenuItem();
			fileToolStripMenuItem = new ToolStripMenuItem();
			openToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripSeparator();
			exitToolStripMenuItem = new ToolStripMenuItem();
			دربارهماToolStripMenuItem = new ToolStripMenuItem();
			تماسباماToolStripMenuItem = new ToolStripMenuItem();
			openDialog = new OpenFileDialog();
			saveDialog = new SaveFileDialog();
			groupBox1 = new GroupBox();
			groupBox3 = new GroupBox();
			btnDelete = new Button();
			btnSave = new Button();
			btnEdit = new Button();
			label6 = new Label();
			cmbGender = new ComboBox();
			label5 = new Label();
			cmbMajor = new ComboBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			txtAge = new TextBox();
			txtStudentNumber = new TextBox();
			txtLastname = new TextBox();
			txtFirstname = new TextBox();
			groupBox2 = new GroupBox();
			gridViewDisplay = new DataGridView();
			menuStrip1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridViewDisplay).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, پایگاهدادهToolStripMenuItem, دربارهماToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1022, 24);
			menuStrip1.TabIndex = 6;
			menuStrip1.Text = "menuStrip1";
			// 
			// پایگاهدادهToolStripMenuItem
			// 
			پایگاهدادهToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ذخیرهToolStripMenuItem, بازیابیToolStripMenuItem });
			پایگاهدادهToolStripMenuItem.Name = "پایگاهدادهToolStripMenuItem";
			پایگاهدادهToolStripMenuItem.Size = new Size(69, 20);
			پایگاهدادهToolStripMenuItem.Text = "پایگاه داده";
			// 
			// ذخیرهToolStripMenuItem
			// 
			ذخیرهToolStripMenuItem.Name = "ذخیرهToolStripMenuItem";
			ذخیرهToolStripMenuItem.Size = new Size(180, 22);
			ذخیرهToolStripMenuItem.Text = "ذخیره";
			ذخیرهToolStripMenuItem.Click += ذخیرهToolStripMenuItem_Click;
			// 
			// بازیابیToolStripMenuItem
			// 
			بازیابیToolStripMenuItem.Name = "بازیابیToolStripMenuItem";
			بازیابیToolStripMenuItem.Size = new Size(180, 22);
			بازیابیToolStripMenuItem.Text = "بازیابی";
			بازیابیToolStripMenuItem.Click += بازیابیToolStripMenuItem_Click;
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(40, 20);
			fileToolStripMenuItem.Text = "فایل";
			// 
			// openToolStripMenuItem
			// 
			openToolStripMenuItem.Name = "openToolStripMenuItem";
			openToolStripMenuItem.Size = new Size(180, 22);
			openToolStripMenuItem.Text = "بازکردن";
			openToolStripMenuItem.Click += openToolStripMenuItem_Click;
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(180, 22);
			saveToolStripMenuItem.Text = "ذخیره";
			saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(180, 22);
			exitToolStripMenuItem.Text = "خروج";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// دربارهماToolStripMenuItem
			// 
			دربارهماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { تماسباماToolStripMenuItem });
			دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
			دربارهماToolStripMenuItem.Size = new Size(60, 20);
			دربارهماToolStripMenuItem.Text = "درباره ما";
			// 
			// تماسباماToolStripMenuItem
			// 
			تماسباماToolStripMenuItem.Name = "تماسباماToolStripMenuItem";
			تماسباماToolStripMenuItem.Size = new Size(125, 22);
			تماسباماToolStripMenuItem.Text = "تماس با ما";
			تماسباماToolStripMenuItem.Click += تماسباماToolStripMenuItem_Click;
			// 
			// openDialog
			// 
			openDialog.FileName = "openFileDialog1";
			openDialog.Filter = "JSON files (*.json)|*.json|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			// 
			// saveDialog
			// 
			saveDialog.Filter = "JSON files (*.json)|*.json|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(groupBox3);
			groupBox1.Controls.Add(groupBox2);
			groupBox1.Location = new Point(12, 32);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(998, 266);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "ثبت دانشجو";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btnDelete);
			groupBox3.Controls.Add(btnSave);
			groupBox3.Controls.Add(btnEdit);
			groupBox3.Controls.Add(label6);
			groupBox3.Controls.Add(cmbGender);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(cmbMajor);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(label1);
			groupBox3.Controls.Add(txtAge);
			groupBox3.Controls.Add(txtStudentNumber);
			groupBox3.Controls.Add(txtLastname);
			groupBox3.Controls.Add(txtFirstname);
			groupBox3.Location = new Point(705, 20);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(287, 238);
			groupBox3.TabIndex = 3;
			groupBox3.TabStop = false;
			groupBox3.Text = "اطلاعات ورودی";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(6, 205);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(75, 23);
			btnDelete.TabIndex = 15;
			btnDelete.Tag = "";
			btnDelete.Text = "حذف";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(168, 205);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 13;
			btnSave.Text = "ثبت";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnEdit
			// 
			btnEdit.Location = new Point(87, 205);
			btnEdit.Name = "btnEdit";
			btnEdit.Size = new Size(75, 23);
			btnEdit.TabIndex = 14;
			btnEdit.Text = "ویرایش";
			btnEdit.UseVisualStyleBackColor = true;
			btnEdit.Click += btnEdit_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(181, 167);
			label6.Name = "label6";
			label6.Size = new Size(46, 15);
			label6.TabIndex = 11;
			label6.Text = "جنسیت:";
			// 
			// cmbGender
			// 
			cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbGender.FormattingEnabled = true;
			cmbGender.Location = new Point(6, 164);
			cmbGender.Name = "cmbGender";
			cmbGender.Size = new Size(169, 23);
			cmbGender.TabIndex = 12;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(181, 138);
			label5.Name = "label5";
			label5.Size = new Size(34, 15);
			label5.TabIndex = 9;
			label5.Text = "رشته:";
			// 
			// cmbMajor
			// 
			cmbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMajor.FormattingEnabled = true;
			cmbMajor.Location = new Point(6, 135);
			cmbMajor.Name = "cmbMajor";
			cmbMajor.Size = new Size(169, 23);
			cmbMajor.TabIndex = 11;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(181, 109);
			label4.Name = "label4";
			label4.Size = new Size(28, 15);
			label4.TabIndex = 7;
			label4.Text = "سن:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(181, 80);
			label3.Name = "label3";
			label3.Size = new Size(94, 15);
			label3.TabIndex = 6;
			label3.Text = "شماره دانشجویی:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(181, 51);
			label2.Name = "label2";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 5;
			label2.Text = "نام خانوادگی:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(181, 22);
			label1.Name = "label1";
			label1.Size = new Size(24, 15);
			label1.TabIndex = 4;
			label1.Text = "نام:";
			// 
			// txtAge
			// 
			txtAge.Location = new Point(6, 106);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(169, 23);
			txtAge.TabIndex = 10;
			txtAge.Enter += txt_Enter;
			txtAge.KeyDown += Number_KeyDown;
			txtAge.Leave += txt_Leave;
			txtAge.MouseDown += Number_MouseDown;
			// 
			// txtStudentNumber
			// 
			txtStudentNumber.Location = new Point(6, 77);
			txtStudentNumber.Name = "txtStudentNumber";
			txtStudentNumber.Size = new Size(169, 23);
			txtStudentNumber.TabIndex = 9;
			txtStudentNumber.Enter += txt_Enter;
			txtStudentNumber.KeyDown += Number_KeyDown;
			txtStudentNumber.Leave += txt_Leave;
			txtStudentNumber.MouseDown += Number_MouseDown;
			// 
			// txtLastname
			// 
			txtLastname.Location = new Point(6, 48);
			txtLastname.Name = "txtLastname";
			txtLastname.Size = new Size(169, 23);
			txtLastname.TabIndex = 8;
			txtLastname.Enter += txt_Enter;
			txtLastname.Leave += txt_Leave;
			// 
			// txtFirstname
			// 
			txtFirstname.Location = new Point(6, 19);
			txtFirstname.Name = "txtFirstname";
			txtFirstname.Size = new Size(169, 23);
			txtFirstname.TabIndex = 7;
			txtFirstname.Enter += txt_Enter;
			txtFirstname.Leave += txt_Leave;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(gridViewDisplay);
			groupBox2.Location = new Point(6, 20);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(693, 239);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "داده";
			// 
			// gridViewDisplay
			// 
			gridViewDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridViewDisplay.Dock = DockStyle.Fill;
			gridViewDisplay.EditMode = DataGridViewEditMode.EditProgrammatically;
			gridViewDisplay.Location = new Point(3, 19);
			gridViewDisplay.Name = "gridViewDisplay";
			gridViewDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridViewDisplay.Size = new Size(687, 217);
			gridViewDisplay.TabIndex = 0;
			gridViewDisplay.DoubleClick += gridViewDisplay_DoubleClick;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1022, 302);
			ControlBox = false;
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			RightToLeft = RightToLeft.Yes;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "سامانه آموزشیار";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)gridViewDisplay).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}



		#endregion

		private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openDialog;
        private SaveFileDialog saveDialog;
		private GroupBox groupBox1;
		private GroupBox groupBox3;
		private GroupBox groupBox2;
		private ToolStripMenuItem دربارهماToolStripMenuItem;
		private ToolStripMenuItem تماسباماToolStripMenuItem;
		private TextBox txtFirstname;
		private TextBox txtAge;
		private TextBox txtStudentNumber;
		private TextBox txtLastname;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private DataGridView gridViewDisplay;
		private Label label6;
		private ComboBox cmbGender;
		private Label label5;
		private ComboBox cmbMajor;
		private Button btnSave;
		private Button btnEdit;
		private Button btnDelete;
		private ToolStripMenuItem پایگاهدادهToolStripMenuItem;
		private ToolStripMenuItem ذخیرهToolStripMenuItem;
		private ToolStripMenuItem بازیابیToolStripMenuItem;
	}
}
