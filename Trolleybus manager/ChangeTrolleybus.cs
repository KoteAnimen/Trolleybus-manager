﻿using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manageDataSet.Троллейбусы". При необходимости она может быть перемещена или удалена.
            this.троллейбусыTableAdapter.Fill(this.manageDataSet.Троллейбусы);

        }
    }
}