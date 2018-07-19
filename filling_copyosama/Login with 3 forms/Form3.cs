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
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3(Form2 ff2)
        {
            
            InitializeComponent();
           f2 = ff2;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.AcceptButton = button2;
            this.button1.BackColor = Color.Blue;
            this.button2.BackColor = Color.Blue;
            this.button1.ForeColor = Color.White;
            this.button2.ForeColor = Color.White;
            this.ShowIcon = false;
            this.Text = "MARKS";
            this.label1.Text = "VISIUAL PRO";
            this.label1.ForeColor = Color.Blue;
            this.label2.ForeColor = Color.Blue;
            this.label3.ForeColor = Color.Blue;
            this.label4.ForeColor = Color.Blue;
            this.label5.ForeColor = Color.Blue;
            this.label2.Text = "DATA BASE";
            this.label3.Text = "DATA STRUC";
            this.label4.Text = "ENGLISH";
            this.label5.Text = "ISLAMIAT";
            this.button1.Text = "Clear";
            this.button2.Text = "Ok";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Marks;
          
            int tmarks = 500;
            float percent;
            int vp = Convert.ToInt32(textBox1.Text);
            int db = Convert.ToInt32(textBox2.Text);
            int ds = Convert.ToInt32(textBox3.Text);
            int ur = Convert.ToInt32(textBox4.Text);
            int de = Convert.ToInt32(textBox5.Text);


            Marks = vp + db + ds + ur + de;

            percent = (Marks * 100) / tmarks;
           
            if (percent == 90)
           { 
              f2.textBox6.Text += "Grade A+"; 
            }
            else if (percent == 80)
            {
                
               f2.textBox6.Text  += "Grade A";

           }
            else if (percent == 70)
            {
                f2.textBox6.Text  += "Grade B";
                
            }
            else if (percent == 60)
            {
                
                    f2.textBox6.Text  += "Grade C";
            }


            f2.textBox5.Text += +percent + Environment.NewLine;
            f2.textBox6.Text += "Name:" + f2.textBox1.Text + Environment.NewLine;
            f2.textBox6.Text += "Class:" + f2.textBox2.Text + Environment.NewLine;
            f2.textBox6.Text += "Marks:" + Marks + Environment.NewLine;
            f2.textBox6.Text += "Percentage:" + percent + Environment.NewLine;
            this.Close();
           
            
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            
        }

    }
}