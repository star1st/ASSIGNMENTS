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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();

        private void Form11_Load(object sender, EventArgs e)
        {
            this.button4.Hide();

            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select GRNID from GRN", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["GRNID"]).ToString();
            }
            f9.oleDbConnection1.Close();
           
            



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from GRN where GRNID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["VName"].ToString();
                textBox4.Text = dr["DDATE"].ToString();
                textBox3.Text = dr["SNO"].ToString();
                textBox5.Text = dr["Status"].ToString();

            }

            f9.oleDbConnection1.Close();
            f9.oleDbConnection1.Close();

            f9.oleDbConnection1.Open();
            OleDbCommand md = new OleDbCommand("select POID from PO", f9.oleDbConnection1);
            OleDbDataReader drr = md.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["POID"]).ToString();
            }

            f9.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from PO where POID = '" + comboBox2.Text + "'", f9.oleDbConnection1);
            OleDbDataReader drr = cmd.ExecuteReader();

            if (drr.Read())
            {
                textBox8.Text = drr["Pid"].ToString();
                textBox6.Text = drr["PQTY"].ToString();
                textBox7.Text = drr["TotalAmount"].ToString();
              int   ammount = Convert.ToInt32(drr["TotalAmount"].ToString()); 
                 int oneper = ammount / (100);
                int total = oneper * 17;

                textBox1.Text = (total + ammount).ToString();
            
                
                

            }

            f9.oleDbConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice Values(@GRNID,@VendorName,@AmountPayable);", f9.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@VendorName", textBox2.Text);
            cmd.Parameters.AddWithValue("@AmountPayable", textBox1.Text);
            f9.oleDbConnection1.Close();
            MessageBox.Show("Record updated!");
            

            textBox1.Text = "";
            
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Record updated!");


            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
