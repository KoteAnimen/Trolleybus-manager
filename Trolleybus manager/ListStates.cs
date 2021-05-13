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
    public partial class ListStates : Form
    {
        public ListStates()
        {
            InitializeComponent();
        }

        private void справочникОстановокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.справочникОстановокBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.manageDataSet);

        }

        private void ListStates_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.СправочникОстановок". При необходимости она может быть перемещена или удалена.
            this.справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);

        }

        private void AddState_Click(object sender, EventArgs e)
        {
            AddState state = new AddState();
            state.ShowDialog();
            справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);
        }

        private void ChangeState_Click(object sender, EventArgs e)
        {
            State.id = справочникОстановокDataGridView[0, справочникОстановокDataGridView.CurrentRow.Index].Value.ToString();
            ChangeState state = new ChangeState();
            state.ShowDialog();
            справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);
        }

        private void DeleteState_Click(object sender, EventArgs e)
        {
            State.id = справочникОстановокDataGridView[0, справочникОстановокDataGridView.CurrentRow.Index].Value.ToString();
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить остановку?","Удаление остановки", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                try
                {
                    справочникОстановокTableAdapter.DeleteState(State.id);
                }
                catch
                {
                    MessageBox.Show("Не удалось удалить запись, так как она связана с другими таблицами", "Ошибка");
                }
                
            }
            справочникОстановокTableAdapter.Fill(this.manageDataSet.СправочникОстановок);
        }
    }

    public static class State
    {
        public static string id;
    }
}
