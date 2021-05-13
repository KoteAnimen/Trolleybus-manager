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
    public partial class AddPath : Form
    {
        public AddPath()
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок". При необходимости она может быть перемещена или удалена.
            this.справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(номерМаршрутаTextBox.Text == "")
            {
                MessageBox.Show("Не указан номер маршрута", "Ошибка");
                return;
            }
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
                маршрутыTableAdapter.Insert(номерМаршрутаTextBox.Text, (short)протяженностьNumericUpDown.Value, времяDateTimePicker.Value, (short)числоОстановокNumericUpDown.Value, началоДвиженияComboBox.Text, конецДвиженияComboBox.Text, (short)числоМашинNumericUpDown.Value);
                Close();
            }

        }
    }
}
