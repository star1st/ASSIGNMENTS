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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        public String constring = "Data Source=COMPUTERPOINT;Initial Catalog=restaurent;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection f = new SqlConnection(constring);
            f.Open();
            SqlCommand cmd = new SqlCommand("select * from OB", f);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
