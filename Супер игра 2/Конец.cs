using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Супер_игра_2
{
    public partial class Конец : Form
    {
        public Конец()
        {
            InitializeComponent();
        }

        private void Конец_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Спасибо за игру!");
                Application.Exit();
            }
        }
    }
}
