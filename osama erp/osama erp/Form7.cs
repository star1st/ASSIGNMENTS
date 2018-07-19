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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();

        private void button3_Click(object sender, EventArgs e)
        {

          f9.oleDbConnection1.Open();
         OleDbCommand cmd = new OleDbCommand("insert into Customer(CID,Cname,PH1,PH2,CGroup,CStatus) values(@CID,@Cname,@PH1,@PH2,@CGroup,@CStatus)", f9.oleDbConnection1);

           cmd.Parameters.AddWithValue("@CID", textBox6.Text);
         cmd.Parameters.AddWithValue("@Cname", textBox2.Text);
          cmd.Parameters.AddWithValue("@PH1", textBox3.Text);
          cmd.Parameters.AddWithValue("@PH2", textBox4.Text);
          cmd.Parameters.AddWithValue("@CGroup", textBox1.Text);
            cmd.Parameters.AddWithValue("@CStatus", textBox5.Text);


           cmd.ExecuteNonQuery();
            MessageBox.Show("customer has been send for Approval");
           f9.oleDbConnection1.Close();
            this.Hide();
            Form10 f5 = new Form10();
            f5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

      
    }
}
