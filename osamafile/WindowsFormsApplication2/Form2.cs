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

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "F.Address";
            this.label2.Text = "F.Name";
            this.button1.Text = "Exist";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            if (this.button1.Text == "exist")
            {
                if (File.Exists(s))
                {
                    MessageBox.Show("File exist");

                }
                else
                {

                    MessageBox.Show("File does not exist");
                }
            }
          /*  else if (this.button1.Text == "delete")
            {
                if (File.Exists(s))
                {
                   File.Delete(s);
                    MessageBox.Show("File deleted");

                }
                else
                {

                    MessageBox.Show("File does not exist");
                }
            
            }
            else if (this.button1.Text == "copy")
            {
                if (File.Exists(s))
                {
                    File.Delete(s);
                    MessageBox.Show("File deleted");

                }
                else
                {

                    MessageBox.Show("File does not exist");
                }
            
            }*/
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
