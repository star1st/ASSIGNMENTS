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
    public partial class Form2 : Form
    {
       
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ShowIcon = false;
            this.textBox5.Enabled = false;
            this.textBox6.Enabled = false;
            this.Text = "BIO DATA";
            this.label1.Text = "NAME";
            this.label2.Text = "CLASS";
            this.label3.Text = "SECTION";
            this.label4.Text = "YEAR";
            this.label5.Text = "PERCE";
            this.button1.Text = "CLEAR";
            this.button2.Text = "CANCEL";
            this.button3.Text = "Enter Marks";
            this.BackColor = Color.White;
            this.AcceptButton = button3;
            this.CancelButton = button2;
            this.label1.ForeColor = Color.Blue;
            this.label2.ForeColor = Color.Blue;
            this.label3.ForeColor = Color.Blue;
            this.label4.ForeColor = Color.Blue;
            this.label5.ForeColor = Color.Blue;
            this.button1.BackColor = Color.Blue;
            this.button2.BackColor = Color.Blue;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.button3.BackColor = Color.Blue;
            this.button3.ForeColor = Color.White;

                
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Show();
            
          
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
