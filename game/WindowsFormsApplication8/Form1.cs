using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public int timeleft = 8;
        public int timetop = 8;
        public int points = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Cursor.Hide();
            
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top=playground.Bottom-(playground.Bottom/10);
            this.button1.Text = "";
            this.CancelButton = button1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "SIMPLE BRICK GAME";
                

            
            

        }

        private void playground_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += timeleft;
            ball.Top += timetop;
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                timetop += 2;
                timeleft += 2;
                timetop = -timetop;
                points += 1;
            }
            if (ball.Left <= playground.Left)
            {
                timeleft = -timeleft;
            }
            if (ball.Right >= playground.Right)
            {
                timeleft = -timeleft;
            }
            if (ball.Top <= playground.Top)
            {
                timetop = -timetop;
            }
            if (ball.Bottom>=playground.Bottom)
            {
                timer1.Enabled=false;
                Form2 f1 = new Form2();
                f1.Show();
                this.Hide();
                
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
