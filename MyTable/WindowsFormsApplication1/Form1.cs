using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "My Table Generator";
            this.label1.Text = "Hello " +Environment.NewLine+ "     Everyone";
            this.label2.Text = "start table";
            this.label3.Text = "end table";
            this.label4.Text = "table number";
            this.button1.Text = "clear";
            this.button2.Text = "Exit";
            this.button3.Text = "Genrerate";
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            int sno = Convert.ToInt32(textBox1.Text);
            int eno = Convert.ToInt32(textBox2.Text);
            int tno = Convert.ToInt32(textBox3.Text);
            for (int i = sno; i <= eno; i++)
            {
                textBox4.Text += tno.ToString() + "X" + i.ToString() + "=" + (tno * i).ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
