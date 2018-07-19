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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select VID from Vendor ", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"]).ToString();
            }

            f9.oleDbConnection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Vendor where VID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["VName"].ToString();
                textBox3.Text = dr["PH1"].ToString();
                textBox4.Text = dr["CPName"].ToString();
                textBox5.Text = dr["VStatus"].ToString();

            }

            f9.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            // OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox5.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor has been Approved");
            Form2 f = new Form2();
            f.Show();
            this.Hide();
            f9.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            // OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox5.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue accured in Approving Vendor");

            f9.oleDbConnection1.Close();
        }
    }
}
