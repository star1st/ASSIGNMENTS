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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";


        private void Form11_Load(object sender, EventArgs e)
        {
            textBox11.Text = "E0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
           SqlCommand cmd = new SqlCommand("insert into re(id,name,mobile,phone,address,email) values(@id,@name,@mobile,@phone,@address,@email)", f);

            cmd.Parameters.AddWithValue("@id", textBox11.Text);
            cmd.Parameters.AddWithValue("@name", textBox10.Text);
            cmd.Parameters.AddWithValue("@mobile", textBox9.Text);
            cmd.Parameters.AddWithValue("@phone", textBox8.Text);
            cmd.Parameters.AddWithValue("@address", textBox6.Text);
           cmd.Parameters.AddWithValue("@email", textBox7.Text);
         
            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE");
            f.Close();
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
