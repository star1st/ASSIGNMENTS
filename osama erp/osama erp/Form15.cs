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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from DC where DCID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["CNAME"].ToString();
                textBox4.Text = dr["DDATE"].ToString();
                textBox3.Text = dr["CCPH"].ToString();
                textBox5.Text = dr["STATUS"].ToString();

            }

            f9.oleDbConnection1.Close();
            f9.oleDbConnection1.Close();

            f9.oleDbConnection1.Open();
            OleDbCommand md = new OleDbCommand("select SOID from SO", f9.oleDbConnection1);
            OleDbDataReader drr = md.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["SOID"]).ToString();
            }

            f9.oleDbConnection1.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select DCID from DC", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["DCID"]).ToString();
            }
            f9.oleDbConnection1.Close();
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand md = new OleDbCommand("Select * from SO where SOID = '" + comboBox2.Text + "'", f9.oleDbConnection1);
            OleDbDataReader drr = md.ExecuteReader();

            if (drr.Read())
            {
                textBox8.Text = drr["PID"].ToString();
                textBox6.Text = drr["PQTY"].ToString();
                textBox7.Text = drr["TOTALAMOUNT"].ToString();
                int ammount = Convert.ToInt32(drr["TOTALAMOUNT"].ToString());
                int oneper = ammount / (100);
                int total = oneper * 17;

                textBox1.Text = (total + ammount).ToString();


            }

            f9.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Invoice Values(@DCID,@CNAME,@AMOUNTPAYABLE);", f9.oleDbConnection1);
            cmd.Parameters.AddWithValue("@DCID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@CNAME", textBox2.Text);
            cmd.Parameters.AddWithValue("@AMOUNTPAYABLE", textBox1.Text);
            f9.oleDbConnection1.Close();
            MessageBox.Show("Record updated!");
            textBox1.Text = "";
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text="";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox2.Text = "";


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
    }
}
