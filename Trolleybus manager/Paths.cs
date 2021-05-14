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
    public partial class Paths : Form
    {
        public Paths()
        {
            InitializeComponent();
        }

        private void маршрутыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.маршрутыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void Paths_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Маршруты". При необходимости она может быть перемещена или удалена.
            this.маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);

        }

        private void AddNewPath_Click(object sender, EventArgs e)
        {
            AddPath path = new AddPath();
            path.ShowDialog();
            маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);
        }

        private void ChangePath_Click(object sender, EventArgs e)
        {
            Path.id = маршрутыDataGridView[0, маршрутыDataGridView.CurrentRow.Index].Value.ToString();
            ChangePath path = new ChangePath();
            path.ShowDialog();
            маршрутыTableAdapter.Fill(this.manageDataSet.Маршруты);
        }
    }

    public static class Path
    {
        public static string id;
    }
}
