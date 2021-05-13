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
    public partial class ChangeState : Form
    {
        public ChangeState()
        {
            InitializeComponent();
        }

        private void справочникОстановокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочникОстановокBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void AddState_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок". При необходимости она может быть перемещена или удалена.
            this.справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);

        }
    }
}
