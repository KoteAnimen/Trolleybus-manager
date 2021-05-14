using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trolleybus_manager
{
    public partial class ChangePath : Form
    {
        public ChangePath()
        {
            InitializeComponent();
        }

        private void маршрутыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void AddPath_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок2". При необходимости она может быть перемещена или удалена.
            this.справочникОстановок2TableAdapter.Fill(this.manageDataSet.СправочникОстановок2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок1". При необходимости она может быть перемещена или удалена.
            this.справочникОстановок1TableAdapter.Fill(this.manageDataSet.СправочникОстановок1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок". При необходимости она может быть перемещена или удалена.
            this.справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.FillByNumberPath(this.manageDataSet.Маршруты, Path.id);
            номерМаршрутаTextBox.Text = manageDataSet.Маршруты.Rows[0][0].ToString();
            протяженностьNumericUpDown.Value = Convert.ToInt32(manageDataSet.Маршруты.Rows[0][1]);
            времяDateTimePicker.Value = (DateTime)manageDataSet.Маршруты.Rows[0][2];
            числоОстановокNumericUpDown.Value = Convert.ToInt32(manageDataSet.Маршруты.Rows[0][3]);
            началоДвиженияComboBox.Text = manageDataSet.Маршруты.Rows[0][4].ToString();
            конецДвиженияComboBox.Text = manageDataSet.Маршруты.Rows[0][5].ToString();
            числоМашинNumericUpDown.Value = Convert.ToInt32(manageDataSet.Маршруты.Rows[0][6]);
            началоДвиженияComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            конецДвиженияComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (протяженностьNumericUpDown.Value == 0)
            {
                MessageBox.Show("Не указана протяженность пути маршрута", "Ошибка");
                return;
            }
            if (времяDateTimePicker.Value == DateTime.Now)
            {
                MessageBox.Show("Не указано время в пути", "Ошибка");
                return;
            }
            if (числоОстановокNumericUpDown.Value == 0)
            {
                MessageBox.Show("Не указано число остановок на пути", "Ошибка");
                return;
            }
            if (числоМашинNumericUpDown.Value == 0)
            {
                MessageBox.Show("Не указано число машин", "Ошибка");
                return;
            }
            else
            {
                маршрутыTableAdapter.UpdatePath((short)протяженностьNumericUpDown.Value, времяDateTimePicker.Value, (short)числоОстановокNumericUpDown.Value, началоДвиженияComboBox.Text, конецДвиженияComboBox.Text, (short)числоМашинNumericUpDown.Value, Path.id);
                Close();
            }
        }
    }
}
