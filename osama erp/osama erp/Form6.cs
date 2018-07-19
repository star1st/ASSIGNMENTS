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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Form13 f9=new Form13();

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

        private void Form6_Load(object sender, EventArgs e)
        {
              f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select CID from customer", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CID"]).ToString();
            }
            
            f9.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from customer where CID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["Cname"].ToString();
                textBox3.Text = dr["PH1"].ToString();
                textBox4.Text = dr["PH2"].ToString();
                textBox5.Text = dr["CStatus"].ToString();
                textBox1.Text = dr["CGroup"].ToString();

            }

            f9.oleDbConnection1.Close();
        }
        }

      
    }

