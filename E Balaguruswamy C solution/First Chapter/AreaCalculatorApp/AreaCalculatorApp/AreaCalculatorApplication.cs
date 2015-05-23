using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCalculatorApp
{
    public partial class AreaCalculatorApplication : Form
    {
        public AreaCalculatorApplication()
        {
            InitializeComponent();
        }

        const double PI = 3.1416;
        private void calculateRadiusButton_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(radiusTextBox.Text);
            double area = PI * radius * radius;
            MessageBox.Show(area.ToString(), @"Message");
            radiusTextBox.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
