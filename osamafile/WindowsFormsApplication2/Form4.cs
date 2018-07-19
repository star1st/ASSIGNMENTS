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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "Copy";
            this.label1.Text = "F.Address";
            this.label2.Text = "F.Name";
            this.button1.Text = "Copy";
            this.button2.Text = "Clear";
            this.button3.Text = "Cancel";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text +textBox2.Text;
            string d= textBox3.Text+textBox2.Text;
            

            if (File.Exists(d))
            {
                DialogResult dr = MessageBox.Show("Do you want to replace file?");
                if (dr == DialogResult.OK)
                {
                    File.Delete(d);

                    File.Copy(s, d);
                    MessageBox.Show("file copied");

                }
            }
            else if (File.Exists(s))
            {

                File.Copy(s, d);
                MessageBox.Show("file copied");

                //
            }
            else
            {
                MessageBox.Show("File does not exist");
            }

            
            
        }
    }
}
