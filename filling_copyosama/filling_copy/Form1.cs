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

namespace filling_copy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            this.BackColor = Color.DarkKhaki;
            this.groupBox1.BackColor = Color.PaleGoldenrod;
            this.groupBox2.BackColor = Color.PaleGoldenrod;
            this.button1.BackColor = Color.Khaki;
            this.textBox1.BackColor = Color.LemonChiffon;
            this.textBox2.BackColor = Color.LemonChiffon;
            this.textBox3.BackColor = Color.LemonChiffon;
            this.textBox4.BackColor = Color.LemonChiffon;

            this.Text = "File Copier";
            this.groupBox1.Text = "Source";
            this.label1.Text = "Directory : ";
            this.label2.Text = "File Name : ";
            this.groupBox2.Text = "Destination";
            this.label3.Text = "Directory : ";
            this.label4.Text = "File Name : ";
            this.button1.Text = "Copy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text;
            string d = textBox3.Text + textBox4.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Source Directory ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Source FileName ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Destination Directory ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Destination FileName ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {

                if (File.Exists(s))
                {
                    if (File.Exists(d))
                    {
                        DialogResult dr = MessageBox.Show("\"" + textBox4.Text + "\" is already exist in the directory \"" + textBox3.Text + "\"" + Environment.NewLine + "Do you want to replace?", "File already exist!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            File.Delete(d);
                            File.Copy(s, d);
                            MessageBox.Show("File copied and replaced successfully");
                        }
                        else
                        {
                            MessageBox.Show("Operation Cancelled!");
                        }
                    }

                    else
                    {
                        File.Copy(s, d);
                        MessageBox.Show("File copied successfully");
                    }
                }
                else
                {
                    MessageBox.Show("There is no \"" + textBox2.Text + "\" in directory \"" + textBox1.Text + "\"");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            met1();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            met2();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            met3();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            met1();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            met2();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            met3();
        }

        public void met1()
        {
            if (textBox1.Text != "" && Directory.Exists(textBox1.Text) == false)
            {
                MessageBox.Show("There is no Directory named '" + textBox1.Text + "'");
            }
            if(textBox1.Text=="")
            {
                MessageBox.Show("Source Directory is Empty");
            }
        }

        public void met2()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && File.Exists(textBox1.Text + textBox2.Text) == false)
            {
                MessageBox.Show("There is no File named '" + textBox2.Text + "' in Source Directory");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Source File is Empty");
            }
        }

        public void met3()
        {
            if (textBox3.Text != "" && Directory.Exists(textBox3.Text) == false)
            {
                MessageBox.Show("There is no Directory named '" + textBox3.Text + "'");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Destination Directory is Empty");
            }
        }
    }
}
