using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkWinForms1
{
	public partial class Form1 : Form
	{
		int count = 0; // Объявляем переменную счетчик вакансий, которая будет увеличиваться на 1 при нажатии кнопки "Добавить вакансию".
		public Form1()
		{
			InitializeComponent();
			_txtLvlCompetence.Visible = false;

			_cmbLvlProgrammingCplus.Visible = false;
			_cmbLvlTesting.Visible = false;
			_cmbLvlWebDesign.Visible = false;

			_chkProgrammingCplus.CheckedChanged += _chkProgrammingCplus_CheckedChanged1;
			_chkTesting.CheckedChanged += _chkProgrammingCplus_CheckedChanged1;
			_chkWebDesign.CheckedChanged += _chkProgrammingCplus_CheckedChanged1;

			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col6 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col7 = new DataGridViewTextBoxColumn();

			

			col1.Name = "Фамилия";
			col2.Name = "Имя";
			col3.Name = "Пол";
			col4.Name = "Уровень программирования";
			col5.Name = "Уровень тестирования";
			col6.Name = "Уровень веб-дизайна";
			col7.Name = "Должность";

			SummaryTable.Columns.Add(col1);
			SummaryTable.Columns.Add(col2);
			SummaryTable.Columns.Add(col3);
			SummaryTable.Columns.Add(col4);
			SummaryTable.Columns.Add(col5);
			SummaryTable.Columns.Add(col6);
			SummaryTable.Columns.Add(col7);
		}

		private void _chkProgrammingCplus_CheckedChanged1(object sender, EventArgs e)
		{
			if((_chkProgrammingCplus.Checked == true) && (_chkWebDesign.Checked == true) && (_chkTesting.Checked == true))
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = true;
				_cmbLvlTesting.Visible = true;
				_cmbLvlWebDesign.Visible = true;
			}
			else if((_chkProgrammingCplus.Checked == true) && (_chkWebDesign.Checked == true))
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = true;
				_cmbLvlTesting.Visible = false;
				_cmbLvlWebDesign.Visible = true;
			}
			else if((_chkProgrammingCplus.Checked == true) && (_chkTesting.Checked == true))
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = true;
				_cmbLvlTesting.Visible = true;
				_cmbLvlWebDesign.Visible = false;
			}
			else if((_chkWebDesign.Checked == true) && (_chkTesting.Checked == true))
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = false;
				_cmbLvlTesting.Visible = true;
				_cmbLvlWebDesign.Visible = true;
			}
			else if(_chkProgrammingCplus.Checked == true)
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = true;
				_cmbLvlTesting.Visible = false;
				_cmbLvlWebDesign.Visible = false;
			}
			else if(_chkTesting.Checked == true)
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = false;
				_cmbLvlTesting.Visible = true;
				_cmbLvlWebDesign.Visible = false;
			}
			else if(_chkWebDesign.Checked == true)
			{
				_txtLvlCompetence.Visible = true;

				_cmbLvlProgrammingCplus.Visible = false;
				_cmbLvlTesting.Visible = false;
				_cmbLvlWebDesign.Visible = true;
			}
			else if((_chkProgrammingCplus.Checked == false) && (_chkWebDesign.Checked == false) && (_chkTesting.Checked == false))
			{
				_txtLvlCompetence.Visible = false;

				_cmbLvlProgrammingCplus.Visible = false;
				_cmbLvlTesting.Visible = false;
				_cmbLvlWebDesign.Visible = false;
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void _btnAddJob_Click(object sender, EventArgs e)
		{
			DialogResult AddJob = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(AddJob == DialogResult.Yes)
			{
				if(_txtEnterSurname.Text == "")
				{
					MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if(_txtEnterName.Text == "")
				{
					MessageBox.Show("Введите Имя!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if((_rdiMale.Checked==false)&&(_rdiWoman.Checked == false))
				{
					MessageBox.Show("Выберите пол!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if((_chkProgrammingCplus.Checked == false) && (_chkTesting.Checked == false) && (_chkWebDesign.Checked == false))
				{
					MessageBox.Show("Выберите Компетенции(ю)!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if((_chkProgrammingCplus.Checked == true) && (_cmbLvlProgrammingCplus.Text == ""))
				{
					MessageBox.Show("Выберите уровень программирования!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if((_chkTesting.Checked == true) && (_cmbLvlTesting.Text == ""))
				{
					MessageBox.Show("Выберите уровень тестирования!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if((_chkWebDesign.Checked == true) && (_cmbLvlWebDesign.Text == ""))
				{
					MessageBox.Show("Выберите уровень веб-дизайна!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else if(_cmbChoicePosition.Text == "")
				{
					MessageBox.Show("Выберите должность!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Question);
				}
				else
				{	
					SummaryTable.Rows.Add();
					SummaryTable[0, count].Value = _txtEnterSurname.Text;
					SummaryTable[1, count].Value = _txtEnterName.Text;
					if(_rdiWoman.Checked == true)
					{
						SummaryTable[2, count].Value = _rdiWoman.Text;
					}
					else if(_rdiMale.Checked == true)
					{
						SummaryTable[2, count].Value = _rdiMale.Text;
					}


					if(_chkProgrammingCplus.Checked == true)
					{
						SummaryTable[3, count].Value = _cmbLvlProgrammingCplus.SelectedItem.ToString();
					}
					else if(_chkProgrammingCplus.Checked == false)
					{
						SummaryTable[3, count].Value = "Отсутствует";
					}
					if(_chkTesting.Checked == true)
					{
						SummaryTable[4, count].Value = _cmbLvlTesting.SelectedItem.ToString();
					}
					else if(_chkTesting.Checked == false)
					{
						SummaryTable[4, count].Value = "Отсутствует";
					}
					if(_chkWebDesign.Checked == true)
					{
						SummaryTable[5, count].Value = _cmbLvlWebDesign.SelectedItem.ToString();
					}
					else if(_chkWebDesign.Checked == false)
					{
						SummaryTable[5, count].Value = "Отсутствует";
					}

					SummaryTable[6, count].Value = _cmbChoicePosition.SelectedItem.ToString();
					count++;
				}
				
			}
		}

		private void _txtEnterSurname_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _txtEnterName_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
			{
				e.Handled = true;
			}
		}

		private void _cmbChoicePosition_KeyPress(object sender, KeyPressEventArgs e)
		{
				e.Handled =true;
		}

		private void _cmbLvlProgrammingCplus_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void _cmbLvlTesting_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void _cmbLvlWebDesign_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
		

	}
}
