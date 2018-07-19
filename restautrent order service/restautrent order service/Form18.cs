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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("Select * from  up where id = '" + comboBox1.Text + "'", f); 
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox5.Text = dr["name"].ToString();
                textBox3.Text = dr["type"].ToString();
                textBox4.Text = dr["price"].ToString();
                textBox2.Text = dr["category"].ToString();
                // textBox1.Text = dr["ADDRESS"].ToString();

            }
            f.Close();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
          //textBox11.Text = "000";
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("select id from up", f); 
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["id"]).ToString();
            }
            f.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { SqlConnection f = new SqlConnection(constring);
            f.Open();


            SqlCommand md = new SqlCommand("update up set id='" + comboBox1.Text + "',price='" + textBox4.Text + "'where id='" + comboBox1.Text.ToString() + "'and price='" + textBox4.Text.ToString() + "'", f);
            md.ExecuteNonQuery();
           //qlCommand md = new SqlCommand("update  set MENU_ID='" + comboBox1.Text + "',PRICE='" + textBox4.Text + "'where MENU_ID='" + comboBox1.Text.ToString() + "' and PRICE='" + textBox4.Text.ToString() + "'", f);
          //md.ExecuteNonQuery();
            MessageBox.Show("done");
            f.Close();
            string name, a, b, c, d;
            name = textBox5.Text;
            c= textBox3.Text;
           d=comboBox1.Text.ToString();
            a = textBox4.Text.ToString();
            b = textBox2.Text.ToString();
         // c = textBox5.Text.ToString();

            richTextBox1.Text += "id\t" + d + "\n";
            richTextBox1.Text = "NAME\t" + name + "\n";
            richTextBox1.Text += "type\t" + c + "\n";
          //richTextBox1.Text += "DATE OF ORDER\t" + date + "\n";
            richTextBox1.Text += "price\t" + a + "\n";
            richTextBox1.Text += "category\t" + b + "\n";
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
