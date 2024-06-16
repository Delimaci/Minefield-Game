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
    public partial class frm_Difficulty : Form
    {
        Point mouseDownPoint = Point.Empty;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static string Lives;

        Timer t1 = new Timer();
        public frm_Difficulty()
        {
            InitializeComponent();
        }

        private void frm_Difficulty_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed

            else
                Opacity += 0.03;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Lives = lbl_Begin.Text;
            lbl_Begin.ForeColor = Color.Red;
            lbl_Amateur.ForeColor = Color.Black;
            lbl_Advanced.ForeColor = Color.Black;
            lbl_Expert.ForeColor = Color.Black;
            lbl_Survival.ForeColor = Color.Black;



        }

        private void lbl_Amateur_Click(object sender, EventArgs e)
        {
            lbl_Begin.ForeColor = Color.Black;
            lbl_Amateur.ForeColor = Color.Red;
            lbl_Advanced.ForeColor = Color.Black;
            lbl_Expert.ForeColor = Color.Black;
            lbl_Survival.ForeColor = Color.Black;
        }

        private void lbl_Advanced_Click(object sender, EventArgs e)
        {
            lbl_Begin.ForeColor = Color.Black;
            lbl_Amateur.ForeColor = Color.Black;
            lbl_Advanced.ForeColor = Color.Red;
            lbl_Expert.ForeColor = Color.Black;
            lbl_Survival.ForeColor = Color.Black;
        }

        private void lbl_Expert_Click(object sender, EventArgs e)
        {
            lbl_Begin.ForeColor = Color.Black;
            lbl_Amateur.ForeColor = Color.Black;
            lbl_Advanced.ForeColor = Color.Black;
            lbl_Expert.ForeColor = Color.Red;
            lbl_Survival.ForeColor = Color.Black;
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
            this.Visible = false;
        }

        private void ctxs_Controls_Click(object sender, EventArgs e)
        {
            frm_Controls settingsForm = new frm_Controls();
            settingsForm.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button6.PointToScreen(new Point(0, button6.Height)));
        }

        private void lbl_Survival_Click(object sender, EventArgs e)
        {
            lbl_Begin.ForeColor = Color.Black;
            lbl_Amateur.ForeColor = Color.Black;
            lbl_Advanced.ForeColor = Color.Black;
            lbl_Expert.ForeColor = Color.Black;
            lbl_Survival.ForeColor = Color.Red;
        }
    }
}
