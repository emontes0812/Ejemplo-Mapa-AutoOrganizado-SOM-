using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Viajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap a = new Bitmap("forma1.jpg");
        Bitmap b = new Bitmap("forma2.jpg");
        Bitmap c = new Bitmap("forma3.jpg");
        Bitmap d = new Bitmap("forma4.jpg");
        Bitmap tamaño = new Bitmap(500, 500);
        double[] puntos = new double[4];
        double[] patronfig = new double[100];
        int countpatr = 0;
        int count = 0;
        int xptini = 0;
        int yptini = 0;
        int xptout = 0;
        int yptout = 0;
        int x = 0;
        int y = 0;
        int cant = 0;
        int[,] entsom = new int[100,2]; 
        double[] entidn = new double[2];
        List<double> inputsx = new List<double>();
        List<double> inputsy = new List<double>();
        List<double> W1l = new List<double>();
        List<double> W2l = new List<double>();
        List<double> Difl = new List<double>();
        List<Point> posl = new List<Point>();
        double[] W1 = null;
        double[] W2 = null;
        double[] Dif = null;
        Point[] pnts = null;
        double vec;
        int t, tmax = 1000;
        double menor = 100000;
        double[] entpuntos = new double[2];
        int xmen = 0;
        double[] puntosx = null;
        double[] puntosy = null;
        double fc;
        double gamma = 2;
        double zita;
        double dist;
        double theta;
        int coord;
        Red Nred = null;
        double[,] inputs = new double[,] { { 1, 1 }, {0 , 0 }, { 0, 1 }, { 1, 0 } };
        double[,] outputs = new double[,] { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };

        private void buttongenerate_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = null;
            pictureBox1.Image = (Image)tamaño;
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawImage(aleatorio(), 0, 0);
            g.DrawImage(aleatorio(), 50,0);
            g.DrawImage(aleatorio(), 100, 0);
            g.DrawImage(aleatorio(), 150, 0);
            g.DrawImage(aleatorio(), 200, 0);
            g.DrawImage(aleatorio(), 250, 0);
            g.DrawImage(aleatorio(), 300, 0);
            g.DrawImage(aleatorio(), 350, 0);
            g.DrawImage(aleatorio(), 400, 0);
            g.DrawImage(aleatorio(), 450, 0);
            g.DrawImage(aleatorio(), 0, 50);
            g.DrawImage(aleatorio(), 50, 50);
            g.DrawImage(aleatorio(), 100, 50);
            g.DrawImage(aleatorio(), 150, 50);
            g.DrawImage(aleatorio(), 200, 50);
            g.DrawImage(aleatorio(), 250, 50);
            g.DrawImage(aleatorio(), 300, 50);
            g.DrawImage(aleatorio(), 350, 50);
            g.DrawImage(aleatorio(), 400, 50);
            g.DrawImage(aleatorio(), 450, 50);
            g.DrawImage(aleatorio(), 0, 100);
            g.DrawImage(aleatorio(), 50, 100);
            g.DrawImage(aleatorio(), 100, 100);
            g.DrawImage(aleatorio(), 150, 100);
            g.DrawImage(aleatorio(), 200, 100);
            g.DrawImage(aleatorio(), 250, 100);
            g.DrawImage(aleatorio(), 300, 100);
            g.DrawImage(aleatorio(), 350, 100);
            g.DrawImage(aleatorio(), 400, 100);
            g.DrawImage(aleatorio(), 450, 100);
            g.DrawImage(aleatorio(), 0, 150);
            g.DrawImage(aleatorio(), 50, 150);
            g.DrawImage(aleatorio(), 100, 150);
            g.DrawImage(aleatorio(), 150, 150);
            g.DrawImage(aleatorio(), 200, 150);
            g.DrawImage(aleatorio(), 250, 150);
            g.DrawImage(aleatorio(), 300, 150);
            g.DrawImage(aleatorio(), 350, 150);
            g.DrawImage(aleatorio(), 400, 150);
            g.DrawImage(aleatorio(), 450, 150);
            g.DrawImage(aleatorio(), 0, 200);
            g.DrawImage(aleatorio(), 50, 200);
            g.DrawImage(aleatorio(), 100, 200);
            g.DrawImage(aleatorio(), 150, 200);
            g.DrawImage(aleatorio(), 200, 200);
            g.DrawImage(aleatorio(), 250, 200);
            g.DrawImage(aleatorio(), 300, 200);
            g.DrawImage(aleatorio(), 350, 200);
            g.DrawImage(aleatorio(), 400, 200);
            g.DrawImage(aleatorio(), 450, 200);
            g.DrawImage(aleatorio(), 0, 250);
            g.DrawImage(aleatorio(), 50, 250);
            g.DrawImage(aleatorio(), 100, 250);
            g.DrawImage(aleatorio(), 150, 250);
            g.DrawImage(aleatorio(), 200, 250);
            g.DrawImage(aleatorio(), 250, 250);
            g.DrawImage(aleatorio(), 300, 250);
            g.DrawImage(aleatorio(), 350, 250);
            g.DrawImage(aleatorio(), 400, 250);
            g.DrawImage(aleatorio(), 450, 250);
            g.DrawImage(aleatorio(), 0, 300);
            g.DrawImage(aleatorio(), 50, 300);
            g.DrawImage(aleatorio(), 100, 300);
            g.DrawImage(aleatorio(), 150, 300);
            g.DrawImage(aleatorio(), 200, 300);
            g.DrawImage(aleatorio(), 250, 300);
            g.DrawImage(aleatorio(), 300, 300);
            g.DrawImage(aleatorio(), 350, 300);
            g.DrawImage(aleatorio(), 400, 300);
            g.DrawImage(aleatorio(), 450, 300);
            g.DrawImage(aleatorio(), 0, 350);
            g.DrawImage(aleatorio(), 50, 350);
            g.DrawImage(aleatorio(), 100, 350);
            g.DrawImage(aleatorio(), 150, 350);
            g.DrawImage(aleatorio(), 200, 350);
            g.DrawImage(aleatorio(), 250, 350);
            g.DrawImage(aleatorio(), 300, 350);
            g.DrawImage(aleatorio(), 350, 350);
            g.DrawImage(aleatorio(), 400, 350);
            g.DrawImage(aleatorio(), 450, 350);
            g.DrawImage(aleatorio(), 0, 400);
            g.DrawImage(aleatorio(), 50, 400);
            g.DrawImage(aleatorio(), 100, 400);
            g.DrawImage(aleatorio(), 150, 400);
            g.DrawImage(aleatorio(), 200, 400);
            g.DrawImage(aleatorio(), 250, 400);
            g.DrawImage(aleatorio(), 300, 400);
            g.DrawImage(aleatorio(), 350, 400);
            g.DrawImage(aleatorio(), 400, 400);
            g.DrawImage(aleatorio(), 450, 400);
            g.DrawImage(aleatorio(), 0, 450);
            g.DrawImage(aleatorio(), 50, 450);
            g.DrawImage(aleatorio(), 100, 450);
            g.DrawImage(aleatorio(), 150, 450);
            g.DrawImage(aleatorio(), 200, 450);
            g.DrawImage(aleatorio(), 250, 450);
            g.DrawImage(aleatorio(), 300, 450);
            g.DrawImage(aleatorio(), 350, 450);
            g.DrawImage(aleatorio(), 400, 450);
            g.DrawImage(aleatorio(), 450, 450);
   
            pictureBox1.Refresh();

        }
        private Bitmap aleatorio()
        {
            Bitmap salida = new Bitmap(50, 50);
            Random r = new Random(DateTime.Now.Millisecond);
            System.Threading.Thread.Sleep(10);
            int f = r.Next(1, 5);
            patronfig[countpatr] = f;
            System.Console.WriteLine(countpatr + 1);
            System.Console.WriteLine(patronfig[countpatr]);
            countpatr=countpatr+1;
            switch (f)
            {
                case 1:
                    salida = a;
                    break;
                case 2:
                    salida = b;
                    break;
                case 3:
                    salida = c;
                    break;
                case 4:
                    salida = d;
                    break;
            }
            return salida;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Image = (Image)tamaño;
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            MouseEventArgs eM = (MouseEventArgs)e;
            Pen lapiz = new Pen(Color.Red, 2);
            g.DrawRectangle(lapiz, new Rectangle(eM.X, eM.Y, 3, 3));
            puntos[count] = eM.X;
            puntos[count+1] = eM.Y;
            count = count + 2;
            System.Console.WriteLine(eM.X);
            System.Console.WriteLine(eM.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xpi = puntos[0] / 50;
            double ypi = puntos[1] / 50;
            double xpo = puntos[2] / 50;
            double ypo = puntos[3] / 50;
            xptini = Convert.ToInt32(Math.Floor(xpi));
            yptini = Convert.ToInt32(Math.Floor(ypi));
            xptout = Convert.ToInt32(Math.Floor(xpo));
            yptout = Convert.ToInt32(Math.Floor(ypo));
            xptini = ((xptini + 1) * 50) - 25;
            yptini = ((yptini + 1) * 50) - 25;
            xptout = ((xptout + 1) * 50) - 25;
            yptout = ((yptout + 1) * 50) - 25;
            pictureBox1.Image = (Image)tamaño;
            Color color1 = tamaño.GetPixel(xptini - 17, yptini);
            Color color2 = tamaño.GetPixel(xptini + 17, yptini);
            if (color1.GetBrightness() < 1)
                entidn[0]=1;
            else
                entidn[0] = 0;
            if (color2.GetBrightness() < 1)
                entidn[1] = 1;
            else
                entidn[1] = 0;
            double[] salidabackpr = new double[outputs.GetLength(1)];
            salidabackpr = Nred.Test(entidn);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen lapiz = new Pen(Color.Red, 2);
            if (salidabackpr[0] < 0.5 && salidabackpr[1] < 0.5)
            {
                label1.Text = "Es Circulo";
                for (int pp = 0; pp < 100; pp++)
                {
                    if(patronfig[pp]==1)
                    {
                        cant=cant+1;
                        if(pp<10)
                        {
                           x=((pp+1)*50)-25;
                           y=25;
                           entsom[pp, 0] = x;
                           entsom[pp, 1] = y;
                           g.DrawRectangle(lapiz, new Rectangle(x,y , 3, 3));
                        }
                        if (pp>=10 && pp < 20)
                        {
                            x = (((pp-10) + 1) * 50) - 25;
                            y = 75;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 20 && pp < 30)
                        {
                            x = (((pp - 20) + 1) * 50) - 25;
                            y = 125;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 30 && pp < 40)
                        {
                            x = (((pp - 30) + 1) * 50) - 25;
                            y = 175;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 40 && pp < 50)
                        {
                            x = (((pp - 40) + 1) * 50) - 25;
                            y = 225;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 50 && pp < 60)
                        {
                            x = (((pp - 50) + 1) * 50) - 25;
                            y = 275;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 60 && pp < 70)
                        {
                            x = (((pp - 60) + 1) * 50) - 25;
                            y = 325;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 70 && pp < 80)
                        {
                            x = (((pp - 70) + 1) * 50) - 25;
                            y = 375;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 80 && pp < 90)
                        {
                            x = (((pp - 80) + 1) * 50) - 25;
                            y = 425;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 90 && pp < 100)
                        {
                            x = (((pp - 90) + 1) * 50) - 25;
                            y = 475;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                    }
                    if(patronfig[pp]!=1)
                    {
                        entsom[pp, 0] = 0;
                        entsom[pp, 1] = 0;
                    }
                }
            }
            if (salidabackpr[0] < 0.5 && salidabackpr[1] > 0.5)
            {
                label1.Text = "Es Triangulo";
                for (int pp = 0; pp < 100; pp++)
                {
                    if (patronfig[pp] == 3)
                    {
                        cant = cant + 1;
                        if (pp < 10)
                        {
                            x = ((pp + 1) * 50) - 25;
                            y = 25;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 10 && pp < 20)
                        {
                            x = (((pp - 10) + 1) * 50) - 25;
                            y = 75;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 20 && pp < 30)
                        {
                            x = (((pp - 20) + 1) * 50) - 25;
                            y = 125;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 30 && pp < 40)
                        {
                            x = (((pp - 30) + 1) * 50) - 25;
                            y = 175;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 40 && pp < 50)
                        {
                            x = (((pp - 40) + 1) * 50) - 25;
                            y = 225;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 50 && pp < 60)
                        {
                            x = (((pp - 50) + 1) * 50) - 25;
                            y = 275;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 60 && pp < 70)
                        {
                            x = (((pp - 60) + 1) * 50) - 25;
                            y = 325;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 70 && pp < 80)
                        {
                            x = (((pp - 70) + 1) * 50) - 25;
                            y = 375;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 80 && pp < 90)
                        {
                            x = (((pp - 80) + 1) * 50) - 25;
                            y = 425;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 90 && pp < 100)
                        {
                            x = (((pp - 90) + 1) * 50) - 25;
                            y = 475;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                    }
                    if (patronfig[pp] != 3)
                    {
                        entsom[pp, 0] = 0;
                        entsom[pp, 1] = 0;
                    }
                }
            }
            if (salidabackpr[0] > 0.5 && salidabackpr[1] < 0.5)
            {
                label1.Text = "Es Cuadrado";
                for (int pp = 0; pp < 100; pp++)
                {
                    if (patronfig[pp] == 2)
                    {
                        cant = cant + 1;
                        if (pp < 10)
                        {
                            x = ((pp + 1) * 50) - 25;
                            y = 25;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 10 && pp < 20)
                        {
                            x = (((pp - 10) + 1) * 50) - 25;
                            y = 75;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 20 && pp < 30)
                        {
                            x = (((pp - 20) + 1) * 50) - 25;
                            y = 125;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 30 && pp < 40)
                        {
                            x = (((pp - 30) + 1) * 50) - 25;
                            y = 175;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 40 && pp < 50)
                        {
                            x = (((pp - 40) + 1) * 50) - 25;
                            y = 225;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 50 && pp < 60)
                        {
                            x = (((pp - 50) + 1) * 50) - 25;
                            y = 275;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 60 && pp < 70)
                        {
                            x = (((pp - 60) + 1) * 50) - 25;
                            y = 325;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 70 && pp < 80)
                        {
                            x = (((pp - 70) + 1) * 50) - 25;
                            y = 375;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 80 && pp < 90)
                        {
                            x = (((pp - 80) + 1) * 50) - 25;
                            y = 425;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 90 && pp < 100)
                        {
                            x = (((pp - 90) + 1) * 50) - 25;
                            y = 475;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                    }
                    if (patronfig[pp] != 2)
                    {
                        entsom[pp, 0] = 0;
                        entsom[pp, 1] = 0;
                    }
                }
            }
            if (salidabackpr[0] > 0.5 && salidabackpr[1] > 0.5)
            {
                label1.Text = "Es Hexagono";
                for (int pp = 0; pp < 100; pp++)
                {
                    if (patronfig[pp] == 4)
                    {
                        cant = cant + 1;
                        if (pp < 10)
                        {
                            x = ((pp + 1) * 50) - 25;
                            y = 25;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 10 && pp < 20)
                        {
                            x = (((pp - 10) + 1) * 50) - 25;
                            y = 75;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 20 && pp < 30)
                        {
                            x = (((pp - 20) + 1) * 50) - 25;
                            y = 125;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 30 && pp < 40)
                        {
                            x = (((pp - 30) + 1) * 50) - 25;
                            y = 175;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 40 && pp < 50)
                        {
                            x = (((pp - 40) + 1) * 50) - 25;
                            y = 225;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 50 && pp < 60)
                        {
                            x = (((pp - 50) + 1) * 50) - 25;
                            y = 275;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 60 && pp < 70)
                        {
                            x = (((pp - 60) + 1) * 50) - 25;
                            y = 325;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 70 && pp < 80)
                        {
                            x = (((pp - 70) + 1) * 50) - 25;
                            y = 375;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 80 && pp < 90)
                        {
                            x = (((pp - 80) + 1) * 50) - 25;
                            y = 425;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                        if (pp >= 90 && pp < 100)
                        {
                            x = (((pp - 90) + 1) * 50) - 25;
                            y = 475;
                            entsom[pp, 0] = x;
                            entsom[pp, 1] = y;
                            g.DrawRectangle(lapiz, new Rectangle(x, y, 3, 3));
                        }
                    }
                    if (patronfig[pp] != 4)
                    {
                        entsom[pp, 0] = 0;
                        entsom[pp, 1] = 0;
                    }
                }
            }
   
        }

        void Entrenamiento()
        {

            Nred = new Red(inputs.GetLength(1), (int)15, (int)outputs.GetLength(1));
            Nred.Ajustes();
            Nred.Entrenamiento(inputs, outputs, (int)50000, progressBar1);

        }

        private void buttontrain_Click(object sender, EventArgs e)
        {
            Entrenamiento();
        }

        private void buttonsom_Click(object sender, EventArgs e)
        {
            int [,] listaentr=new int [cant,2];
            int offc = 0;
           for(int pp=0;pp<100;pp++)
           {
               if (entsom[pp, 0] != 0)
               {
                   listaentr[pp-offc, 0] = entsom[pp, 0];
                   listaentr[pp-offc, 1] = entsom[pp, 1];
               }
               else
                   offc = offc + 1;
           }
           System.Console.Write("inicio");
           inputsx.Add(((puntos[0]+25)/50)-1);
           inputsy.Add(((puntos[1]+25) / 50)-1);
           for (int pp = 0; pp < cant;pp++ )
           {
               inputsx.Add(((listaentr[pp,0]+25)/50)-1);
               System.Console.Write(((listaentr[pp, 0] + 25) / 50)-1);
               inputsy.Add(((listaentr[pp,1]+25)/50)-1);
               System.Console.WriteLine(((listaentr[pp, 1] + 25) / 50)-1);
           }
           inputsx.Add(((puntos[2]+25) / 50)-1);
           inputsy.Add(((puntos[3]+25) / 50)-1);
           pictureBox1.Image = (Image)tamaño;
           Graphics g = Graphics.FromImage(pictureBox1.Image);
           puntosx = inputsx.ToArray();
           puntosy = inputsy.ToArray();

           for (int i = 0; i < 2 * inputsx.Count; i++)
           {
               W1l.Add(0);
               W2l.Add(0);
               Difl.Add(0);
           }

           W1 = W1l.ToArray();
           W2 = W2l.ToArray();
           Dif = Difl.ToArray();
           theta = 2 * Math.PI / W1l.Count;

           Random r = new Random(DateTime.Now.Millisecond);
           for (int i = 0; i < W1l.Count; i++)
           {
               W1[i] = 4 * Math.Cos(theta * (i + 1)) + 4;
               W2[i] = 4 * Math.Sin(theta * (i + 1)) + 4;
           }

           progressBar2.Maximum = tmax;
           progressBar2.Minimum = 0;

           for (t = 0; t < tmax; t++)
           {
               fc = 1 / Math.Pow((t + 1), 0.25);
               menor = 100000;
               coord = r.Next(0, inputsx.Count);
               entpuntos[0] = puntosx[coord];
               entpuntos[1] = puntosy[coord];
               for (int x = 0; x < W1l.Count; x++)
               {
                   Dif[x] = Math.Pow((Math.Pow(entpuntos[0] - W1[x], 2) + Math.Pow((entpuntos[1] - W2[x]), 2)), 0.5);
                   if (Dif[x] < menor)
                   {
                       menor = Dif[x];
                       xmen = x;
                   }
               }
               gamma = gamma * (1 - (0.0005 * t));
               for (int x = 0; x < W1l.Count; x++)
               {
                   dist = Math.Pow(Math.Min(Math.Abs(x - xmen), W1l.Count - Math.Abs(x - xmen)), 2);
                   zita = Math.Pow(gamma, 2);
                   vec = Math.Exp(-dist / zita);
                   W1[x] = W1[x] + fc * vec * (entpuntos[0] - W1[x]);
                   W2[x] = W2[x] + fc * vec * (entpuntos[1] - W2[x]);
               }
               progressBar2.Value = t;
               posl.Clear();
               for (int i = 0; i < W1l.Count; i++)
               {
                   Point pon = new Point();
                   pon.X = System.Convert.ToInt16(50 * W1[i] + 25);
                   pon.Y = System.Convert.ToInt16(50 * W2[i] + 25);
                   posl.Add(pon);
               }
               pnts = posl.ToArray();
               Pen lapiz = new Pen(Color.Aquamarine, 1);
               g.DrawPolygon(lapiz, pnts);
               pictureBox1.BackgroundImage = tamaño;
               pictureBox1.Refresh();
               Application.DoEvents();
               System.Threading.Thread.Sleep(1);
           }
           Pen lapizv = new Pen(Color.Blue, 3);
           g.DrawPolygon(lapizv, pnts);
           pictureBox1.Refresh();

        }
    }
}
