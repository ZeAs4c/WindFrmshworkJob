namespace HomeworkWinForms1
{
	partial class Form1
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
			if(disposing && (components != null))
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
			this.SummaryTable = new System.Windows.Forms.DataGridView();
			this._txtEnterName = new System.Windows.Forms.TextBox();
			this._rdiMale = new System.Windows.Forms.RadioButton();
			this._rdiWoman = new System.Windows.Forms.RadioButton();
			this._txtGender = new System.Windows.Forms.Label();
			this._txtCompetences = new System.Windows.Forms.Label();
			this._chkProgrammingCplus = new System.Windows.Forms.CheckBox();
			this._chkTesting = new System.Windows.Forms.CheckBox();
			this._chkWebDesign = new System.Windows.Forms.CheckBox();
			this._txtLvlCompetence = new System.Windows.Forms.Label();
			this._cmbLvlProgrammingCplus = new System.Windows.Forms.ComboBox();
			this._cmbLvlTesting = new System.Windows.Forms.ComboBox();
			this._cmbLvlWebDesign = new System.Windows.Forms.ComboBox();
			this._txtPosition = new System.Windows.Forms.Label();
			this._cmbChoicePosition = new System.Windows.Forms.ComboBox();
			this._btnAddJob = new System.Windows.Forms.Button();
			this._grpUnification = new System.Windows.Forms.GroupBox();
			this._txtName = new System.Windows.Forms.Label();
			this._txtSurname = new System.Windows.Forms.Label();
			this._txtEnterSurname = new System.Windows.Forms.TextBox();
			this._pnlLaborPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.SummaryTable)).BeginInit();
			this._grpUnification.SuspendLayout();
			this._pnlLaborPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// SummaryTable
			// 
			this.SummaryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.SummaryTable.Location = new System.Drawing.Point(1, 425);
			this.SummaryTable.Name = "SummaryTable";
			this.SummaryTable.Size = new System.Drawing.Size(749, 182);
			this.SummaryTable.TabIndex = 2;
			// 
			// _txtEnterName
			// 
			this._txtEnterName.Location = new System.Drawing.Point(145, 55);
			this._txtEnterName.Name = "_txtEnterName";
			this._txtEnterName.Size = new System.Drawing.Size(108, 27);
			this._txtEnterName.TabIndex = 2;
			this._txtEnterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterName_KeyPress);
			// 
			// _rdiMale
			// 
			this._rdiMale.AutoSize = true;
			this._rdiMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._rdiMale.Location = new System.Drawing.Point(145, 96);
			this._rdiMale.Name = "_rdiMale";
			this._rdiMale.Size = new System.Drawing.Size(57, 20);
			this._rdiMale.TabIndex = 4;
			this._rdiMale.TabStop = true;
			this._rdiMale.Text = "Муж.";
			this._rdiMale.UseVisualStyleBackColor = true;
			// 
			// _rdiWoman
			// 
			this._rdiWoman.AutoSize = true;
			this._rdiWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._rdiWoman.Location = new System.Drawing.Point(70, 96);
			this._rdiWoman.Name = "_rdiWoman";
			this._rdiWoman.Size = new System.Drawing.Size(58, 20);
			this._rdiWoman.TabIndex = 5;
			this._rdiWoman.TabStop = true;
			this._rdiWoman.Text = "Жен.";
			this._rdiWoman.UseVisualStyleBackColor = true;
			// 
			// _txtGender
			// 
			this._txtGender.AutoSize = true;
			this._txtGender.BackColor = System.Drawing.Color.Moccasin;
			this._txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtGender.ForeColor = System.Drawing.SystemColors.ControlText;
			this._txtGender.Location = new System.Drawing.Point(6, 95);
			this._txtGender.Name = "_txtGender";
			this._txtGender.Size = new System.Drawing.Size(43, 20);
			this._txtGender.TabIndex = 6;
			this._txtGender.Text = "Пол";
			// 
			// _txtCompetences
			// 
			this._txtCompetences.AutoSize = true;
			this._txtCompetences.BackColor = System.Drawing.Color.Moccasin;
			this._txtCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtCompetences.ForeColor = System.Drawing.SystemColors.ControlText;
			this._txtCompetences.Location = new System.Drawing.Point(6, 141);
			this._txtCompetences.Name = "_txtCompetences";
			this._txtCompetences.Size = new System.Drawing.Size(122, 20);
			this._txtCompetences.TabIndex = 7;
			this._txtCompetences.Text = "Компетенции";
			// 
			// _chkProgrammingCplus
			// 
			this._chkProgrammingCplus.AutoSize = true;
			this._chkProgrammingCplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkProgrammingCplus.Location = new System.Drawing.Point(11, 175);
			this._chkProgrammingCplus.Name = "_chkProgrammingCplus";
			this._chkProgrammingCplus.Size = new System.Drawing.Size(294, 20);
			this._chkProgrammingCplus.TabIndex = 8;
			this._chkProgrammingCplus.Text = "Навыки программирования на языке С++";
			this._chkProgrammingCplus.UseVisualStyleBackColor = true;
			// 
			// _chkTesting
			// 
			this._chkTesting.AutoSize = true;
			this._chkTesting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkTesting.Location = new System.Drawing.Point(11, 209);
			this._chkTesting.Name = "_chkTesting";
			this._chkTesting.Size = new System.Drawing.Size(172, 20);
			this._chkTesting.TabIndex = 9;
			this._chkTesting.Text = "Навыки тестирования";
			this._chkTesting.UseVisualStyleBackColor = true;
			// 
			// _chkWebDesign
			// 
			this._chkWebDesign.AutoSize = true;
			this._chkWebDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._chkWebDesign.Location = new System.Drawing.Point(11, 243);
			this._chkWebDesign.Name = "_chkWebDesign";
			this._chkWebDesign.Size = new System.Drawing.Size(165, 20);
			this._chkWebDesign.TabIndex = 10;
			this._chkWebDesign.Text = "Навыки Веб-дизайна";
			this._chkWebDesign.UseVisualStyleBackColor = true;
			// 
			// _txtLvlCompetence
			// 
			this._txtLvlCompetence.AutoSize = true;
			this._txtLvlCompetence.BackColor = System.Drawing.Color.Moccasin;
			this._txtLvlCompetence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtLvlCompetence.ForeColor = System.Drawing.SystemColors.ControlText;
			this._txtLvlCompetence.Location = new System.Drawing.Point(350, 141);
			this._txtLvlCompetence.Name = "_txtLvlCompetence";
			this._txtLvlCompetence.Size = new System.Drawing.Size(294, 20);
			this._txtLvlCompetence.TabIndex = 11;
			this._txtLvlCompetence.Text = "Уровень владения компетенцией";
			// 
			// _cmbLvlProgrammingCplus
			// 
			this._cmbLvlProgrammingCplus.FormattingEnabled = true;
			this._cmbLvlProgrammingCplus.Items.AddRange(new object[] {
            "Junior",
            "Middle",
            "Senior"});
			this._cmbLvlProgrammingCplus.Location = new System.Drawing.Point(354, 175);
			this._cmbLvlProgrammingCplus.Name = "_cmbLvlProgrammingCplus";
			this._cmbLvlProgrammingCplus.Size = new System.Drawing.Size(214, 28);
			this._cmbLvlProgrammingCplus.TabIndex = 12;
			this._cmbLvlProgrammingCplus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cmbLvlProgrammingCplus_KeyPress);
			// 
			// _cmbLvlTesting
			// 
			this._cmbLvlTesting.FormattingEnabled = true;
			this._cmbLvlTesting.Items.AddRange(new object[] {
            "Junior",
            "Middle",
            "Senior",
            "Lead "});
			this._cmbLvlTesting.Location = new System.Drawing.Point(354, 209);
			this._cmbLvlTesting.Name = "_cmbLvlTesting";
			this._cmbLvlTesting.Size = new System.Drawing.Size(214, 28);
			this._cmbLvlTesting.TabIndex = 13;
			this._cmbLvlTesting.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cmbLvlTesting_KeyPress);
			// 
			// _cmbLvlWebDesign
			// 
			this._cmbLvlWebDesign.FormattingEnabled = true;
			this._cmbLvlWebDesign.Items.AddRange(new object[] {
            "Junior",
            "Web-Designer",
            "Head of Web-Design"});
			this._cmbLvlWebDesign.Location = new System.Drawing.Point(354, 243);
			this._cmbLvlWebDesign.Name = "_cmbLvlWebDesign";
			this._cmbLvlWebDesign.Size = new System.Drawing.Size(214, 28);
			this._cmbLvlWebDesign.TabIndex = 14;
			this._cmbLvlWebDesign.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cmbLvlWebDesign_KeyPress);
			// 
			// _txtPosition
			// 
			this._txtPosition.AutoSize = true;
			this._txtPosition.BackColor = System.Drawing.Color.Moccasin;
			this._txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtPosition.ForeColor = System.Drawing.SystemColors.ControlText;
			this._txtPosition.Location = new System.Drawing.Point(11, 289);
			this._txtPosition.Name = "_txtPosition";
			this._txtPosition.Size = new System.Drawing.Size(104, 20);
			this._txtPosition.TabIndex = 15;
			this._txtPosition.Text = "Должность";
			// 
			// _cmbChoicePosition
			// 
			this._cmbChoicePosition.FormattingEnabled = true;
			this._cmbChoicePosition.Items.AddRange(new object[] {
            "C++ Разработчик",
            "Тестиривщик ПО",
            "Веб-дизайнер",
            "Руководитель отдела веб-дизайнеров",
            "Руководитель отдела тестирования ПО(lead)",
            "Руководитель отдела разработки ПО(senior)"});
			this._cmbChoicePosition.Location = new System.Drawing.Point(11, 331);
			this._cmbChoicePosition.Name = "_cmbChoicePosition";
			this._cmbChoicePosition.Size = new System.Drawing.Size(493, 28);
			this._cmbChoicePosition.TabIndex = 16;
			this._cmbChoicePosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._cmbChoicePosition_KeyPress);
			// 
			// _btnAddJob
			// 
			this._btnAddJob.BackColor = System.Drawing.Color.Khaki;
			this._btnAddJob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this._btnAddJob.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this._btnAddJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
			this._btnAddJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._btnAddJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._btnAddJob.Location = new System.Drawing.Point(564, 346);
			this._btnAddJob.Name = "_btnAddJob";
			this._btnAddJob.Size = new System.Drawing.Size(151, 40);
			this._btnAddJob.TabIndex = 17;
			this._btnAddJob.Text = "Добавить вакансию";
			this._btnAddJob.UseVisualStyleBackColor = false;
			this._btnAddJob.Click += new System.EventHandler(this._btnAddJob_Click);
			// 
			// _grpUnification
			// 
			this._grpUnification.Controls.Add(this._btnAddJob);
			this._grpUnification.Controls.Add(this._txtName);
			this._grpUnification.Controls.Add(this._cmbLvlWebDesign);
			this._grpUnification.Controls.Add(this._cmbChoicePosition);
			this._grpUnification.Controls.Add(this._cmbLvlTesting);
			this._grpUnification.Controls.Add(this._txtSurname);
			this._grpUnification.Controls.Add(this._cmbLvlProgrammingCplus);
			this._grpUnification.Controls.Add(this._txtPosition);
			this._grpUnification.Controls.Add(this._txtLvlCompetence);
			this._grpUnification.Controls.Add(this._txtEnterSurname);
			this._grpUnification.Controls.Add(this._txtEnterName);
			this._grpUnification.Controls.Add(this._txtGender);
			this._grpUnification.Controls.Add(this._rdiWoman);
			this._grpUnification.Controls.Add(this._rdiMale);
			this._grpUnification.Controls.Add(this._chkWebDesign);
			this._grpUnification.Controls.Add(this._txtCompetences);
			this._grpUnification.Controls.Add(this._chkTesting);
			this._grpUnification.Controls.Add(this._chkProgrammingCplus);
			this._grpUnification.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._grpUnification.Location = new System.Drawing.Point(3, 0);
			this._grpUnification.Name = "_grpUnification";
			this._grpUnification.Size = new System.Drawing.Size(749, 419);
			this._grpUnification.TabIndex = 18;
			this._grpUnification.TabStop = false;
			this._grpUnification.Text = "Вакансия на работу";
			// 
			// _txtName
			// 
			this._txtName.AutoSize = true;
			this._txtName.BackColor = System.Drawing.Color.Moccasin;
			this._txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtName.Location = new System.Drawing.Point(141, 32);
			this._txtName.Name = "_txtName";
			this._txtName.Size = new System.Drawing.Size(43, 20);
			this._txtName.TabIndex = 3;
			this._txtName.Text = "Имя";
			// 
			// _txtSurname
			// 
			this._txtSurname.AutoSize = true;
			this._txtSurname.BackColor = System.Drawing.Color.Moccasin;
			this._txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._txtSurname.ForeColor = System.Drawing.SystemColors.ControlText;
			this._txtSurname.Location = new System.Drawing.Point(6, 32);
			this._txtSurname.Name = "_txtSurname";
			this._txtSurname.Size = new System.Drawing.Size(88, 20);
			this._txtSurname.TabIndex = 0;
			this._txtSurname.Text = "Фамилия";
			// 
			// _txtEnterSurname
			// 
			this._txtEnterSurname.Location = new System.Drawing.Point(10, 55);
			this._txtEnterSurname.Name = "_txtEnterSurname";
			this._txtEnterSurname.Size = new System.Drawing.Size(118, 27);
			this._txtEnterSurname.TabIndex = 1;
			this._txtEnterSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtEnterSurname_KeyPress);
			// 
			// _pnlLaborPanel
			// 
			this._pnlLaborPanel.BackColor = System.Drawing.Color.Moccasin;
			this._pnlLaborPanel.Controls.Add(this._grpUnification);
			this._pnlLaborPanel.Location = new System.Drawing.Point(-2, 0);
			this._pnlLaborPanel.Name = "_pnlLaborPanel";
			this._pnlLaborPanel.Size = new System.Drawing.Size(752, 419);
			this._pnlLaborPanel.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 619);
			this.Controls.Add(this.SummaryTable);
			this.Controls.Add(this._pnlLaborPanel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.SummaryTable)).EndInit();
			this._grpUnification.ResumeLayout(false);
			this._grpUnification.PerformLayout();
			this._pnlLaborPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridView SummaryTable;
		private System.Windows.Forms.TextBox _txtEnterName;
		private System.Windows.Forms.RadioButton _rdiMale;
		private System.Windows.Forms.RadioButton _rdiWoman;
		private System.Windows.Forms.Label _txtGender;
		private System.Windows.Forms.Label _txtCompetences;
		private System.Windows.Forms.CheckBox _chkProgrammingCplus;
		private System.Windows.Forms.CheckBox _chkTesting;
		private System.Windows.Forms.CheckBox _chkWebDesign;
		private System.Windows.Forms.Label _txtLvlCompetence;
		private System.Windows.Forms.ComboBox _cmbLvlProgrammingCplus;
		private System.Windows.Forms.ComboBox _cmbLvlTesting;
		private System.Windows.Forms.ComboBox _cmbLvlWebDesign;
		private System.Windows.Forms.Label _txtPosition;
		private System.Windows.Forms.ComboBox _cmbChoicePosition;
		private System.Windows.Forms.Button _btnAddJob;
		private System.Windows.Forms.GroupBox _grpUnification;
		private System.Windows.Forms.Label _txtName;
		private System.Windows.Forms.Label _txtSurname;
		private System.Windows.Forms.TextBox _txtEnterSurname;
		private System.Windows.Forms.Panel _pnlLaborPanel;
	}
}

