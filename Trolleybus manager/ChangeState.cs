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
            this.справочникОстановокTableAdapter.FillByNumberState(this.manageDataSet.СправочникОстановок, State.id);
            номерОстановкиTextBox.Text = manageDataSet.СправочникОстановок.Rows[0][0].ToString();
            названиеОстановкиTextBox.Text = manageDataSet.СправочникОстановок.Rows[0][1].ToString();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (номерОстановкиTextBox.Text == "")
            {
                MessageBox.Show("Не указан номер остановки", "Ошибка");
                return;
            }
            if (названиеОстановкиTextBox.Text == "")
            {
                MessageBox.Show("Не указано название остановки", "Ошибка");
                return;
            }
            else
            {
                справочникОстановокTableAdapter.UpdateState(номерОстановкиTextBox.Text, названиеОстановкиTextBox.Text, State.id);
                Close();
            }
        }
    }
}
