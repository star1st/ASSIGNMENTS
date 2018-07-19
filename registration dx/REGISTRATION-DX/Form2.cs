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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = true;
            this.textBox1.ForeColor = Color.DarkBlue;
           // this.textBox1.Enabled = false;
            
            this.textBox1.BackColor = Color.BurlyWood;
            this.Text = "RECIEPT";
            //f1.textBox1.Text += "Name:" + textBox1.Text + Environment.NewLine;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BurlyWood;
           
        }
    }
}
