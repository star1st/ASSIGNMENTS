using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _280216_01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Text = "Login";
            label1.Text = "Name : ";
            label2.Text = "Password";
            button1.Text = "Ok";
            button2.Text = "Clear";
            button3.Text = "Cancel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "bscs3c") && (textBox2.Text == "bscs3c"))
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Name or Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
