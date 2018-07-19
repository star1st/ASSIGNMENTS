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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form10 f = new Form10();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True");
            string q = "Select * from Table_1 where id='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q,sc);
            DataTable dtb1 = new DataTable();
            sda.Fill(dtb1);
            if (dtb1.Rows.Count == 1)
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("check your name and password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
