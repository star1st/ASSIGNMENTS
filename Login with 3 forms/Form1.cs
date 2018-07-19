using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_with_3_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ControlBox = false;
            this.ShowIcon = false;
            this.Text = "LOG IN ";
            this.button1.Text = "Cancel";
            this.button1.BackColor = Color.Blue;
            this.button2.BackColor = Color.Blue;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.button3.BackColor = Color.Blue;
            this.button3.ForeColor = Color.White;
            this.AcceptButton = button3;
            this.CancelButton = button1;
            this.button2.Text = "Clear";
            this.button3.Text = "Ok";
            this.label1.Text = "User ID";
            this.label1.BackColor = Color.Blue;
            this.label2.BackColor = Color.Blue;
            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label2.Text = "Password";
            this.ShowIcon = false;
            
            this.textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "OSAMA" && this.textBox2.Text == "1234")
            {
             
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pass incorrect");

            }
        }
    }
}
