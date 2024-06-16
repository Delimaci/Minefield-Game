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
    public partial class frm_Menu : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            timer.Interval = 7000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1.Show();
            this.Close();
            
        }
    }
}
