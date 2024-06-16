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
        Point mouseDownPoint = Point.Empty;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public static string passingtext;
        public Color ButtonColor = new Color();
        Timer t1 = new Timer();
        public frm_Controls()
        {
            InitializeComponent();
        }
        public void SetColor()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                label1.ForeColor = Color.Red;
            });

            this.Invoke(Invoker);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //  mProcessCmdEnabled = !mProcessCmdEnabled;
          

            label2.ForeColor = Color.Black;
            label1.ForeColor = Color.Red;

            passingtext = label1.Text;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Click2-Sebastian-759472264.wav");
            player.Play();

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
            passingtext = label2.Text;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Red;

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Click2-Sebastian-759472264.wav");
            player.Play();
        }

        private void frm_Controls_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
      
            //label1.Text = frm_Controls.passingtext;
            Form1 frm = (Form1)Application.OpenForms["Form1"];
            frm.lbl_key.BackColor = Color.Red;



        }

        private void controlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
           this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           contextMenuStrip1.Show(button6.PointToScreen(new Point(0, button6.Height)));

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Click2-Sebastian-759472264.wav");
            player.Play();
        }

        private void setDifficultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Difficulty settingsForm = new frm_Difficulty();
            settingsForm.Show();
            this.Visible = false;
        }

        private void frm_Controls_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
            this.Visible = false;
        }
    }
}
