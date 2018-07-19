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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            
        }
        Form13 f9 = new Form13();

        OleDbCommand cmd;
        OleDbDataReader dr;

        private void Form9_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
          OleDbCommand  cmd = new OleDbCommand("select POID from PO  ",f9.oleDbConnection1);
           
            OleDbDataReader   dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["POID"].ToString());
            }
            f9.oleDbConnection1.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            cmd = new OleDbCommand("select * from PO where POID='" + comboBox1.Text + "'", f9.oleDbConnection1);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              
                textBox2.Text += dr["Pid"].ToString() + Environment.NewLine;
                textBox3.Text += dr["PQty"].ToString() + Environment.NewLine;
            }
               
           f9.oleDbConnection1.Close();
            textBox1.Text = "GRN/" + comboBox1.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd=new OleDbCommand("insert into GRNProducts Values(@GRNID,@PModel,@PQty);", f9.oleDbConnection1);
                cmd.Parameters.AddWithValue("@GRNID", textBox1.Text);
                cmd.Parameters.AddWithValue("@PModel", textBox2.Text);
                cmd.Parameters.AddWithValue("@PQty", textBox3.Text);
            f9.oleDbConnection1.Close();
            MessageBox.Show("Record updated!");
            textBox1.Text = "";
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
