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
    public partial class AddNewTrolleybus : Form
    {
        public AddNewTrolleybus()
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
            this.троллейбусыTableAdapter.Fill(this.manageDataSet.Троллейбусы);

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(номерТроллейбусаTextBox.Text == "")
            {
                MessageBox.Show("Не введен номер троллейбуса", "Ошибка");
                return;
            }
            if(номерМаршрутаComboBox.Text == ""){
                MessageBox.Show("Не введен номер маршрута", "Ошибка");
                return;
            }
            if(состояниеComboBox.Text == "")
            {
                MessageBox.Show("Не введено состояние", "Ошибка");
                return;
            }
            троллейбусыTableAdapter.Insert(номерТроллейбусаTextBox.Text, состояниеComboBox.Text, номерМаршрутаComboBox.Text, времяОтправленияDateTimePicker.Value);
            Close();
        }
    }
}
