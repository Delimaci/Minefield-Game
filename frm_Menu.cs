using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProjectMinefield
{
    public partial class frm_Menu : Form
    {
        Point mouseDownPoint = Point.Empty;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
       

        Timer t1 = new Timer();

        public frm_Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
        private void frm_Menu_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            t1.Interval = 10;
            t1.Tick += new EventHandler(fadeIn);
            t1.Start();
            //this.Location = new Point(250, 150);
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer1_Tick);
            
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gab\Downloads\Bomb_Exploding-Sound_Explorer-68256487.wav");
            player.Play();

        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                t1.Stop();   //this stops the timer if the form is completely displayed

            else
                Opacity += 0.03;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frm_loadgame settingsForm = new frm_loadgame();
            settingsForm.Show();
            this.Visible = false;
          
            
        }

        private void frm_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void frm_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void frm_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_AddUser settingsForm = new frm_AddUser();
            settingsForm.Show();
            this.Visible = false;
        }


        //sounds

    }


}
