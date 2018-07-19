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

namespace ado_select
{
    public partial class Form2 : Form
    {
        MyConn conn = new MyConn();
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into student(sid, sname,sadd,sdob,sdoby) values(@sid, @sname,@sadd,@sdob,@sdoby); ", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@sid", textBox1.Text);
            cmd.Parameters.AddWithValue("@sname", textBox2.Text);
            cmd.Parameters.AddWithValue("@sadd", textBox3.Text);
            cmd.Parameters.AddWithValue("@sdob", dateTimePicker1);
            cmd.Parameters.AddWithValue("@sdoby",  textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been inserted");
            conn.oleDbConnection1.Close();
        }
    }
}
