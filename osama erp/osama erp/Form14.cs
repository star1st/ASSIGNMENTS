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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();


        private void Form14_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select SOID from SO  ", f9.oleDbConnection1);

            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SOID"].ToString());
            }
            f9.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
     OleDbCommand       cmd = new OleDbCommand("select * from SO where SOID='" + comboBox1.Text + "'", f9.oleDbConnection1);
      OleDbDataReader      dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox2.Text += dr["Pid"].ToString() + Environment.NewLine;
                textBox3.Text += dr["PQty"].ToString() + Environment.NewLine;
            }

            f9.oleDbConnection1.Close();
            textBox1.Text = "DC/" + comboBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          f9.oleDbConnection1.Open();
            OleDbCommand cmd=new OleDbCommand("insert into DCProducts Values(@GRNID,@PModel,@PQty);", f9.oleDbConnection1);
                cmd.Parameters.AddWithValue("@DCID", textBox1.Text);
                cmd.Parameters.AddWithValue("@PID", textBox2.Text);
                cmd.Parameters.AddWithValue("@PQTY", textBox3.Text);
            f9.oleDbConnection1.Close();
            MessageBox.Show("Record updated!");
            textBox1.Text = "";
            comboBox1.Items.Remove(comboBox1.Text);
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
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
