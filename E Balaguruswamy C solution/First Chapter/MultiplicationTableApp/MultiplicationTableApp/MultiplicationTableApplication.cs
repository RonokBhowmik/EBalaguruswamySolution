using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTableApp
{
    public partial class MultiplicationTableApplication : Form
    {
        public MultiplicationTableApplication()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int startingPoint =Convert.ToInt32(startingPointTextBox.Text);
            int range = Convert.ToInt32(multiplyUpToTextBox.Text);
            int myResult=0;
            int i=1;
            for (;i<=range; i++)
            {
                myResult = (startingPoint*i);
            }
            
            MessageBox.Show(@"Strating Point "+@" "+@"Multiply By"+@" "+@" Result "+
                Environment.NewLine + startingPoint + "\t" + @"*" + "\t"+ (i - 1)  +"\t"+ myResult.ToString(), @"Message");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
