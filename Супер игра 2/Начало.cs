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
    public partial class Начало : Form
    {
       
        public Начало()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Продолжить
        private void button2_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        //Выход
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Новая игра
        private void button1_Click(object sender, EventArgs e)
        {
            
            Игра новая = new Игра();
            новая.HP = 50;
            
            новая.Show(); 
            
           this.Hide();
        }

        
    }
}
