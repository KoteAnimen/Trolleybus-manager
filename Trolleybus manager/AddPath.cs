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
    }
}
