using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSolution1._15
{
    public partial class ArithmeticApp : Form
    {
        public ArithmeticApp()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (xTextBox.Text == string.Empty || yTextBox.Text == string.Empty)
            {
                MessageBox.Show(@"Empty Textbox", @"Message");
            }
            else
            {
                double x = Convert.ToDouble(xTextBox.Text);
                double y = Convert.ToDouble(yTextBox.Text);
                sumTextBox.Text = (x + y).ToString();
                differenceTextBox.Text = (x - y).ToString();
                productTextBox.Text = (x * y).ToString();
                divisionTextBox.Text = (x / y).ToString();
            }
        }
    }
}
