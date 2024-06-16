using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMinefield
{
    public partial class frm_Controls : Form
    {
        public frm_Controls()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Red;
        }

        private void frm_Controls_Load(object sender, EventArgs e)
        {
            this.Location = new Point(980, 283);
        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
          //  contextMenuStrip1.Show(button6.PointToScreen(new Point(0, button6.Height)));
        }
    }
}
