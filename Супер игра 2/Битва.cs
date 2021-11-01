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
    public partial class Битва : Form
    {
        public  Игра p = new Игра();
        public Колода l = new Колода();
        public int time = 0, h = 0, vre = 0, hod = 3, yd = 0, z = 0, p11 = 0, p22 = 0, p33 = 0, p44 = 0, p55 = 0;
        public int monx = 40, monm = 40, damagemonstra = 11, kon = 0, s = 0, k = 10;
        public Random r = new Random();
        bool y1 = true, y2 = true, y3 = true, s4 = true, s5 = true, s6 = true, l7 = true, l8 = true, k9 = true, l10 = true;
        public void en ()
        {
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Top += 70;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Удар
            if (p33 == 1 || p33 == 2 || p33 == 3)
            {
                pictureBox11.Image = Properties.Resources.Card_back_01_svg;
                timer3.Start();
                pictureBox11.Enabled = false;
            }

            // Щит
            else if (p33 == 4 || p33 == 5 || p33 == 6)
            {
                z += 5;
                label5.Text = "" + z;
                hod--;
                pictureBox11.Image = Properties.Resources.Card_back_01_svg;
                pictureBox11.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;

                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
            }

            // Красная пелена
            else if (p33 == 9)
            {
                hod += 2;
                label3.Text = hod + "/3";
                pictureBox11.Image = Properties.Resources.Card_back_01_svg;
                pictureBox11.Enabled = false;

            }

            // Лечение
            else if (p33 == 7 || p33 == 8 || p33 == 10)
            {
                p.HP += 4;
                hod--;
                label3.Text = hod + "/3";
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();
                pictureBox11.Image = Properties.Resources.Card_back_01_svg;
                pictureBox11.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
               
            }
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            // Удар
            if (p44 == 1 || p44 == 2 || p44 == 3)
            {
                pictureBox10.Image = Properties.Resources.Card_back_01_svg;
                timer3.Start();
                pictureBox10.Enabled = false;
            }

            // Щит
            else if (p44 == 4 || p44 == 5 || p44 == 6)
            {
                z += 5;
                label5.Text = "" + z;
                hod--;
                pictureBox10.Image = Properties.Resources.Card_back_01_svg;
                pictureBox10.Enabled = false;
                if (hod == 0)                   
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
            }

            // Красная пелена
            else if (p44 == 9)
            {
                hod += 2;
                label3.Text = hod + "/3";
                pictureBox10.Image = Properties.Resources.Card_back_01_svg;
                pictureBox10.Enabled = false;
            }

            // Лечение
            else if (p44 == 7 || p44 == 8 || p44 == 10)
            {
                p.HP += 4;
                hod--;
                label3.Text = hod + "/3";
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();
                pictureBox10.Image = Properties.Resources.Card_back_01_svg;
                pictureBox10.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }

            }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Удар
            if (p55 == 1 || p55 == 2 || p55 == 3)
            {
                pictureBox9.Image = Properties.Resources.Card_back_01_svg;
                timer3.Start();
                pictureBox9.Enabled = false;
            }

            // Щит
            else if (p55 == 4 || p55 == 5 || p55 == 6)
            {
                z += 5;
                label5.Text = "" + z;
                hod--;
                pictureBox9.Image = Properties.Resources.Card_back_01_svg;
                pictureBox9.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
            }

            // Красная пелена
            else if (p55 == 9)
            {
                hod += 2;
                label3.Text = hod + "/3";
                pictureBox9.Image = Properties.Resources.Card_back_01_svg;
                pictureBox9.Enabled = false;
            }

            // Лечение
            else if (p55 == 7 || p55 == 8 || p55 == 10)
            {
                p.HP += 4;
                hod--;
                label3.Text = hod + "/3";
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();
                pictureBox9.Image = Properties.Resources.Card_back_01_svg;
                pictureBox9.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
                
            }
            pictureBox9.Enabled = false;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Top += 70;
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            pictureBox11.Top -= 70;
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            pictureBox10.Top -= 70;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Top += 70;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Top += 70;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.Top -= 70;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Top -= 70;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Удар
            if (p11 == 1 || p11 == 2 || p11 == 3)
            {
                pictureBox8.Image = Properties.Resources.Card_back_01_svg;
                timer3.Start();
                pictureBox8.Enabled = false;
            }

            // Щит
            else if (p11 == 4 || p11 == 5 || p11 == 6)
            {
                z += 5;
                label5.Text = "" + z;
                hod--;
                pictureBox8.Image = Properties.Resources.Card_back_01_svg;
                pictureBox8.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
            }

            // Красная пелена
            else if (p11 == 9)
            {
                hod += 2;
                label3.Text = hod + "/3";
                pictureBox8.Image = Properties.Resources.Card_back_01_svg;
                pictureBox8.Enabled = false;
            }

            // Лечение
            else if (p11 == 7 || p11 == 8 || p11 == 10)
            {
                p.HP += 4;
                hod--;
                label3.Text = hod + "/3";
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();
                pictureBox8.Image = Properties.Resources.Card_back_01_svg;
                pictureBox8.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
                
            }
            
        }

        public void sbros()
        {
            y1 = true; y2 = true; y3 = true; s4 = true; s5 = true; s6 = true; l7 = true; l8 = true; k9 = true; l10 = true;
        }
        public void p1()
        {
            p11 = r.Next(1, 10);
            if (p11 == 1 && y1 == true)
            {
                pictureBox8.Image = Properties.Resources.Удар1;
                y1 = false;
            }
            else if (p11 == 2 && y2 == true)
            {
                pictureBox8.Image = Properties.Resources.Удар1;
                y2 = false;
            }
            else if (p11 == 3 && y3 == true)
            {
                pictureBox8.Image = Properties.Resources.Удар1;
                y3 = false;
            }
            else if (p11 == 4 && s4 == true)
            {
                pictureBox8.Image = Properties.Resources.Щит;
                s4 = false;
            }
            else if (p11 == 5 && s5 == true)
            {
                pictureBox8.Image = Properties.Resources.Щит;
                s5 = false;
            }
            else if (p11 == 6 && s6 == true)
            {
                pictureBox8.Image = Properties.Resources.Щит;
                s6 = false;
            }
            else if (p11 == 7 && l7 == true)
            {
                pictureBox8.Image = Properties.Resources.Лечение;
                l7 = false;
            }
            else if (p11 == 8 && l8 == true)
            {
                pictureBox8.Image = Properties.Resources.Лечение;
                l8 = false;
            }
            else if (p11 == 9 && k9 == true)
            {
                pictureBox8.Image = Properties.Resources.Красная;
                k9 = false;
            }
            else if (p11 == 10 && l10 == true)
            {
                pictureBox8.Image = Properties.Resources.Лечение;
            }

        }
        public void p2()
        {
            p22 = r.Next(1, 10);
            if (p22 == 1 && y1 == true)
            {
                pictureBox2.Image = Properties.Resources.Удар1;
            }
            else if (p22 == 2 && y2 == true)
            {
                pictureBox2.Image = Properties.Resources.Удар1;
            }
            else if (p22 == 3 && y3 == true)
            {
                pictureBox2.Image = Properties.Resources.Удар1;
            }
            else if (p22 == 4 && s4 == true)
            {
                pictureBox2.Image = Properties.Resources.Щит;
            }
            else if (p22 == 5 && s5 == true)
            {
                pictureBox2.Image = Properties.Resources.Щит;
            }
            else if (p22 == 6 && s6 == true)
            {
                pictureBox2.Image = Properties.Resources.Щит;
            }
            else if (p22 == 7 && l7 == true)
            {
                pictureBox2.Image = Properties.Resources.Лечение;
            }
            else if (p22 == 8 && l8 == true)
            {
                pictureBox2.Image = Properties.Resources.Лечение;
            }
            else if (p22 == 9 && k9 == true)
            {
                pictureBox2.Image = Properties.Resources.Красная;
            }
            else if (p22 == 10 && l10 == true)
            {
                pictureBox2.Image = Properties.Resources.Лечение;
            }
            else
                p2();
            
                
        }
        public void p3()
        {
            p33 = r.Next(1, 10);
            if (p33 == 1 && y1 == true)
            {
                pictureBox11.Image = Properties.Resources.Удар1;
            }
            else if (p33 == 2 && y2 == true)
            {
                pictureBox11.Image = Properties.Resources.Удар1;
            }
            else if (p33 == 3 && y3 == true)
            {
                pictureBox11.Image = Properties.Resources.Удар1;
            }
            else if (p33 == 4 && s4 == true)
            {
                pictureBox11.Image = Properties.Resources.Щит;
            }
            else if (p33 == 5 && s5 == true)
            {
                pictureBox11.Image = Properties.Resources.Щит;
            }
            else if (p33 == 6 && s6 == true)
            {
                pictureBox11.Image = Properties.Resources.Щит;
            }
            else if (p33 == 7 && l7 == true)
            {
                pictureBox11.Image = Properties.Resources.Лечение;
            }
            else if (p33 == 8 && l8 == true)
            {
                pictureBox11.Image = Properties.Resources.Лечение;
            }
            else if (p33 == 9 && k9 == true)
            {
                pictureBox11.Image = Properties.Resources.Красная;
            }
            else if (p33 == 10 && l10 == true)
            {
                pictureBox11.Image = Properties.Resources.Лечение;
            }
            else p3();
        }
        public void p4()
        {
            p44 = r.Next(1, 10);
            if (p44 == 1 && y1 == true)
            {
                pictureBox10.Image = Properties.Resources.Удар1;
            }
            else if (p44 == 2 && y2 == true)
            {
                pictureBox10.Image = Properties.Resources.Удар1;
            }
            else if (p44 == 3 && y3 == true)
            {
                pictureBox10.Image = Properties.Resources.Удар1;
            }
            else if (p44 == 4 && s4 == true)
            {
                pictureBox10.Image = Properties.Resources.Щит;
            }
            else if (p44 == 5 && s5 == true)
            {
                pictureBox10.Image = Properties.Resources.Щит;
            }
            else if (p44 == 6 && s6 == true)
            {
                pictureBox10.Image = Properties.Resources.Щит;
            }
            else if (p44 == 7 && l7 == true)
            {
                pictureBox10.Image = Properties.Resources.Лечение;
            }
            else if (p44 == 8 && l8 == true)
            {
                pictureBox10.Image = Properties.Resources.Лечение;
            }
            else if (p44 == 9 && k9 == true)
            {
                pictureBox10.Image = Properties.Resources.Красная;
            }
            else if (p44 == 10 && l10 == true)
            {
                pictureBox10.Image = Properties.Resources.Лечение;
            }
            else p4();
        }
        public void p5()
        {
            p55 = r.Next(1, 10);
            if (p55 == 1 && y1 == true)
            {
                pictureBox9.Image = Properties.Resources.Удар1;
            }
            else if (p55 == 2 && y2 == true)
            {
                pictureBox9.Image = Properties.Resources.Удар1;
            }
            else if (p55 == 3 && y3 == true)
            {
                pictureBox9.Image = Properties.Resources.Удар1;
            }
            else if (p55 == 4 && s4 == true)
            {
                pictureBox9.Image = Properties.Resources.Щит;
            }
            else if (p55 == 5 && s5 == true)
            {
                pictureBox9.Image = Properties.Resources.Щит;
            }
            else if (p55 == 6 && s6 == true)
            {
                pictureBox9.Image = Properties.Resources.Щит;
            }
            else if (p55 == 7 && l7 == true)
            {
                pictureBox9.Image = Properties.Resources.Лечение;
            }
            else if (p55 == 8 && l8 == true)
            {
                pictureBox9.Image = Properties.Resources.Лечение;
            }
            else if (p55 == 9 && k9 == true)
            {
                pictureBox9.Image = Properties.Resources.Красная;
            }
            else if (p55 == 10 && l10 == true)
            {
                pictureBox9.Image = Properties.Resources.Лечение;
            }
            else p5();
        }
        public void ya()
        {
            if (p.HP <= 0)
            {
                MessageBox.Show("Вы проиграли!");
                Application.Exit();
            }


        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Top -= 70;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Top += 70;
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            // Удар
            if (p22 == 1 || p22 == 2 || p22 == 3)
            {
                pictureBox2.Image = Properties.Resources.Card_back_01_svg;
                timer3.Start();
                pictureBox2.Enabled = false;
            }

            // Щит
            else if (p22 == 4 || p22 == 5 || p22 == 6)
            {
                z += 5;
                label5.Text = "" + z;
                hod--;
                pictureBox2.Image = Properties.Resources.Card_back_01_svg;
                pictureBox2.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
            }

            // Красная пелена
            else if (p22 == 9)
            {
                hod += 2;
                label3.Text = hod + "/3";
                pictureBox2.Image = Properties.Resources.Card_back_01_svg;
                pictureBox2.Enabled = false;
            }

            // Лечение
            else if (p22 == 7 || p22 == 8 || p22 == 10)
            {
                p.HP += 4;
                hod--;
                label3.Text = hod + "/3";
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();
                pictureBox2.Image = Properties.Resources.Card_back_01_svg;
                pictureBox2.Enabled = false;
                if (hod == 0)
                {
                    k -= 5;
                    s += 5;
                    if (s == 10)
                    {
                        sbros();
                        s = 0;
                        k = 10;
                    }
                    hodmonstra();
                    ya();
                    smertm();
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    hod = 3;
                    label3.Text = hod + "/3";
                    z = 0;
                    label5.Text = "" + z;
                    en();
                    p1();
                    p2();
                    p3();
                    p4();
                    p5();
                    en();
                }
                
            }    
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s == 10)
            {
                sbros();
                s = 0;
                k = 10;
            }
            hodmonstra();
            ya();
            smertm();
            label4.Text = "Здоровье " + monx + "/" + monm.ToString();
            hod = 3;
            label3.Text = hod + "/3";
            z = 0;
            label5.Text = "" + z;
            en();
            p1();
            p2();
            p3();
            p4();
            p5();
            en();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            vre++;

          // Удар мой
            if (yd == 0)
            {
                pictureBox1.Image = Супер_игра_2.Properties.Resources.Ударчик;
                if(vre == 10)
                {
                       monx -= 6;
                       hod--;
                       label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                       label3.Text = hod + "/3";                                           
                       vre = 0;
                       pictureBox1.Image = Супер_игра_2.Properties.Resources._22222;
                       
                   
                    // Если ходов 0
                   timer3.Stop(); 
                       smertm();
                    if (hod == 0)
                    {
                        k -= 5;
                        s += 5;
                        if (s == 10)
                        {
                            sbros();
                            s = 0;
                            k = 10;
                        }
                        hodmonstra();
                        ya();
                        smertm();
                        label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                        hod = 3;
                        label3.Text = hod + "/3";
                        en();
                        p1();
                        p2();
                        p3();
                        p4();
                        p5();
                        en();
                    }

                    
                }
            }
        }


        //Ход монстра
        public void hodmonstra()
        {
            
            if (kon == 0)
            {
                p.HP = p.HP - damagemonstra + z;
                h = 0;
                kon = 1;
                pictureBox3.Image = Супер_игра_2.Properties.Resources.pngwing_com__3_;
               label2.Text = "Здоровье " + p.HP + "/" + p.HPM.ToString();

            }
            else if (kon == 1)
            {
                timer2.Start();               
                

            }
            else if (kon == 2)
            {

            }
            else if (kon == 3)
            {

            }
            damagemonstra += 2;
        }

        // Колода
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            l.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            vre++;

            

            // Лечение врага
            if (kon == 1)
            {
               pictureBox1.Image = Супер_игра_2.Properties.Resources.Heal_nts;
                if (vre == 10)
                {
                    
                    pictureBox1.Image = Супер_игра_2.Properties.Resources._22222;
                    kon = 0;
                    pictureBox3.Image = Супер_игра_2.Properties.Resources.pngwing_com__1_;
                    vre = 0;

                    // Лечение
                       if (monx < 30)
                         {

                                if (monx >= 26)
                               {
                                monx = 30;
                               }
                                 else
                               {
                                    monx += 4;
                                }
                         }
                    label4.Text = "Здоровье " + monx + "/" + monm.ToString();
                    timer2.Stop();
                    
                }
            }
        }

        public void smertm()
        {

            if (monx < 0)
            {
                monx = 0;
                label4.Text = "Здоровье " + monx + "/" + monm.ToString();               
            }
            if (monx == 0)
            {
                MessageBox.Show("Поздравляю с победой!");
                p.GOLD += 25;
                p.pictureBox4.Enabled = false;
                this.Close();

            }
        }
        
        public Битва()
        {
            InitializeComponent();
            timer1.Start();
        }

        //Таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = hod + "/3";
            label5.Text = "" + z;
            time++;
            label1.Text = "Time " + time/10;
            if (p.HP>50)
            {
                p.HP = 50;
                label2.Text = "Здоровье " + p.HP + "/" + p.HPM;
            }
            label6.Text = "" + k;
                label7.Text = "" + s;
        }

        private void Битва_Load(object sender, EventArgs e)
        {

            label2.Text = "Здоровье " + p.HP + "/" + p.HPM;

            label4.Text = "Здоровье " + monx + "/" + monm;
            en();
            p1();
            p2();
            p3();
            p4();
            p5();

        }

    }
}
