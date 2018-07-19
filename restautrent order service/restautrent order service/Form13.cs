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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";
        string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;
        int price = 0;

        private void Form13_Load(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("select ID from registration", f);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["ID"]).ToString();
            }
            f.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("Select * from registration where ID = '" + comboBox1.Text + "'", f);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["NAME"].ToString();
                textBox4.Text = dr["MOBILE"].ToString();
                textBox3.Text = dr["PHONE"].ToString();
            }
            f.Close();
            f.Open();
            SqlCommand md = new SqlCommand("select id from ds", f);
            SqlDataReader drr = md.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["id"]).ToString();
            }
            f.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();

            SqlCommand cmd = new SqlCommand("Select *from ds where id = '" + comboBox2.Text + "'", f);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox12.Text = dr["NAME"].ToString();
                //  textBox1.Text = dr["name"].ToString();

                price = Convert.ToInt32(dr["PRICE"].ToString());

                textBox13.Text = "Rs." + price.ToString();
            }
            f.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                prds[counter] = comboBox2.Text;
                qty[counter] = Convert.ToInt32(textBox14.Text);
                dataGridView2.Rows.Add(comboBox2.Text, price * Convert.ToInt32(textBox14.Text));
                // textBox1.Text =price * Convert.ToInt32(textBox14.Text).ToString();;
                label5.Text = (Convert.ToInt32(label5.Text) + price * Convert.ToInt32(textBox14.Text)).ToString();
                counter++;
                //    MessageBox.Show("done");


            }
            else
            {
                MessageBox.Show("plz enter quantity");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             SqlConnection f = new SqlConnection(constring);
            f.Open();
           SqlCommand cmd = new SqlCommand("insert into OB(NAME,CNAME,PHONE,PRICE,QUANTITY,TOTAL) values(@A3,@A4,@A5,@A6,@A7,@A8)", f);

            cmd.Parameters.AddWithValue("@A3", textBox12.Text);
           // cmd.Parameters.AddWithValue("@A2",comboBox1.Text);
          cmd.Parameters.AddWithValue("@A4", textBox2.Text);
          cmd.Parameters.AddWithValue("@A5", textBox4.Text);
        //  cmd.Parameters.AddWithValue("@A8", textBox3.Text);
          cmd.Parameters.AddWithValue("@A6", textBox13.Text);
            cmd.Parameters.AddWithValue("@A7", textBox14.Text);
          cmd.Parameters.AddWithValue("@A8",label5.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE you get your order in 30 min");
            f.Close();
            this.Hide();
            Form2 f9 = new Form2();
            f9.Show();
        
        }
    }
}
