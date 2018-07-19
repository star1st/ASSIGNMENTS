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

namespace insertdataq
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "student id";
            this.label2.Text = "s name";
            this.label3.Text = "s address";
            this.label4.Text = "Dob";
            this.button1.Text = "Insert";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into student(sid,sname,sadd,sdob,sdoby)  values (@sid,@sname,@sadd,@sdob,@sdoby)",f2.oleDbConnection1);
            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@sadd", textBox3.Text);
            cmd.Parameters.AddWithValue("@sdob", dateTimePicker1);

           //cmd.Parameters.AddWithValue("@sdate of birth", dateTimePicker1);
           cmd.ExecuteNonQuery();
           MessageBox.Show("record inserted");
            f2.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from countries", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["cname"].ToString());
            }


            f2.oleDbConnection1.Close();

            //this.comboBox1.Items.Add("select * from countries",f2.oleDbConnection1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        /*        this.comboBox1.Items.Clear();
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from cities where cname =  '"+ comboBox1.Text+"'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ciname"].ToString());
            }


            f2.oleDbConnection1.Close();*/
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            f2.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("select * from cities where cname =  '" + comboBox1.Text + "'", f2.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["ciname"].ToString());
            }


            f2.oleDbConnection1.Close();
           
        }
    }
}
