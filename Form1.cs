using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFormTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


private void btn1_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox1.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            if (txt1 < 0 || txt2 < 0)
            {
                lbl3.ForeColor = Color.Red;
                lbl3.Text = "Value must be numeric and > 0";
            }

            else
            {

                double sum = txt1 + txt2;

                lbl3.Text = sum.ToString();
                
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(txtBox1.Text);
            double txt2 = Convert.ToDouble(txtBox2.Text);

            if (txt1 < 0 || txt2 < 0)
            {
                lbl3.ForeColor = Color.Red;
                lbl3.Text = "Value must be numeric and > 0";
            }

            else
            {

                double sum = txt1 * txt2;
                lbl3.ForeColor = Color.Yellow;
                lbl3.Text = sum.ToString();

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            lbl3.Text = " ";
        }
    }
}
