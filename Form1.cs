using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        private int[,] matrica = new int[3, 3];
        private int pv = 0;
        private string p1, p2;
        private string poruka;
        private int rez1=0, rez2=0;
        Pen pen;
        Graphics Canvas;
        Point tocka1, tocka2, tocka3, tocka4;
        public void pobijeda()
        {
            // prvi redak
            if (matrica[0,0]==1 &&  matrica[0,1] ==1 && matrica[0,2]==1)
            {
                pictureBox1.BackColor = Color.Aqua;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox3.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
               
            }

            else if (matrica[0, 0] ==0 && matrica[0, 1] ==0 && matrica[0, 2] == 0)
            {
                pictureBox1.BackColor = Color.Aqua;
                pictureBox2.BackColor = Color.Aqua;
                pictureBox3.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
             
            }

            // drugi redak 
            if (matrica[1, 0] == 1 && matrica[1, 1] == 1 && matrica[1, 2] == 1)
            {
                pictureBox4.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox6.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[1, 0] == 0 && matrica[1, 1] == 0 && matrica[1, 2] == 0)
            {
                pictureBox4.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox6.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();

            }



            // treci redak
            if (matrica[2, 0] == 1 && matrica[2, 1] == 1 && matrica[2, 2] == 1)
            {
                pictureBox7.BackColor = Color.Aqua;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[2, 0] == 0 && matrica[2, 1] == 0 && matrica[2, 2] == 0)
            {

                pictureBox7.BackColor = Color.Aqua;
                pictureBox8.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            //prvi stupac
            else if (matrica[0, 0] == 1 && matrica[1, 0] == 1 && matrica[2, 0] == 1)
            {

                pictureBox1.BackColor = Color.Aqua;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox7.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[0, 0] == 0 && matrica[1, 0] == 0 && matrica[2, 0] == 0)
            {

                pictureBox1.BackColor = Color.Aqua;
                pictureBox4.BackColor = Color.Aqua;
                pictureBox7.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            // drugi stupac
            if (matrica[0, 1] == 1 && matrica[1, 1] == 1 && matrica[2, 1] == 1)
            {

                pictureBox2.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox8.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[0, 1] == 0 && matrica[1, 1] == 0 && matrica[2, 1] == 0)
            {

                pictureBox2.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox8.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            // treci stupac
            if (matrica[0, 2] == 1 && matrica[1, 2] == 1 && matrica[2, 2] == 1)
            {

                pictureBox3.BackColor = Color.Aqua;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[0, 2] == 0 && matrica[1, 2] == 0 && matrica[2, 2] == 0)
            {

                pictureBox3.BackColor = Color.Aqua;
                pictureBox6.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            // dijagonala 
            if (matrica[0, 0] == 1 && matrica[1, 1] == 1 && matrica[2, 2] == 1)
            {

                pictureBox1.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[0, 0] == 0 && matrica[1, 1] == 0 && matrica[2, 2] == 0)
            {

                pictureBox1.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox9.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            // dijagonala2 
            if (matrica[2, 0] == 1 && matrica[1, 1] == 1 && matrica[0, 2] == 1)
            {

                pictureBox3.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox7.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox2.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez1++;
                novaigra();
            }

            else if (matrica[2, 0] == 0 && matrica[1, 1] == 0 && matrica[0, 2] == 0)
            {

                pictureBox3.BackColor = Color.Aqua;
                pictureBox5.BackColor = Color.Aqua;
                pictureBox7.BackColor = Color.Aqua;
                poruka = "Pobijedio je " + textBox1.Text + ".";
                MessageBox.Show(poruka, "Pobijeda");
                rez2++;
                novaigra();
            }

            int brojac = 0;
            for (int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (matrica[i, j] == 0 || matrica[i, j] == 1) brojac++;
                }
            }

            if (brojac == 9)
            {
                MessageBox.Show("Nerješeno", "Pobijeda");
                novaigra();
            }
        }

        public void novaigra()
        {
            if (pv == 1) pv = 0;
            else pv = 1;
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            for (int i= 0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    matrica[i, j] = -3;
                }

            }

            pictureBox1.BackColor = Color.LightPink;
            pictureBox2.BackColor = Color.LightPink;
            pictureBox3.BackColor = Color.LightPink;
            pictureBox4.BackColor = Color.LightPink;
            pictureBox5.BackColor = Color.LightPink;
            pictureBox6.BackColor = Color.LightPink;
            pictureBox7.BackColor = Color.LightPink;
            pictureBox8.BackColor = Color.LightPink;
            pictureBox9.BackColor = Color.LightPink;
           

            pictureBox1.Image = null;
            pictureBox1.Invalidate();

            pictureBox2.Image = null;
            pictureBox2.Invalidate();

            pictureBox3.Image = null;
            pictureBox3.Invalidate();

            pictureBox4.Image = null;
            pictureBox4.Invalidate();

            pictureBox5.Image = null;
            pictureBox5.Invalidate();

            pictureBox6.Image = null;
            pictureBox6.Invalidate();

            pictureBox7.Image = null;
            pictureBox7.Invalidate();

            pictureBox8.Image = null;
            pictureBox8.Invalidate();

            pictureBox9.Image = null;
            pictureBox9.Invalidate();

            label1.Text = Convert.ToString(rez2);
            label2.Text = Convert.ToString(rez1);
        }
        

            private void pictureBox3_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox3.CreateGraphics();
            

            if (pv == 1)
            {
                matrica[0, 2] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[0, 2] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }

            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            Canvas = pictureBox4.CreateGraphics();

            if (pv == 1)
            {
                matrica[1, 0] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[1, 0] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }

            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox6.CreateGraphics();
            
            if (pv == 1)
            {
                matrica[1, 2] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[1, 2] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }

            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox7.CreateGraphics();
            
            if (pv == 1)
            {
                matrica[2, 0] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[2, 0] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox9.CreateGraphics();

            
            if (pv == 1)
            {
                matrica[2, 2] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[2, 2] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox5.CreateGraphics();
            
            if (pv == 1)
            {
                matrica[1, 1] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[1, 1] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox8.CreateGraphics();
           
            if (pv == 1)
            {
                matrica[2, 1] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[2, 1] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        public Form1()
        {
            InitializeComponent();
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            tocka1 = new Point(20, 20);
            tocka2 = new Point(80, 80);
            tocka3 = new Point(20, 80);
            tocka4 = new Point(80, 20);
            pen = new Pen(Color.PaleVioletRed, 5);

            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    matrica[i,j] = -3;
                }
            }
            p1 = textBox1.Text;
            p2 = textBox2.Text;
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Canvas = pictureBox2.CreateGraphics();

            

            if (pv == 1)
            {
                matrica[0, 1] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;

            }
            else
            {
                matrica[0, 1] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Canvas = pictureBox1.CreateGraphics();
            
            if (pv==1)
            {
                matrica[0, 0] = 1;
                Canvas.DrawLine(pen, tocka1, tocka2);
                Canvas.DrawLine(pen, tocka3, tocka4);
                pv = 0;
                
            }
            else
            {
                matrica[0, 0] = 0;
                Canvas.DrawEllipse(pen, 25, 25, 50, 50);
                pv = 1;
            }
            if (pv == 1)
            {
                textBox2.BackColor = Color.Cyan;
                textBox1.BackColor = Color.White;
            }
            else
            {
                textBox1.BackColor = Color.Cyan;
                textBox2.BackColor = Color.White;

            }
            pobijeda();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
