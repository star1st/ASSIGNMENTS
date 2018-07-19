using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRATION_DX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.BurlyWood;
            this.Text = "REGISTRATION-DX";
            this.label1.Text = "Name";
            this.label2.Text = "Father's Name";
            this.label3.Text = "D.O.B";
            this.label4.Text = "Country";
            this.label5.Text = "City";
            this.groupBox1.Text = "Gender";
            this.groupBox2.Text = "NIC";
            this.radioButton1.Text = "Male";
            this.radioButton2.Text = "Female";
            this.radioButton3.Text = "Yes";
            this.radioButton4.Text = "No";
            this.checkBox1.Text = "Credit Card";
            this.checkBox2.Text = "Account";
            this.button1.Text = "Submit";
            this.button2.Text = "Clear";
            this.textBox6.Visible = false;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
         f2.textBox1.Text += "Name: " + textBox1.Text + Environment.NewLine + "Father's Name: " + textBox2.Text + Environment.NewLine + "DOB: " + textBox3.Text + Environment.NewLine + "Country: " + textBox4.Text + Environment.NewLine + "City: " + textBox5.Text + Environment.NewLine ;
            if (radioButton1.Checked == true)
            {
                f2.textBox1.Text += "Gender: Male" + Environment.NewLine; ;
            }
            else
            {
                f2.textBox1.Text += "Gender: Female: "+Environment.NewLine;
            }
            if (radioButton3.Checked == true)
            {
                f2.textBox1.Text += "NIC: " + textBox6.Text + Environment.NewLine;
                if (radioButton4.Checked == true)
                {
                    f2.textBox1.Text += "NIC: NIL"+Environment.NewLine;
                }
                if (checkBox1.Checked == true)
                {
                    f2.textBox1.Text += "Credit card"+Environment.NewLine;
                }
                else
                {
                    f2.textBox1.Text += "Account"+Environment.NewLine;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.checkBox1.Checked =false;
            this.checkBox2.Checked = false;
            this.radioButton1.Checked = false;
            this.radioButton2.Checked = false;
            this.radioButton3.Checked = false;
            this.radioButton4.Checked = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.textBox6.Visible = true;
            }
            else
            {
                this.textBox6.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
