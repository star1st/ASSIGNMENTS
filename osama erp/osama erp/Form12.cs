using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace osama_erp
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();
        string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;
        int price =0;
       
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from Customer", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CID"]).ToString();
            }
            f9.oleDbConnection1.Close();
            f9.oleDbConnection1.Open();

            OleDbCommand cm = new OleDbCommand("select PID from prod", f9.oleDbConnection1);
            OleDbDataReader drr = cm.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["PID"]).ToString();

            }


            f9.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Customer where CID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["CName"].ToString();
                textBox3.Text = dr["PH1"].ToString();
                textBox4.Text = dr["CAddress"].ToString();
                textBox5.Text = dr["CStatus"].ToString();

            }

            f9.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Products where Pid = '" + comboBox2.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox12.Text = dr["PNAME"].ToString();
               
                  price = Convert.ToInt32(dr["BasePrice"].ToString());
            
            textBox13.Text = "Rs." + price.ToString();
            }
            f9.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                prds[counter] = comboBox2.Text;
                qty[counter] = Convert.ToInt32(textBox14.Text);
                dataGridView1.Rows.Add(comboBox2.Text, price * Convert.ToInt32(textBox14.Text));




            }
            else
            {
                MessageBox.Show("plz enter quantity");
            }
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            
          
            
          
          
            comboBox1.Text = "";
            comboBox2.Text = "";
            this.dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
