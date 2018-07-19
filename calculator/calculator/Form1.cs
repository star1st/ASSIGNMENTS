using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        decimal inputone;
        string arthoperator;
        decimal result;
        public Form1()
            
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".")==false) 
            {
                textBox1.Text = textBox1.Text + ".";
            }
            else
            {
                MessageBox.Show("decimal already inserted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            inputone = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arthoperator = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputone = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arthoperator = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputone = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arthoperator = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            inputone = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            arthoperator = "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            

            if (arthoperator == "+")
            {
                result = inputone + Convert.ToDecimal(textBox1.Text);

            }
            else if (arthoperator == "-")
            {
                result = inputone - Convert.ToDecimal(textBox1.Text);
            }
            else if (arthoperator == "*")
            {
                result = inputone * Convert.ToDecimal(textBox1.Text);
            }
            else if (arthoperator == "/")
            {
                if (textBox1.Text != "0")
                {
                    result = inputone / Convert.ToDecimal(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("please enter denomianator other then 0");
                }
            }

            textBox1.Text = result.ToString();
        }
    }
}
