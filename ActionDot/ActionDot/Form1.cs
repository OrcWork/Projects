using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ActionDot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {

                Pen myPen1 = new Pen(Color.Black, 2);
                Pen myPen2 = new Pen(Color.Red, 2);
                Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
                System.Threading.Thread.Sleep(50);
                g.Clear(Color.White);
                //System.Threading.Thread.Sleep(50);
                //g.DrawRectangle(myPen2, i, i, 50, 50);
                g.DrawRectangle(myPen1, i, i, 50, 50);
                
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            System.Threading.Thread.Sleep(10);
            g.Clear(Color.White);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
