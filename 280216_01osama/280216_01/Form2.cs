using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _280216_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void regularFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog2.ShowColor = true;
            DialogResult dr = fontDialog2.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog2.Font;
                this.textBox1.ForeColor = this.fontDialog2.Color;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.withColorToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.C);
            this.regularFontToolStripMenuItem.ShortcutKeys = (Keys.Control | Keys.R);
        }
    }
}
