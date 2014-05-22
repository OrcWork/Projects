using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLesson6_2
{
    public partial class Form1 : Form
    {
        private double _balance;
        public Form1()
        {
            InitializeComponent();

            _balance = 0;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double income;
            double.TryParse(textBoxAmount.Text, out income);

            _balance += income;

            UpdateBalance();
            //MessageBox.Show(textBoxAmount.Text);
        }

        private void UpdateBalance()
        {
            textBoxBalance.Text = _balance.ToString();
        }
    }
}
