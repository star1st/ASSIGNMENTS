using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(textBox1.Text + textBox2.Text);
            //textBox3.Text = sr.ReadToEnd();
            //sr.Close();

            string fname = textBox1.Text + textBox2.Text;


            FileStream sr = new FileStream(fname, FileMode.Open, FileAccess.Read);
            byte[] bb = new byte[1000];
            char[] ch = new char[1000];
            sr.Read(bb, 0, 100);
            Decoder de = Encoding.UTF8.GetDecoder();
            de.GetChars(bb, 0, bb.Length, ch, 0);
            foreach (char C in ch) 
            {
                this.textBox3.Text += C;
                }
           
            sr.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
