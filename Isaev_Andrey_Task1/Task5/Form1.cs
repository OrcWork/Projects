using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        int[] l_p = new int[4];
        int[] c_p = new int[3];
        int[] r_p = new int[4];
        int[] rin_p = new int[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //Линия
        private void linebutton_Click(object sender, EventArgs e)
        {
            try
            {

                l_p[0] = Convert.ToInt32(textBox1.Text);// координата X1
                l_p[1] = Convert.ToInt32(textBox2.Text);// координата Y1
                l_p[2] = Convert.ToInt32(textBox3.Text);// координата X2
                l_p[3] = Convert.ToInt32(textBox4.Text);// координата Y2

            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры");
            }

            // Построение линии и ресчет ее длинны
            if (l_p[0] < 500 & l_p[0] > 0 & l_p[1] < 600 & l_p[1] > 0 & l_p[2] < 500 & l_p[2] > 0 & l_p[3] < 600 & l_p[3] > 0)
            {
                double l = Math.Sqrt((l_p[2] - l_p[0]) * (l_p[2] - l_p[0]) + (l_p[3] - l_p[1]) * (l_p[3] - l_p[1]));
                label27.Text = "l = " + l;

                pictureBox2.Refresh();
                Graphics g = pictureBox2.CreateGraphics();
                Pen p = new Pen(Color.Black);
                g.DrawLine(p, new Point(l_p[0], l_p[1]), new Point(l_p[2], l_p[3]));
            }
            else
            {
                MessageBox.Show("Заданные координаты выходят за приделы поля");
            }

        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Построение окружности и ресчет ее длинны и площади
        private void circlebutton_Click(object sender, EventArgs e)
        {

            try
            {
                c_p[0] = Convert.ToInt32(textBox5.Text);// координата X центра круга
                c_p[1] = Convert.ToInt32(textBox6.Text);// координата Y центра круга
                c_p[2] = Convert.ToInt32(textBox7.Text);// радиус круга

            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры");
            }

            
            //Расчет площади и длинны окружности
            if (c_p[0] + c_p[2] <= 500 & c_p[0] + c_p[2] >= 0 & c_p[1] + c_p[2] <= 600 & c_p[1] + c_p[2] >= 0
                & c_p[0] - c_p[2] >= 0 & c_p[1] - c_p[2] >= 0)
            {
                double c = 2 * 3.1416 * c_p[2];
                label22.Text = "С = " + c;
                double s = 3.1416 * c_p[2] * c_p[2] / 2;
                label23.Text = "S = " + s;

                pictureBox2.Refresh();
                Graphics g = pictureBox2.CreateGraphics();
                Pen p = new Pen(Color.Black);
                int x1 = c_p[0] - c_p[2];
                int y1 = c_p[1] - c_p[2];
                RectangleF rect = new RectangleF(x1, y1, c_p[2] * 2, c_p[2] * 2);
                g.DrawEllipse(p, rect);
            }
            else
            {
                MessageBox.Show("Заданные координаты выходят за приделы поля");
            }
        }

        //Построение прямоугольника и ресчет его периметра и площади
        private void rectanglebutton_Click(object sender, EventArgs e)
        {


            try
            {
                r_p[0] = Convert.ToInt32(textBox8.Text);// координата X1
                r_p[1] = Convert.ToInt32(textBox9.Text);// координата Y1
                r_p[2] = Convert.ToInt32(textBox10.Text);// координата X2
                r_p[3] = Convert.ToInt32(textBox11.Text);// координата Y2

            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры");
            }

            if (r_p[0] < 500 & r_p[0] > 0 & r_p[1] < 600 & r_p[1] > 0 & r_p[2] < 500 & r_p[2] > 0 & r_p[3] < 600 & r_p[3] > 0)
            {
                //Расчет площади и периметра
                int perim = 2 * (r_p[2] - r_p[0] + r_p[3] - r_p[1]);
                label20.Text = "P = " + perim;
                int s = (r_p[2] - r_p[0]) * (r_p[3] - r_p[1]);
                label21.Text = "S = " + s;

                pictureBox2.Refresh();

                Graphics g = pictureBox2.CreateGraphics();
                Pen p = new Pen(Color.Black);
                g.DrawRectangle(p, r_p[0], r_p[1], r_p[2] - r_p[0], r_p[3] - r_p[1]);
            }
            else
            {
                MessageBox.Show("Заданные координаты выходят за приделы поля");
            }
        }

        //Построение колца и ресчет его длинны и площади
        private void ringbutton_Click(object sender, EventArgs e)
        {
            try
            {
                rin_p[0] = Convert.ToInt32(textBox12.Text);// координата X центра круга
                rin_p[1] = Convert.ToInt32(textBox13.Text);// координата Y центра круга
                rin_p[2] = Convert.ToInt32(textBox14.Text);// радиус круга R
                rin_p[3] = Convert.ToInt32(textBox15.Text);// радиус круга r

            }
            catch
            {
                MessageBox.Show("Введены некорректные параметры");
            }



            //Расчет площади и длинны окружности кольца

            if (rin_p[0] + rin_p[2] <= 500 & rin_p[0] + rin_p[2] >= 0 & rin_p[1] + rin_p[2] <= 600 & rin_p[1] + rin_p[2] >= 0
                & rin_p[0] - rin_p[2] >= 0 & rin_p[1] - rin_p[2] >= 0 & rin_p[2] >= rin_p[3])
            {
                double c1 = 2 * 3.1416 * rin_p[2];
                label24.Text = "С = " + c1;
                double c2 = 2 * 3.1416 * rin_p[3];
                label25.Text = "c = " + c2;
                double s = 3.1416 * rin_p[2] * rin_p[2] / 2 - 3.1416 * rin_p[3] * rin_p[3] / 2;
                label26.Text = "S = " + s;

                pictureBox2.Refresh();
                Graphics g = pictureBox2.CreateGraphics();
                Pen p = new Pen(Color.Black);
                int x1 = rin_p[0] - rin_p[2];
                int y1 = rin_p[1] - rin_p[2];
                int x2 = rin_p[0] - rin_p[3];
                int y2 = rin_p[1] - rin_p[3];
                RectangleF rect1 = new RectangleF(x1, y1, rin_p[2] * 2, rin_p[2] * 2);
                RectangleF rect2 = new RectangleF(x2, y2, rin_p[3] * 2, rin_p[3] * 2);
                g.DrawEllipse(p, rect1);
                g.DrawEllipse(p, rect2);
            }
            else
            {
                MessageBox.Show("Заданные координаты выходят за приделы поля");
            }

        }




    }
}
