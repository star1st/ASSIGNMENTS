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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        Form13 f9 = new Form13();
        string[] prds = new string[50];
        int[] qty = new int[50];
        int counter = 0;
        int price = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into products(Pid,PName,BasePrice,WeightInPounds,InventoryStatus,ProductType)Values(@Pid,@PName,@BasePrice,@WeightInPounds,@InventoryStatus,@ProductType)", f9.oleDbConnection1);
            cmd.Parameters.AddWithValue("@Pid", textBox11.Text);
            cmd.Parameters.AddWithValue("@PName", textBox10.Text);
            cmd.Parameters.AddWithValue("@BasePrice", textBox8.Text);
            cmd.Parameters.AddWithValue("@WeightInPounds", textBox9.Text);
            cmd.Parameters.AddWithValue("@InventoryStatus", textBox6.Text);
            cmd.Parameters.AddWithValue("@ProductType", textBox7.Text);
           
         //  cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            MessageBox.Show("product has been added");
            f9.oleDbConnection1.Close();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Vendor where VID = '" + comboBox1.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox2.Text = dr["VName"].ToString();
                textBox3.Text = dr["PH1"].ToString();
                textBox4.Text = dr["CPName"].ToString();
                textBox5.Text = dr["VStatus"].ToString();

            }

            f9.oleDbConnection1.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Products where Pid = '" + comboBox2.Text + "'", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox12.Text = dr["PName"].ToString();
            price = Convert.ToInt32(dr["BasePrice"].ToString());
            }
            textBox13.Text = "Rs." + price.ToString();
            
            f9.oleDbConnection1.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.button6.Hide();
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select VID from vendor", f9.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"]).ToString();
            }
            f9.oleDbConnection1.Close();
            f9.oleDbConnection1.Open();

            OleDbCommand cm = new OleDbCommand("select Pid from Products", f9.oleDbConnection1);
            OleDbDataReader drr = cm.ExecuteReader();
            while (drr.Read())
            {
                comboBox2.Items.Add(drr["Pid"]).ToString();

            }


            f9.oleDbConnection1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                prds[counter] = comboBox2.Text;
                qty[counter] = Convert.ToInt32(textBox14.Text);
                dataGridView1.Rows.Add(comboBox2.Text, price * Convert.ToInt32(textBox14.Text));


            }
            else
            {
                MessageBox.Show("plz enter quantity");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            f9.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into PO(POID, VName,Status,VID) values(@POID, @VName,@Status,@VID); ", f9.oleDbConnection1);

            cmd.Parameters.AddWithValue("@POID",comboBox2.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Status", textBox5.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
      
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted");
            f9.oleDbConnection1.Close();
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            this.dataGridView1.Rows.Clear();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("product has been added");
     
        }
    }
}
