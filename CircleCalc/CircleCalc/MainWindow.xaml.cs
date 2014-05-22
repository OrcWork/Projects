using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Forms;

namespace CircliCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            //IntPtr hwnd = this.Handle;

            //Graphics g = Graphics.FromHwnd(actionField.Handle);
            //Graphics g = Graphics.FromHwnd(hwnd);
            //System.Drawing.Pen myPen1 = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
            //g.DrawRectangle(myPen1, 50, 50, 50, 50);
            //System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 0, 0, 0));
            //e.Graphics.DrawLine(pen, 20, 10, 300, 100);;
            //System.Threading.Thread.Sleep(10);
            //g.Clear(System.Drawing.Color.White);
            //Form1_Paint fp = new Form1_Paint();
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            /*for (int i = 0; i < 100; i++)
            {

                System.Drawing.Pen myPen1 = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
                System.Drawing.Pen myPen2 = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
                Graphics g = Graphics.FromHwnd(actionField.Handle);
                //System.Threading.Thread.Sleep(50);
                g.Clear(System.Drawing.Color.White);
                //System.Threading.Thread.Sleep(50);
                //g.DrawRectangle(myPen2, i, i, 50, 50);
                g.DrawRectangle(myPen1, i, i, 50, 50);

            }*/
        }

        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            System.Drawing.Pen p = new System.Drawing.Pen(System.Drawing.Color.Blue, 5);// цвет линии и ширина
            System.Drawing.Point p1 = new System.Drawing.Point(5, 10);// первая точка
            System.Drawing.Point p2 = new System.Drawing.Point(40, 100);// вторая точка
            gr.DrawLine(p, p1, p2);// рисуем линию
            gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
        }

    }
}
