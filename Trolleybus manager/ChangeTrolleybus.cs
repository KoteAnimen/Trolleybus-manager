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
    public partial class ChangeTrolleybus : Form
    {
        public ChangeTrolleybus()
        {
            InitializeComponent();
        }

        private void троллейбусыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.троллейбусыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void AddNewTrolleybus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Троллейбусы". При необходимости она может быть перемещена или удалена.
            this.троллейбусыTableAdapter.FillByNumberBus(this.manageDataSet.Троллейбусы, Trolleybus.id);
            номерТроллейбусаTextBox.Text = manageDataSet.Троллейбусы.Rows[0][0].ToString();
            номерМаршрутаComboBox.Text = manageDataSet.Троллейбусы.Rows[0][2].ToString();
            состояниеComboBox.Text = manageDataSet.Троллейбусы.Rows[0][1].ToString();
            времяОтправленияDateTimePicker.Value = (DateTime)manageDataSet.Троллейбусы.Rows[0][3];
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (номерТроллейбусаTextBox.Text == "")
            {
                MessageBox.Show("Не введен номер троллейбуса", "Ошибка");
                return;
            }
            if (номерМаршрутаComboBox.Text == "")
            {
                MessageBox.Show("Не введен номер маршрута", "Ошибка");
                return;
            }
            if (состояниеComboBox.Text == "")
            {
                MessageBox.Show("Не введено состояние", "Ошибка");
                return;
            }
            троллейбусыTableAdapter.UpdateBus(номерТроллейбусаTextBox.Text, состояниеComboBox.Text, номерМаршрутаComboBox.Text, времяОтправленияDateTimePicker.Value, Trolleybus.id);
            Close();
        }
    }
}
