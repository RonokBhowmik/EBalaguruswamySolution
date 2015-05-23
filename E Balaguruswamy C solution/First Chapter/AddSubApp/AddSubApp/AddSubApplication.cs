using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSubApp
{
    public partial class AddSubApplication : Form
    {
        public AddSubApplication()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int numberOne = Convert.ToInt32(numberOneTextBox.Text);
            int numberTwo = Convert.ToInt32(numberTwoTextBox.Text);
            int result=numberOne + numberTwo;
            MessageBox.Show(numberOne + @"+ "+numberTwo +@"="+result.ToString(),@"Message");
            numberOneTextBox.Text = string.Empty;
            numberTwoTextBox.Text = string.Empty;
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            int numberOne = Convert.ToInt32(numberOneTextBox.Text);
            int numberTwo = Convert.ToInt32(numberTwoTextBox.Text);
            int result = numberOne - numberTwo;
            MessageBox.Show(numberOne + @"-" + numberTwo + @"=" + result.ToString(), @"Message");
            numberOneTextBox.Text = string.Empty;
            numberTwoTextBox.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
