using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //System.Drawing.Pen myPen1 = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
            //System.Drawing.Pen myPen2 = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
            //Graphics g = Graphics.FromHwnd(actionField.Handle);
            //System.Threading.Thread.Sleep(50);
            //g.Clear(System.Drawing.Color.White);
            //System.Threading.Thread.Sleep(50);
            //g.DrawRectangle(myPen2, i, i, 50, 50);
            //g.DrawRectangle(myPen1, i, i, 50, 50);
            //Graphics g = Graphics.FromHwnd(this.Handle);
            //g.DrawEllipse(new Pen(Color.Green), 100, 100, 30, 30); 
        }



    }
}
