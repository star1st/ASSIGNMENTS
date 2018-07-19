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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";

        private void Form12_Load(object sender, EventArgs e)
        {
            textBox11.Text = "000";
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("select MENU_ID from ITEMS", f);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["MENU_ID"]).ToString();
            }
            f.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("insert into ITEMS(MENU_ID,NAME,TYPE,PRICE,CATEGORY) values(@MENU_ID,@NAME,@TYPE,@PRICE,@CATEGORY)", f);

            cmd.Parameters.AddWithValue("@MENU_ID", textBox11.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox10.Text);
            cmd.Parameters.AddWithValue("@TYPE", textBox9.Text);
            cmd.Parameters.AddWithValue("@PRICE", textBox8.Text);
            cmd.Parameters.AddWithValue("@CATEGORY", textBox7.Text);
           // cmd.Parameters.AddWithValue("@email", textBox7.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE");
            f.Close();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("Select * from ITEMS where MENU_ID = '" + comboBox1.Text + "'", f);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox5.Text = dr["NAME"].ToString();
                textBox3.Text = dr["TYPE"].ToString();
                textBox4.Text = dr["PRICE"].ToString();
                textBox2.Text = dr["CATEGORY"].ToString();
               // textBox1.Text = dr["ADDRESS"].ToString();

            }
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
         

            SqlCommand md = new SqlCommand("delete from ITEMS where MENU_ID=@MENU_ID", f);
            md.Parameters.AddWithValue("@MENU_ID", this.comboBox1.Text);
            md.ExecuteNonQuery();
            MessageBox.Show("delete successfully");
            this.textBox5.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox2.Text = "";
            this.textBox11.Text = "";
            this.textBox10.Text = "";
            this.textBox9.Text = "";
            this.textBox8.Text = "";
            this.textBox7.Text = "";
            this.comboBox1.Text = "";
            f.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();


            SqlCommand md = new SqlCommand("update ITEMS set MENU_ID='" + comboBox1.Text + "',PRICE='" + textBox4.Text + "'where MENU_ID='" + comboBox1.Text.ToString() + "' and PRICE='" + textBox4.Text.ToString() + "'", f);
            md.ExecuteNonQuery();
           //qlCommand md = new SqlCommand("update  set MENU_ID='" + comboBox1.Text + "',PRICE='" + textBox4.Text + "'where MENU_ID='" + comboBox1.Text.ToString() + "' and PRICE='" + textBox4.Text.ToString() + "'", f);
          //md.ExecuteNonQuery();
            f.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
