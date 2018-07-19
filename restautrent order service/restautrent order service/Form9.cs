using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace restautrent_order_service
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";

        private void button14_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

          
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("select ID from registration",f);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ID"]).ToString();
            }
            f.Close();
          
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("Select * from registration where ID = '" + comboBox1.Text + "'",f);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["NAME"].ToString();
                textBox3.Text = dr["PHONE"].ToString();
                textBox4.Text = dr["MOBILE"].ToString();
                textBox5.Text = dr["EMAIL"].ToString();
                textBox1.Text = dr["ADDRESS"].ToString();

            }
            f.Close();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form12 f = new Form12();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 f = new Form17();
            f.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form18 f = new Form18();
            f.Show();
            this.Hide();
        }
    }
}
