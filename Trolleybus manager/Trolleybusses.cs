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
    public partial class Trolleybusses : Form
    {
        public Trolleybusses()
        {
            InitializeComponent();
        }

        private void троллейбусыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.троллейбусыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void Trolleybusses_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Busses". При необходимости она может быть перемещена или удалена.
            this.bussesTableAdapter.Fill(manageDataSet.Busses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Троллейбусы". При необходимости она может быть перемещена или удалена.
            this.троллейбусыTableAdapter.Fill(this.manageDataSet.Троллейбусы);

        }

        private void AddTrolleybus_Click(object sender, EventArgs e)
        {
            AddNewTrolleybus bus = new AddNewTrolleybus();
            bus.ShowDialog();
            this.bussesTableAdapter.Fill(manageDataSet.Busses);
        }

        private void ChangeTrolleybus_Click(object sender, EventArgs e)
        {
            Trolleybus.id = bussesDataGridView[0, bussesDataGridView.CurrentRow.Index].Value.ToString();
            ChangeTrolleybus bus = new ChangeTrolleybus();
            bus.ShowDialog();
            this.bussesTableAdapter.Fill(manageDataSet.Busses);
        }

        private void DeteleTrolleybus_Click(object sender, EventArgs e)
        {
            Trolleybus.id = bussesDataGridView[0, bussesDataGridView.CurrentRow.Index].Value.ToString();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить остановку?", "Удаление остановки", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {                    
                    троллейбусыTableAdapter.DeleteBus(Trolleybus.id);
                    bussesDataGridView.Rows.RemoveAt(0);
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить запись, так как она связана с другими таблицами", "Ошибка");
                }

            }
            this.bussesTableAdapter.Fill(manageDataSet.Busses);
        }
    }

    public static class Trolleybus
    {
        public static string id;
    }
}
