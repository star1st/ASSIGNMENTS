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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID,VName,VCity,PH1,CPName,VStatus) values(@VID,@VName,@VCity,@PH1,@CPName,@VStatus)", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VID", textBox6.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox1.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor has been send for Approval");
            f9.oleDbConnection1.Close();
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
