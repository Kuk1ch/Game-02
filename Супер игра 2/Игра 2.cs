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
    public partial class Игра_2 : Form
    {
        public Игра_2()
        {
            InitializeComponent();
            timer1.Start();
        }

        public int HP = 60, HPM = 60,  j = 4, i = 7, n = 1;
        bool a = true;
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;
            MessageBox.Show("Повышение здоровья!");
            HP = 70;
            HPM = 70;
            a = false;

        }

        public Начало ро = new Начало();
        public int[,] map = {{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0},
                             {0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0},
                             {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0 },
                             {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
                             {0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0 },
                             {0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,1,1,1,0 },
                             {0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,0},
                             {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};
        private void button1_Click(object sender, EventArgs e)
        {
            ро.button2.Enabled = true;

            ро.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Здоровье " + HP.ToString() + "/" + HPM.ToString();
            
            if (a == true)
            {
                if (i == 2 && j == 1)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }
            }
        }

        private void Игра_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && map[i + 1, j] == 1)
            {
                pictureBox3.Top += 45;
                i++;
            }
            else if (e.KeyCode == Keys.W && map[i - 1, j] == 1)
            {
                pictureBox3.Top -= 45;
                i--;
                if (i == 0 && j == 21)
                {
                    Конец o = new Конец();
                    o.Show();
                    
                }
                
               
            }
            else if (e.KeyCode == Keys.A && map[i, j - 1] == 1)
            {
                pictureBox3.Left -= 45;
                j--;
            }
            else if (e.KeyCode == Keys.D && map[i, j + 1] == 1)
            {
                pictureBox3.Left += 45;
                j++;
                if (n == 1)
                {
                    if (j == 15 && i == 2 || j == 15 && i == 3 || j == 15 && i == 4 || j == 15 && i == 5)
                    {
                        MessageBox.Show("Готовься к смерти!");
                        Битва_2 p = new Битва_2();
                        p.Show();
                        pictureBox2.Visible = false;
                        pictureBox2.Enabled = false;
                        n = 0;
                    }
                }
                else
                {

                }
            }
            else
            {
            }


        }
    }
}
