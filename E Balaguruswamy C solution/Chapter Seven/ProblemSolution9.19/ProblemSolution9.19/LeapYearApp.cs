using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemSolution9._19
{
    public partial class LeapYearApp : Form
    {
        public LeapYearApp()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            LeapYear aLeapYear=new LeapYear();
            aLeapYear.Year = Convert.ToInt32(inputTextBox.Text);
            MessageBox.Show(aLeapYear.leap());
            inputTextBox.Text = string.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
