using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**

 *

 * Name: Dylan Angell

 * Teacher: Mr.Hardman

 * Assignment #2, Program #2

 * Date Last Modified: Oct,19,2016

 *
 
 */
namespace Assignment_2
{
    public partial class frmAssignment2 : Form
    {
        public frmAssignment2()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //these lines of code allow the user to input numbers in the textbox
            double Mark1 = Convert.ToDouble(txtMark1.Text)/100;
            double Mark2 = Convert.ToDouble(txtMark2.Text)/100;
            double Mark3 = Convert.ToDouble(txtMark3.Text)/100;
            double Mark4 = Convert.ToDouble(txtMark4.Text)/100;
            double Mark5 = Convert.ToDouble(txtMark5.Text)/100;
            double Average = (Mark1 + Mark2 + Mark3 + Mark4 + Mark5) / 5.0;

            //these lines of code tell the program what to print, where to print it, and what form of number to print it as
            lblAverage.Text = String.Format("{0,10}{1,15:P}\n{2,10}{3,15:P}\n{4,10}{5,15:P}\n{6,10}{7,15:P}\n{8,10}{9,15:P}\n\n{10,10}{11,15:P}",
                "Grade 1:", Mark1, "Grade 2:", Mark2, "Grade 3:", Mark3, "Grade 4:", Mark4, "Grade 5:", Mark5, "Average:", Average );
        }
    }
}
