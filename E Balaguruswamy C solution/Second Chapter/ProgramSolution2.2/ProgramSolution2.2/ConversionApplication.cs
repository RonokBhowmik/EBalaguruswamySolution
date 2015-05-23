using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramSolution2._2
{
    public partial class ConversionApplication : Form
    {
        public ConversionApplication()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(priceTextBox.Text);
            double myConvertedPrice = price*100;
            MessageBox.Show(myConvertedPrice.ToString()+@" paise", @"Message");
        }
    }
}
