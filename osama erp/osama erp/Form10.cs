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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();
        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f=new Form6();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select CID from Customer ", f9.oleDbConnection1);
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
            OleDbCommand cmd = new OleDbCommand("Select *from Customer where CID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["Cname"].ToString();
                textBox3.Text = dr["PH1"].ToString();
                textBox4.Text = dr["CGroup"].ToString();
                textBox5.Text = dr["CStatus"].ToString();

            }

            f9.oleDbConnection1.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            // OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);
            OleDbCommand cmd = new OleDbCommand("Update Customer set CName=@CName,PH1=@PH1,CGroup=@CGroup, CStatus=@CStatus where CID=@CID", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@CName", textBox2.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@CStatus", textBox5.Text);
            cmd.Parameters.AddWithValue("@CID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("customer  has been Approved");
            Form2 f = new Form2();
            f.Show();
            this.Hide();
            f9.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            // OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);
            OleDbCommand cmd = new OleDbCommand("Update Customer set CName=@CName,PH1=@PH1,CGroup=@CGroup, CStatus=@CStatus where CID=@CID", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@CName", textBox2.Text);
            cmd.Parameters.AddWithValue("@CGroup", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@CStatus", textBox5.Text);
            cmd.Parameters.AddWithValue("@CID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue accured in Approving Vendor");

            f9.oleDbConnection1.Close();
        }
    }
}
