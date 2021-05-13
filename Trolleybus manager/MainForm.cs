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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListStations_Click(object sender, EventArgs e)
        {
            ListStates list = new ListStates();
            list.ShowDialog();
        }

        private void Paths_Click(object sender, EventArgs e)
        {
            Paths path = new Paths();
            path.ShowDialog();
        }

        private void Trolleybusses_Click(object sender, EventArgs e)
        {
            Trolleybusses bus = new Trolleybusses();
            bus.ShowDialog();
        }
    }
}
