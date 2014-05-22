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
using System.Windows.Forms;
using System.Drawing;


namespace ActionCircle
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
            Graphics g = Graphics.FromHwnd(actionField.Handle);
            System.Threading.Thread.Sleep(10);
            g.Clear(System.Drawing.Color.White);
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {

                System.Drawing.Pen myPen1 = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
                System.Drawing.Pen myPen2 = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
                Graphics g = Graphics.FromHwnd(actionField.Handle);
                System.Threading.Thread.Sleep(50);
                g.Clear(System.Drawing.Color.White);
                //System.Threading.Thread.Sleep(50);
                //g.DrawRectangle(myPen2, i, i, 50, 50);
                g.DrawRectangle(myPen1, i, i, 50, 50);

            }
        }
    }
}
