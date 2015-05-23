using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversionApp
{
    public partial class ConversionApplication : Form
    {
        public ConversionApplication()
        {
            InitializeComponent();
        }

        private void conversionOnebutton_Click(object sender, EventArgs e)
        {
            if (conversionOnebutton.Enabled)
            {
                celsiusTextBox.Enabled = true;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (fahrenheitTextBox.Text ==string.Empty)
            {
                MessageBox.Show(@"Empty Textbox",@"Message");
            }
            else
            {
                double fahrenheit = double.Parse(fahrenheitTextBox.Text);
                double result1 = (5 * fahrenheit) - 32 / 9 + 32;
                MessageBox.Show(result1.ToString(), @"Message");
            }
            
        }

        private void conversionTwoButton_Click(object sender, EventArgs e)
        {
            if (conversionTwoButton.Enabled)
            {
                fahrenheitTextBox.Enabled = true;
            }
        }

        private void calculate1Button_Click(object sender, EventArgs e)
        {
            if (celsiusTextBox.Text==String.Empty)
            {
                MessageBox.Show(@"Empty Textbox",@"Message");
            }
            else
            {
                double celsius = double.Parse(celsiusTextBox.Text);
                double result = (9 * celsius) / 5 + 32;
                MessageBox.Show(result.ToString(), @"Message");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
