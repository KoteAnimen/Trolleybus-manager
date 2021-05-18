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
    public partial class ChoiceBus : Form
    {
        public ChoiceBus()
        {
            InitializeComponent();
        }

        private void троллейбусыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.троллейбусыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void ChoiceBus_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Троллейбусы". При необходимости она может быть перемещена или удалена.
            this.троллейбусыTableAdapter.Fill(this.manageDataSet.Троллейбусы);
            номерМаршрутаComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            if(номерМаршрутаComboBox.Text == "")
            {
                MessageBox.Show("Выберите номер маршрута", "Ошибка");
                return;
            }
            else
            {
                Trolleybus.numberPath = номерМаршрутаComboBox.Text;
                Close();
            }
            
        }
    }
}
