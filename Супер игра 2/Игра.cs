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
    public partial class Игра : Form
    {
        bool a = true;
        public int HP = 50, HPM = 50, GOLD = 0, i = 18, j = 6, n = 1;
        public int[,] map = { { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,1,1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0  },
                              { 0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0  },
                              { 0,1,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0  },
                              { 0,0,0,0,0,0,1,1,1,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0  },
                              { 0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0  },
                              { 0,0,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0 },
                              { 0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0 },
                              { 0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
                              { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 }};
        public Начало ро = new Начало();
       
        private void button6_Click(object sender, EventArgs e)
        {
            
            ро.button2.Enabled = true;
             
            ро.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
             Битва т = new Битва();
            
            т.Show();
        }

        public Игра()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Колода л = new Колода();
            л.Show();
        }

        private void pictureBox2_Move(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Повышение здоровья!");
            HPM = 60;
            HP = 60;
            button1.Enabled = false;

            button1.Visible = false;
            a = false;
            
           
        }

        private void Игра_Load(object sender, EventArgs e)
        {

            timer1.Start();
 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Обновление характеристик

            
            label3.Text = "Здоровье " + HP.ToString() + "/" + HPM.ToString();
            if (a == true)
            {
                if (i == 10 && j == 2 || i == 10 && j == 3 || i == 10 && j == 4 || i == 10 && j == 5 || i == 9 && j == 2 || i == 9 && j == 3 || i == 9 && j == 4 || i == 9 && j == 5)
                {

                    button1.Enabled = true;

                }
                else
                {
                    button1.Enabled = false;
                }
            }
            
        }

       // Управление
        private void Игра_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && map[i + 1, j] == 1)
            {
                pictureBox2.Top += 50;
                i++;
            }
            else if (e.KeyCode == Keys.W && map[i - 1, j] == 1)
            {
                pictureBox2.Top -= 50;
                i--;
                if (j == 21 && i == 7)
                {
                    MessageBox.Show("Внимание! Вы переходите на другую локацию. Убедитесь в том, что сходили в магазин и собрались с духом для продолжения путешествия.");
                }
                if (j == 21 && i == 6)
                {
                    Игра_2 r = new Игра_2();
                    r.Show();
                    this.Close();


                }
            }
            else if (e.KeyCode == Keys.A && map[i, j - 1] == 1)
            {
                pictureBox2.Left -= 50;
                j--;
            }
            else if (e.KeyCode == Keys.D && map[i, j + 1] == 1)
            {
                pictureBox2.Left += 50;
                j++;
                if (n == 1)
                {
                    if ((i == 14 || i == 15 || i == 16 || i == 17) && j == 15)
                    {
                        MessageBox.Show("Привет?");
                        Битва l = new Битва();
                        l.Show();
                        n = 0;
                        pictureBox4.Enabled = false;
                        pictureBox4.Visible = false;
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
