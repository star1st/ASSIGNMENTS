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

namespace filing_03_read
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
            
            this.Text = "File Reader";
            label1.Text = "Directory :";
            label2.Text = "File name : ";
            label3.Text = "File Ext  : ";
            button1.Text = "READ by StreamReader";
            button2.Text = "READ by FileStream";
            textBox3.Text = "File will open here...";

            this.BackColor = Color.MediumOrchid;
            this.textBox1.BackColor = Color.DarkOrchid;
            this.textBox2.BackColor = Color.DarkOrchid;
            this.textBox3.BackColor = Color.DarkViolet;
            this.button1.BackColor = Color.Indigo;
            this.button2.BackColor = Color.Indigo;
            this.comboBox1.BackColor = Color.DarkOrchid;

            this.textBox1.ForeColor = Color.White;
            this.textBox2.ForeColor = Color.White;
            this.textBox3.ForeColor = Color.White;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.comboBox1.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;

            string[] ext = { ".txt",".html",".pdf",".jpg" };
            this.comboBox1.Items.Clear();
            this.comboBox1.Items.AddRange(ext);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text + comboBox1.Text;
            byte[] bb = new byte[100];
            char[] ch = new char[100];


            try
            {
                if (File.Exists(s))
                {
                    FileStream fs = new FileStream(s, FileMode.OpenOrCreate);
                    fs.Read(bb, 0, 100);
                    fs.Close();
                    Decoder d = Encoding.UTF8.GetDecoder();
                    d.GetChars(bb, 0, bb.Length, ch, 0);
                    Console.ReadLine();
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Directory ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else if (textBox2.Text == "")
                    {
                        MessageBox.Show("File Name ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else if (comboBox1.Text == "")
                    {
                        MessageBox.Show("Extension ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MessageBox.Show("There is no file with the name of \"" + textBox2.Text + comboBox1.Text + "\" in Directoty \"" + textBox1.Text + "\"");
                    }
                }
            }

            catch (ArgumentException)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Directory ???");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("File Name ???");
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Extension ???");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + textBox2.Text + comboBox1.Text;
            if (File.Exists(s))
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    StreamReader sr = new StreamReader(s);
                    textBox3.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Directory ???","Unspecified",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("File Name ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if (comboBox1.Text == "")
                {
                    MessageBox.Show("Extension ???", "Unspecified", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else if((comboBox1.SelectedIndex != 0))
                {
                    MessageBox.Show("StreamReader does not work with \""+comboBox1.Text+"\" files"+Environment.NewLine+"It is only work with \".txt\" files", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    MessageBox.Show("There is no file with the name of \"" + textBox2.Text + comboBox1.Text + "\" in Directoty \"" + textBox1.Text + "\"", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        public void met1()
        {
            if (textBox1.Text != "" && Directory.Exists(textBox1.Text) == false && textBox2.Text != "")
            {
                MessageBox.Show("There is no Directory named '" + textBox1.Text + "'");
                textBox2.Text = "";
            }
            if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("Directory is empty");
                textBox2.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Directory.Exists(textBox1.Text) == false && textBox2.Text != "")
            {
                MessageBox.Show("There is no Directory named '" + textBox1.Text + "'");
                textBox2.Text = "";
            }
            if (textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("Directory is empty");
                textBox2.Text = "";
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Directory.Exists(textBox1.Text) == false )
            {
                MessageBox.Show("There is no Directory named '" + textBox1.Text + "'");
                textBox2.Text = "";
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Directory is empty");
                textBox2.Text = "";
            };
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && File.Exists(textBox1.Text + textBox2.Text + comboBox1.Text) == false)
            {
                MessageBox.Show("There is no File named '" + textBox2.Text + comboBox1.Text + "' in Directory '" + textBox1.Text + "'");
            }
        }
    }
}
